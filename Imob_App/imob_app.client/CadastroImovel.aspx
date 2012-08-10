<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="CadastroImovel.aspx.cs" Inherits="imob_app.client.CadastroImovel" %>

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
                    
                    <galeria:Galeria runat="server" ID="galeria" />
                    
                    <div style="text-align: center;">
                        <br />
                        <a href="EstouInteressado.aspx" rel="shadowbox;width=500;height=370">
                        <asp:Label ID="lblDetalhes" runat="server" CssClass="button" Text='Salvar Alterações >'></asp:Label></a>
                    </div>
                </div>
                <div id="detalhesPai">
                    <div id="formImovel">                        
                        <div class="row-1">
                            <h10>Categoria: </h10>
                            <br />
                            <asp:DropDownList ID="ddlCategoria" runat="server" Style="width: 195px" AutoPostBack="True">
                            </asp:DropDownList>                    
                        </div>
                        <div class="row-1">
                            <h10>Dormitórios: </h10>
                            <br />
                            <asp:DropDownList ID="ddlDormitorios" runat="server" Style="width: 195px" AutoPostBack="True">
                            </asp:DropDownList>                    
                        </div>
                        <h10>Valor do Imóvel: </h10>
                        <asp:TextBox ID="txtValor" runat="server" Width="110"></asp:TextBox>
                    <br />
                    <div style="margin-top: 8px;">
                    <h8 class="head-1"><strong>Características do Imóvel</strong></h8>     
                    <div id="conteudoDetalhes">
                        
                            <div class="row-1">
                                <h10>Referência: </h10>
                                <asp:TextBox ID="txtId" runat="server" Width="60"></asp:TextBox>                            
                            </div>
                            
                            <div class="row-1">
                            <h10>Localização: </h10>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div id="local">
                                    <asp:DropDownList ID="ddlUF" runat="server" Style="width: 50px" AutoPostBack="True"
                                        CausesValidation="True">
                                    </asp:DropDownList>
                                    <br />
                                    <asp:DropDownList ID="ddlMunicipio" runat="server" Style="width: 195px" AutoPostBack="True">                                        
                                    </asp:DropDownList>
                                    <br />
                                    <asp:DropDownList ID="ddlBairro" runat="server" Style="width: 195px" AutoPostBack="True">
                                    </asp:DropDownList>
                                </div>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                            </div>
                            <br />
                            <br />
                            <div class="row-1">
                                <h10>Valor Condomínio: </h10>
                                <asp:TextBox ID="txtValorCondominio" runat="server" Width="70"></asp:TextBox>                            
                            </div>
                            <div class="row-1">
                                <h10>Valor IPTU: </h10> 
                                <asp:TextBox ID="txtValorIptu" runat="server" Width="70"></asp:TextBox>
                            </div>
                            <div class="row-1">
                                <h10>Banheiros: </h10>
                                <asp:TextBox ID="txtBanheiros" runat="server" Width="50"></asp:TextBox>
                            </div>
                            <div class="row-1">
                                <h10>Garagem: </h10>
                                <asp:TextBox ID="txtGaragem" runat="server" Width="120"></asp:TextBox>
                            </div>
                            <div class="row-1">
                                <h10>Portaria: </h10>
                                <br />
                                <asp:DropDownList ID="ddlPortaria" runat="server" Style="width: 70px" AutoPostBack="True" CausesValidation="True">
                                </asp:DropDownList>
                            </div>
                            <div class="row-1">
                                <h10>Elevador: </h10>
                                <br />
                                <asp:DropDownList ID="ddlElevador" runat="server" Style="width: 70px" AutoPostBack="True" CausesValidation="True">
                                </asp:DropDownList>
                            </div>
                            <div class="row-1">
                                <h10>Vazio: </h10>
                                <br />
                                <asp:DropDownList ID="ddlVazio" runat="server" Style="width: 70px" AutoPostBack="True" CausesValidation="True">
                                </asp:DropDownList>                            
                            </div>                           
                        </div> 
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
