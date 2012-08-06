<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="Pesquisa.aspx.cs" Inherits="imob_app.client.Pesquisa" %>

<%@ Register TagPrefix="rpt" TagName="Imovel" Src="~/controls/ImovelRepeater.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <h7 class="head-1"><strong>Resultados da Pesquisa</strong></h7>
    <h8><asp:Label runat="server" ID="lblFiltros"></asp:Label></h8>
    <rpt:Imovel runat="server" ID="imoveis" TotalRegistros="6" />
</asp:Content>
