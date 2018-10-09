<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="kategoriekle.aspx.cs" Inherits="kategoriekle" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="col-md-6 ">
         <div class="panel panel-info">
  <div class="panel-heading" style="height:35px;">
    <h3 class="panel-title">Kategori Ekle</h3>
  </div>
  <div class="panel-body">
   <form class="form-horizontal">
        <div class="form-group">
            <label>Kategori Adı</label>
            <asp:TextBox ID="txtKategoriAdi" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
          <div class="form-group">
              <asp:Button ID="btnKategoriEkle" runat="server" CssClass="btn btn-success" Text="Kategori Ekle" OnClick="btnKategoriEkle_Click" />
        </div>
    </form>
  </div>
</div>
   
        </div> 
</asp:Content>

