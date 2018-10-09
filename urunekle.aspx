<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="urunekle.aspx.cs" Inherits="urunekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="col-md-6 ">
        <div class="panel panel-info">
  <div class="panel-heading" style="height:35px;">
    <h3 class="panel-title">Ürün Ekle</h3>
  </div>
  <div class="panel-body">
   <form class="form-horizontal">
        <div class="form-group">
            <label>Ürün Adı</label>
            <asp:TextBox ID="txtUrunAdi" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
         <div class="form-group">
            <label>Ürün Kategori</label><br />
            <asp:DropDownList ID="drpUrun" style="width:100%;" CssClass="btn dropdown-toggle selectpicker btn-default" runat="server"></asp:DropDownList>
        </div>
         <div class="form-group">
            <label>Ürün Fiyatı</label>
              <asp:TextBox ID="txtFiyati" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
          <div class="form-group">
     
              <asp:Button ID="btnUrunEkle" runat="server" CssClass="btn btn-success" Text="Ürün Ekle" />
        </div>
    </form>
  </div>
</div>
    
        </div>
</asp:Content>

