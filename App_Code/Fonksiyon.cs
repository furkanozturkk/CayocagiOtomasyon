using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Fonksiyon
/// </summary>
public class Fonksiyon
{
		public static string CalculateSHA256(string text, Encoding enc)
        {
            byte[] buffer = enc.GetBytes(text);
            SHA256CryptoServiceProvider cryptoTransformSHA1 = new SHA256CryptoServiceProvider();
            return BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
        }
}