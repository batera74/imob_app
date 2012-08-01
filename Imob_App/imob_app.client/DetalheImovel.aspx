<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="DetalheImovel.aspx.cs" Inherits="imob_app.client.DetalheImovel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/detalheImovel.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <h7 class="head-1">Detalhes do Imóvel</h7>
    <div id="galeriaPai">
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <div id="galeria">
                    <asp:Label ID="Label2" CssClass="labelCaracteristicas" runat="server" Text="Galeria de Fotos "></asp:Label>
                    <br />
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="9pt" ForeColor="#f45c40"
                        Text="(Clique na imagem para ampliar)"></asp:Label>
                    &nbsp;<asp:DataList ID="dtlMini" runat="server" RepeatColumns="3" Height="146px"
                        Width="252px">
                        <ItemTemplate>
                            <div id="galMiniImg">
                                <a href="<%# Eval("Imagem", "Images/Imoveis/lightbox/{0}") %>" rel="lightbox[galeria]">
                                    <asp:ImageButton ID="Imagem" runat="server" Height="63px" Width="74px" ImageUrl='<%# Eval("Imagem", "~/Images/Imoveis/mini/{0}") %>'
                                        OnClick="Imagem_Click" />
                                    <</a>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
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
                <br />
                <br />
            </div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <table>
                <tr>
                    <td class="caracteristicas">
                        Acabamento:<asp:DataList ID="dtAcabamento" runat="server">
                            <ItemTemplate>
                                <img alt="" src="images/bull-h2.png" />
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                    <td class="caracteristicas">
                        Armários:<asp:DataList ID="dtArmarios" runat="server">
                            <ItemTemplate>
                                <img alt="" src="images/bull-h2.png" />
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                    <td class="caracteristicas">
                        Íntima:<asp:DataList ID="dtIntima" runat="server">
                            <ItemTemplate>
                                <img alt="" src="images/bull-h2.png" />
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                </tr>
                <tr>
                    <td class="caracteristicas">
                        Lazer:<asp:DataList ID="dtLazer" runat="server">
                            <ItemTemplate>
                                <img alt="" src="Images/bull-h2.png" />
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                    <td class="caracteristicas">
                        Serviços:<asp:DataList ID="dtServicos" runat="server">
                            <ItemTemplate>
                                <img alt="" src="Images/bull-h2.png" />
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                    <td class="caracteristicas">
                        Social:<asp:DataList ID="dtSocial" runat="server">
                            <ItemTemplate>
                                <img alt="" src="Images/bull-h2.png" />
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ds_item") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
