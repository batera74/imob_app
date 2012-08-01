<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImovelRepeater.ascx.cs"
    Inherits="imob_app.client.controls.ImovelRepeater" %>
<table class="principal">
    <tr>
        <td>
            <table cellpadding="0" border="0" width="100%">
                <tr>
                    <td align="center">
                        <table>
                            <tr align="center">
                                <td colspan="5" align="center" style="height: 30px" valign="top">
                                    <asp:Label ID="lblEncontrados1" runat="server" Font-Names="Calibri" Font-Size="Small"></asp:Label>
                                    <br />
                                    <asp:Label ID="lblPaginas1" runat="server" Font-Names="Calibri" Font-Size="X-Small"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:ImageButton ID="lbtnFirst1" runat="server" ImageUrl="images/repeater/prev.png"
                                        OnClick="lbtnFirst_Click" />
                                    <asp:ImageButton ID="lbtnPrevious1" runat="server" ImageUrl="images/repeater/prev1.png"
                                        OnClick="lbtnPrevious_Click" />
                                </td>
                                <td style="padding: 7px 5px 0 5px;">
                                    <asp:DataList ID="dlPaging1" runat="server" RepeatDirection="Horizontal" OnItemCommand="dlPaging_ItemCommand"
                                        OnItemDataBound="dlPaging_ItemDataBound" Font-Names="Calibri" Font-Size="Medium"
                                        ForeColor="#333333">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkbtnPaging" runat="server" CommandArgument='<%# Eval("PageIndex") %>'
                                                CommandName="Paging" Text='<%# Eval("PageText") %>' ForeColor="#333333" Font-Size="Small"></asp:LinkButton>&nbsp;
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td>
                                    <asp:ImageButton ID="lbtnNext1" runat="server" ImageUrl="images/repeater/next1.png"
                                        OnClick="lbtnNext_Click" />
                                    <asp:ImageButton ID="lbtnLast1" runat="server" ImageUrl="images/repeater/next.png"
                                        OnClick="lbtnLast_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="center">
            <asp:DataList runat="server" ID="dListItems" CellPadding="2" RepeatColumns="3" OnItemDataBound="dListItems_ItemDataBound">
                <ItemTemplate>
                    <table class="item">
                        <tr>
                            <td>
                                <table class="sample">
                                    <tr>
                                        <td>
                                            <a href="../DetalheImovel.aspx?Imovel=<%# Eval("Referencia") %>">
                                                <asp:Image Style="border: 0px;" ID="Image2" runat="server" Height="131px" Width="200px" /></a>
                                        </td>
                                    </tr>
                                </table>
                                <div class="texto">
                                    <asp:Label ID="lblCategoria" runat="server" CssClass="categoria" Text='<%# Eval("Categoria") %>'></asp:Label>
                                    <br />
                                    <asp:Label ID="lblDormitorios" runat="server" Font-Size="Small" Text='<%# Eval("Dormitorio", "{0} dorm(s)")+" - "+Eval("Suite", "{0} suíte(s)") %>'></asp:Label>
                                    <br />
                                    <asp:Label ID="lblReferencia" runat="server" Font-Size="Small" Text='<%# Eval("Referencia", "Referencia: {0}") %>'></asp:Label>
                                    <br />
                                    <asp:Label ID="lblBairroCidadeEstado" runat="server" Font-Size="Small" Text='<%# Eval("Bairro")+" - "+Eval("Municipio")+" - "+Eval("Estado") %>'></asp:Label>
                                    <br />
                                    <asp:Label ID="lblAreas" runat="server" Font-Size="Small" Text='<%# Eval("AreaUtil", "Total: {0} m²") + " - " + Eval("AreaTotal", "Útil: {0} m²") %>'></asp:Label>
                                    <br />
                                    <asp:Label ID="lblEstadoImovel" runat="server" Font-Size="Small" Text='<%# Eval("EstadoImovel", "Estado do Imóvel: {0}") %>'></asp:Label>
                                    <br />
                                    <div class="line">
                                    </div>
                                    <div class="valor">
                                        <asp:Label ID="lblValor" runat="server" Text='<%# Eval("Valor", "{0:c}") %>'></asp:Label>
                                    </div>
                                    <div class="line">
                                    </div>
                                    <div class="ha_centro">
                                        <a href="../DetalheImovel.aspx?Imovel=<%# Eval("Referencia") %>">
                                            <asp:Label ID="lblDetalhes" runat="server" CssClass="button" Text='Detalhes >'></asp:Label></a>
                                    </div>
                                    <br />
                                </div>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <ItemStyle BackColor="White" />
            </asp:DataList>
        </td>
    </tr>
    <tr>
        <td colspan="5" align="center" style="height: 8px" valign="top">
            <asp:Label ID="lblInfo" runat="server" Font-Names="Calibri" Font-Size="Small" Visible="False">Não foram encontrados imóveis com as características desejadas.</asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <table cellpadding="0" border="0" width="100%">
                <tr>
                    <td align="center">
                        <table>
                            <tr>
                                <td>
                                    <asp:ImageButton ID="lbtnFirst" runat="server" ImageUrl="images/repeater/prev.png"
                                        OnClick="lbtnFirst_Click" />
                                    <asp:ImageButton ID="lbtnPrevious" runat="server" ImageUrl="images/repeater/prev1.png"
                                        OnClick="lbtnPrevious_Click" />
                                </td>
                                <td style="padding: 7px 5px 0 5px;">
                                    <asp:DataList ID="dlPaging" runat="server" RepeatDirection="Horizontal" OnItemCommand="dlPaging_ItemCommand"
                                        OnItemDataBound="dlPaging_ItemDataBound" Font-Names="Calibri" Font-Size="Medium"
                                        ForeColor="#333333">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkbtnPaging" runat="server" CommandArgument='<%# Eval("PageIndex") %>'
                                                CommandName="Paging" Text='<%# Eval("PageText") %>' ForeColor="#333333"></asp:LinkButton>&nbsp;
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td>
                                    <asp:ImageButton ID="lbtnNext" runat="server" ImageUrl="images/repeater/next1.png"
                                        OnClick="lbtnNext_Click" />
                                    <asp:ImageButton ID="lbtnLast" runat="server" ImageUrl="images/repeater/next.png"
                                        OnClick="lbtnLast_Click" />
                                </td>
                            </tr>
                            <tr align="center">
                                <td colspan="5" align="center" style="height: 30px" valign="top">
                                    <asp:Label ID="lblEncontrados2" runat="server" Font-Names="Calibri" Font-Size="Small"></asp:Label>
                                    <br />
                                    <asp:Label ID="lblPaginas2" runat="server" Font-Names="Calibri" Font-Size="X-Small"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
