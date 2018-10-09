using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DB
/// </summary>
public class DB
{
    private static DB _db = null;
    private SqlConnection _con;

    public static DB getInstance()
    {
        if(_db == null)
        {
            _db = new DB(new SqlConnection(ConfigurationManager.ConnectionStrings["CayOcagiconnection"].ToString()));
        }

        return _db;
    }

    public DB(SqlConnection con)
    {
        _con = con;
    }

    public void BaglantiAc()
    {
        if (_con.State == System.Data.ConnectionState.Closed)
            _con.Open();
    }

    public void BaglantiKapat()
    {
        if (_con.State == System.Data.ConnectionState.Open)
            _con.Close();
    }

    public void SqlCalistir(string sql)
    {
        this.BaglantiAc();
        SqlCommand cmd = new SqlCommand(sql, _con);
        cmd.ExecuteNonQuery();
        this.BaglantiKapat();
    }

    public void StoredCalistir(string storedprocedure, Hashtable ht = null)
    {
        this.BaglantiAc();
        SqlCommand cmd = new SqlCommand(storedprocedure, _con);
        cmd.CommandType = CommandType.StoredProcedure;
        if (ht != null)
        {
            foreach (string key in ht.Keys)
            {
                cmd.Parameters.AddWithValue(key, ht[key]);
            }
        }
        cmd.ExecuteNonQuery();
        this.BaglantiKapat();
    }

    public DataTable getTable(string sql, Hashtable ht = null)
    {
        DataTable dt = new DataTable();
        using(SqlDataAdapter da = new SqlDataAdapter(sql, _con))
        {
            if (ht != null)
            {
                foreach (string key in ht.Keys)
                {
                    da.SelectCommand.Parameters.AddWithValue(key, ht[key]);
                }
            }
            da.Fill(dt);
        }

        return dt;
    }

    public string[,] getRows(string sql, Hashtable ht = null)
    {
        DataTable dt = this.getTable(sql, ht);

        string[,] rows = new string[dt.Rows.Count, dt.Columns.Count];

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                rows[i, j] = dt.Rows[i][j].ToString();
            }
        }

        return rows;
    }

    public SqlDataReader getDataReader(string sql, Hashtable ht = null)
    {
        SqlCommand cmd = new SqlCommand(sql, _con);
        
        if (ht != null)
        {
            foreach (string key in ht.Keys)
            {
                cmd.Parameters.AddWithValue(key, ht[key]);
            }
        }
        return cmd.ExecuteReader();

          
    }
}