<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="CadastroImovel.aspx.cs" Inherits="imob_app.client.CadastroImovel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <h7 class="head-1"><strong></strong></h7>
    <rpt:Imovel runat="server" ID="imoveis" TotalRegistros="6" />
</asp:Content>
