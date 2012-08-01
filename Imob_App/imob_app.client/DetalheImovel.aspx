<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="DetalheImovel.aspx.cs" Inherits="imob_app.client.DetalheImovel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/detalheImovel.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <section id="content">
	    <div class="container_24">
            <div class="wrapper">
                <h7 class="head-1">Detalhes do Imóvel</h7>
                <br />
                <br />
                <div id="galeriaPai">
                    <h8>Galeria de Fotos
                    (clique para ampliar)</h8> 
                    <asp:DataList ID="dtlMini" runat="server" RepeatColumns="3" Height="146px" Width="252px">
                        <ItemTemplate>
                            <div id="galMiniImg">
                                <a href="../Imagem.ashx?idFoto=<%# Eval("id_imagem") %>" rel="lightbox[galeria]">
                                    <asp:ImageButton ID="Imagem" runat="server" Height="63px" Width="74px" ImageUrl='<%# Eval("id_imagem", "../Imagem.ashx?idFoto={0}") %>' />
                                </a>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>           
                </div>
                <div id="detalhesPai">
                    <h8>Características do Imóvel</h8>
                    <div id="conteudoDetalhes">
                        <div id="carac1">
                            <asp:Label ID="lblImovel" CssClass="labelCaracteristicas" runat="server" Text="{Imovel}"></asp:Label>
                            <br />
                            <asp:Label ID="lblID" CssClass="labelCaracteristicas" runat="server" Text="Referência: "></asp:Label>
                            <br />
                            <asp:Label ID="lblCidade" CssClass="labelCaracteristicas" runat="server" Text="{Cidade}"></asp:Label>
                            <br />
                            <asp:Label ID="lblValor" CssClass="labelCaracteristicas" runat="server" Text="Valor: "></asp:Label>
                            <br />
                            <asp:Label ID="lblCondominio" CssClass="labelCaracteristicas" runat="server" Text="Valor Condomínio: "></asp:Label>
                            <br />
                            <asp:Label ID="lblIPTU" CssClass="labelCaracteristicas" runat="server" Text="Valor IPTU: "></asp:Label>
                        </div>
                        <div id="especificacoes">
                            <asp:Label ID="lblBanheiro" CssClass="labelCaracteristicas" runat="server" Text="Banheiros:"></asp:Label>
                            <br />
                            <asp:Label ID="lblGaragem" CssClass="labelCaracteristicas" runat="server" Text="Garagem: "></asp:Label>
                            <br />
                            <asp:Label ID="lblPortaria" CssClass="labelCaracteristicas" runat="server" Text="Portaria: "></asp:Label>
                            <br />
                            <asp:Label ID="lblElevador" CssClass="labelCaracteristicas" runat="server" Text="Elevador: "></asp:Label>
                            <br />
                            <asp:Label ID="lblVazio" runat="server" Text="Vazio: "></asp:Label>
                            <br />
                        </div>
                        <div>
                        <table>
                            <tr>
                                <td class="caracteristicas">
                                    Acabamento:<asp:DataList ID="dtAcabamento" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="images/link-marker.gif" class="itemCaracteristica"/>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas">
                                    Armários:<asp:DataList ID="dtArmarios" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="images/link-marker.gif" class="itemCaracteristica"/>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas">
                                    Íntima:<asp:DataList ID="dtIntima" runat="server">
                                        <ItemTemplate>
                                                <img alt="" src="images/link-marker.gif" class="itemCaracteristica"/>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                            </tr>
                            <tr>
                                <td class="caracteristicas">
                                    Lazer:<asp:DataList ID="dtLazer" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="Images/link-marker.gif" class="itemCaracteristica"/>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas">
                                    Serviços:<asp:DataList ID="dtServicos" runat="server">
                                        <ItemTemplate>
                                            <img alt="" src="Images/link-marker.gif" class="itemCaracteristica"/>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td class="caracteristicas">
                                    Social:<asp:DataList ID="dtSocial" runat="server">
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
        </div>
    </section>
</asp:Content>

