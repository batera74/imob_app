<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="DetalheImovel.aspx.cs" Inherits="imob_app.client.DetalheImovel" %>

<%@ Register TagPrefix="galeria" TagName="Galeria" Src="~/controls/galeria.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/shadowbox.js" type="text/javascript"></script>
    <script src="js/demo.js" type="text/javascript"></script>
    <link rel="stylesheet" href="css/shadowbox/shadowbox.css" media="screen" />
    <script type="text/javascript">
        Shadowbox.init({
            overlayOpacity: 0.8
        }, setupDemos);

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <section id="content">
	    <div class="container_24">
            <div class="wrapper">
                <h7 class="head-1"><strong>Detalhes do Imóvel</strong></h7>
                <br />
                <br />
                <div id="galeriaPai">
                    <h8 class="head-1"><strong>Galeria de Fotos</strong></h8> 
                    (clique para ampliar)                    
                    <br />
                    <br />
                    
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <galeria:Galeria runat="server" ID="galeria" Admin="false"/>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    
                    <div style="text-align: left;">
                        <br />
                        <a href="EstouInteressado.aspx" rel="shadowbox;width=500;height=370">
                        <asp:Label ID="lblDetalhes" runat="server" CssClass="button" Text='Estou interessado $'></asp:Label></a>
                    </div>
                </div>
                <div id="detalhesPai">
                    <h8 class="head-1"><strong><asp:Label ID="lblImovel" runat="server"></asp:Label></strong></h8>                    
                    <h8><asp:Label ID="lblValor" runat="server" CssClass="tituloValor"></asp:Label></h8>
                    <br />
                    <div style="margin-top: 8px;">
                    <h8 class="head-1"><strong>Características do Imóvel</strong></h8>     
                    <div id="conteudoDetalhes">                           
                            <h10>Referência: </h10>
                            <h11><asp:Label ID="lblID" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Localização: </h10>
                            <h11><asp:Label ID="lblCidade" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Posicação do Imóvel: </h10>
                            <h11><asp:Label ID="lblPosicao" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Padrão: </h10>
                            <h11><asp:Label ID="lblPadrao" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Valor Condomínio: </h10>
                            <h11><asp:Label ID="lblCondominio" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Valor IPTU: </h10> 
                            <h11><asp:Label ID="lblIPTU" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Banheiros: </h10>
                            <h11><asp:Label ID="lblBanheiro" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Suítes: </h10>
                            <h11><asp:Label ID="lblSuite" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Área: </h10>
                            <h11><asp:Label ID="lblArea" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Garagem: </h10>
                            <h11><asp:Label ID="lblGaragem" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Portaria: </h10>
                            <h11><asp:Label ID="lblPortaria" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Elevador: </h10>
                            <h11><asp:Label ID="lblElevador" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Vazio: </h10>
                            <h11><asp:Label ID="lblVazio" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Estado do Imóvel: </h10>
                            <h11><asp:Label ID="lblEstadoImovel" runat="server"></asp:Label></h11>
                            <br />
                            <h10>Financiamento: </h10>
                            <h11><asp:Label ID="lblFinanciamento" runat="server"></asp:Label></h11>
                        </div> 
                        <div id="conteudoDetalhes2">
                        <table>
                            <tr>
                                <td class="caracteristicas">
                                    <h10>Acabamento:</h10><asp:DataList ID="dtAcabamento" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="images/link-marker.gif" class="itemCaracteristica"/>
                                            <h11><asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label></h11>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas">
                                    <h10>Armários:</h10><asp:DataList ID="dtArmarios" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="images/link-marker.gif" class="itemCaracteristica"/>
                                            <h11><asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label></h11>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas">
                                    <h10>Íntima:</h10><asp:DataList ID="dtIntima" runat="server">
                                        <ItemTemplate>
                                                <img alt="" src="images/link-marker.gif" class="itemCaracteristica"/>
                                                <h11><asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label></h11>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                            </tr>
                            <tr>
                                <td class="caracteristicas1">
                                    <h10>Lazer:</h10><asp:DataList ID="dtLazer" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="Images/link-marker.gif" class="itemCaracteristica"/>
                                            <h11><asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label></h11>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas1">
                                    <h10>Serviços:</h10><asp:DataList ID="dtServicos" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="Images/link-marker.gif" class="itemCaracteristica"/>
                                            <h11><asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label></h11>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas1">
                                    <h10>Social:</h10><asp:DataList ID="dtSocial" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="Images/link-marker.gif" class="itemCaracteristica" />
                                            <h11><asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label></h11>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                            </tr>
                        </table>
                        </div>                                        
                        </div>
                    </div>
            </div>
        </div>
    </section>
</asp:Content>
