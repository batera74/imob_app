﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="CadastroImovel.aspx.cs" Inherits="imob_app.client.CadastroImovel" %>

<%@ Register TagPrefix="galeria" TagName="Galeria" Src="~/controls/galeria.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/jquery-1.7.1.min.js" type="text/javascript"></script>
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
                        <h8 class="head-1"><strong>Características do Imóvel</strong></h8>     
                         <div id="conteudoDetalhes">                        
                             <div class="row-1">                                
                                 <span class="text-form fleft">Referência: <asp:Label ID="lblId" runat="server"></asp:Label></span>                                
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Categoria:</span>
                                 <asp:DropDownList ID="ddlCategoria" runat="server" Style="width: 195px" AutoPostBack="True">
                                 </asp:DropDownList>                    
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Dormitórios:</span>
                                 <asp:DropDownList ID="ddlDormitorios" runat="server" Style="width: 195px" AutoPostBack="True">
                                 </asp:DropDownList>                    
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Valor do Imóvel:</span>
                                 <asp:TextBox ID="txtValor" runat="server" Width="110"></asp:TextBox>                            
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Logradouro:</span>
                                 <asp:DropDownList ID="ddlTipoLogradouro" runat="server" Style="width: 95px" AutoPostBack="True" CausesValidation="True">
                                 </asp:DropDownList>
                                 <asp:TextBox ID="txtEndereco" runat="server" Width="190"></asp:TextBox>
                             </div>
                             <div class="row-1">                                
                                 <span class="text-form fleft">Número:</span>
                                 <asp:TextBox ID="txtNumero" runat="server" Width="40"></asp:TextBox>
                             </div>
                             <div class="row-1">                                
                                 <span class="text-form fleft">Complemento:</span>
                                 <asp:TextBox ID="txtComplemento" runat="server" Width="40"></asp:TextBox>
                             </div>
                             <div class="row-1">                                
                                 <span class="text-form fleft">CEP:</span>
                                 <asp:TextBox ID="txtCep" runat="server" Width="80"></asp:TextBox>
                             </div>
                             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                             <ContentTemplate>
                                 <div class="row-1">   
                                     <span class="text-form fleft">UF:</span>
                                     <asp:DropDownList ID="ddlUF" runat="server" Style="width: 45px;" AutoPostBack="True"
                                         CausesValidation="True">
                                     </asp:DropDownList>                                    
                                 </div>
                                 <div class="row-1"> 
                                     <span class="text-form fleft">Município:</span>
                                     <asp:DropDownList ID="ddlMunicipio" runat="server" Style="width: 195px" AutoPostBack="True">                                        
                                     </asp:DropDownList>
                                 </div>
                                 <div class="row-1"> 
                                     <span class="text-form fleft">Bairro:</span>
                                     <asp:DropDownList ID="ddlBairro" runat="server" Style="width: 195px" AutoPostBack="True">
                                     </asp:DropDownList>
                                 </div>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                             <div class="row-1">
                                 <span class="text-form fleft">Área Total:</span>
                                 <asp:TextBox ID="txtAreaTotal" runat="server" Width="70"></asp:TextBox>                            
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Área Útil:</span>
                                 <asp:TextBox ID="txtAreaUtil" runat="server" Width="70"></asp:TextBox>                            
                             </div>                
                             <div class="row-1">                                
                                 <span class="text-form fleft">Valor Condomínio:</span>
                                 <asp:TextBox ID="txtValorCondominio" runat="server" Width="70"></asp:TextBox>                            
                             </div>
                             <div class="row-1">                                
                                 <span class="text-form fleft">Valor IPTU:</span>
                                 <asp:TextBox ID="txtValorIptu" runat="server" Width="70"></asp:TextBox>
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Banheiros:</span>
                                 <asp:TextBox ID="txtBanheiros" runat="server" Width="50"></asp:TextBox>
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Suítes:</span>
                                 <asp:TextBox ID="txtSuites" runat="server" Width="50"></asp:TextBox>
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Padrão:</span>
                                 <asp:DropDownList ID="ddlPadrao" runat="server" Style="width: 70px" AutoPostBack="True" CausesValidation="True">
                                 </asp:DropDownList>
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Estado do Imóvel:</span>
                                 <asp:DropDownList ID="ddlEstadoImovel" runat="server" Style="width: 130px" AutoPostBack="True" CausesValidation="True">
                                 </asp:DropDownList>
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Posição do Imóvel:</span>
                                 <asp:DropDownList ID="ddlPosicaoImovel" runat="server" Style="width: 130px" AutoPostBack="True" CausesValidation="True">
                                 </asp:DropDownList>
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Garagem:</span>
                                 <asp:DropDownList ID="ddlGaragem" runat="server" Style="width: 90px" AutoPostBack="True" CausesValidation="True">
                                 </asp:DropDownList>
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Portaria:</span>
                                 <asp:CheckBox ID="chkPortaria" runat="server"></asp:CheckBox>
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Elevador:</span>
                                 <asp:CheckBox ID="chkElevador" runat="server"></asp:CheckBox>
                             </div>
                             <div class="row-1">
                                 <span class="text-form fleft">Vazio:</span>
                                 <asp:CheckBox ID="chkVazio" runat="server"></asp:CheckBox>                           
                             </div>                           
                             <div class="row-1">
                                 <span class="text-form fleft">Financiamento:</span>
                                 <asp:CheckBox ID="chkFinanciamento" runat="server"></asp:CheckBox>                           
                             </div>                           
                             <div class="row-1">
                                 <span class="text-form fleft">Ativo:</span>
                                 <asp:CheckBox ID="chkAtivo" runat="server"></asp:CheckBox>                           
                             </div>                           
                             <div class="row-1">
                                 <span class="text-form fleft">Destaque:</span>
                                 <asp:CheckBox ID="chkDestaque" runat="server"></asp:CheckBox>                           
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
