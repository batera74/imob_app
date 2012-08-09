<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="MeusImoveis.aspx.cs" Inherits="imob_app.client.MeusImoveis" %>
<%@ Register TagPrefix="rpt" TagName="Imovel" Src="~/controls/ImovelRepeater.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <br />
    <h7 class="head-1"><strong>Meus Imóveis</strong></h7>
    <rpt:Imovel runat="server" ID="imoveis" TotalRegistros="6" />
</asp:Content>
