<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="DetalheImovel.aspx.cs" Inherits="imob_app.client.DetalheImovel" %>
<%@ Register TagPrefix="galeria" TagName="Galeria" Src="~/controls/galeria.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <script type="text/javascript">
        $(function () {
            $('#galMiniImg a').lightBox();
        });
    </script>
    <section id="content">
	    <div class="container_24">
            <div class="wrapper">
            <br />
                <h7 class="head-1">Detalhes do Imóvel</h7>
                <br />
                <br />
                <br />
                <div id="galeriaPai">
                    <h8>Galeria de Fotos</h8> 
                    <br />(clique para ampliar)                    
                    <br />
                    <br />
                    
                    <galeria:Galeria runat="server" ID="galeria" />
                </div>
                <div id="detalhesPai">
                    <h8>Características do Imóvel</h8>
                    <div id="conteudoDetalhes">
                        <div id="carac1">
                            <h10>Categoria: </h10>
                            <asp:Label ID="lblImovel" CssClass="labelCaracteristicas" runat="server"></asp:Label>
                            <br />
                            <h10>Referência: </h10>
                            <asp:Label ID="lblID" CssClass="labelCaracteristicas" runat="server"></asp:Label>
                            <br />
                            <h10>Localização: </h10>
                            <asp:Label ID="lblCidade" CssClass="labelCaracteristicas" runat="server"></asp:Label>
                            <br />
                            <h10>Valor: </h10>
                            <asp:Label ID="lblValor" CssClass="labelCaracteristicas" runat="server"></asp:Label>
                            <br />
                            <h10>Valor Condomínio: </h10>
                            <asp:Label ID="lblCondominio" CssClass="labelCaracteristicas" runat="server"></asp:Label>
                            <br />
                            <h10>Valor IPTU: </h10> 
                            <asp:Label ID="lblIPTU" CssClass="labelCaracteristicas" runat="server"></asp:Label>
                        </div>
                        <div id="especificacoes">
                            <h10>Banheiros: </h10>
                            <asp:Label ID="lblBanheiro" CssClass="labelCaracteristicas" runat="server"></asp:Label>
                            <br />
                            <h10>Garagem: </h10>
                            <asp:Label ID="lblGaragem" CssClass="labelCaracteristicas" runat="server"></asp:Label>
                            <br />
                            <h10>Portaria: </h10>
                            <asp:Label ID="lblPortaria" CssClass="labelCaracteristicas" runat="server"></asp:Label>
                            <br />
                            <h10>Elevador: </h10>
                            <asp:Label ID="lblElevador" CssClass="labelCaracteristicas" runat="server"></asp:Label>
                            <br />
                            <h10>Vazio: </h10>
                            <asp:Label ID="lblVazio" runat="server"></asp:Label>
                            <br />
                        </div>
                        <div>
                        <table>
                            <tr>
                                <td class="caracteristicas">
                                    <h10>Acabamento:</h10><asp:DataList ID="dtAcabamento" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="images/link-marker.gif" class="itemCaracteristica"/>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas">
                                    <h10>Armários:</h10><asp:DataList ID="dtArmarios" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="images/link-marker.gif" class="itemCaracteristica"/>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas">
                                    <h10>Íntima:</h10><asp:DataList ID="dtIntima" runat="server">
                                        <ItemTemplate>
                                                <img alt="" src="images/link-marker.gif" class="itemCaracteristica"/>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                            </tr>
                            <tr>
                                <td class="caracteristicas">
                                    <h10>Lazer:</h10><asp:DataList ID="dtLazer" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="Images/link-marker.gif" class="itemCaracteristica"/>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas">
                                    <h10>Serviços:</h10><asp:DataList ID="dtServicos" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="Images/link-marker.gif" class="itemCaracteristica"/>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas">
                                    <h10>Social:</h10><asp:DataList ID="dtSocial" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="Images/link-marker.gif" class="itemCaracteristica" />
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                            </tr>
                        </table>
                        </div>
                    </div>
            </div>
            <div>
                <a href="">
                <asp:Label ID="lblDetalhes" runat="server" CssClass="button" Text='Estou interessado $'></asp:Label></a>
            </div>
        </div>
    </section>
</asp:Content>
