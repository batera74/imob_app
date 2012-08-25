<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="MeusImoveis.aspx.cs" Inherits="imob_app.client.MeusImoveis" %>
<%@ Register TagPrefix="rpt" TagName="Imovel" Src="~/controls/ImovelRepeater.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <h7 class="head-1"><strong>Meus Imóveis</strong></h7>
    <br />
    <a href="CadastroImovel.aspx" rel="shadowbox;width=500;height=370">
    <asp:Label ID="lblDetalhes" runat="server" CssClass="button" Text='Novo Imóvel'></asp:Label></a>
    <br />
    <rpt:Imovel runat="server" ID="imoveis" TotalRegistros="6" />
</asp:Content>
