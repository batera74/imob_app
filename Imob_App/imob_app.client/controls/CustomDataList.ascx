<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomDataList.ascx.cs"
    Inherits="Layout.controls.CustomDataList" %>
<link href="css/dataList.css" rel="stylesheet" type="text/css" />
<table width="100%">
    <tr>
        <td>
            <table cellpadding="0" border="0" width="100%">
                <tr>
                    <td align="center">
                        <table>
                            <tr>
                                <td>
                                    <asp:ImageButton ID="lbtnFirst1" runat="server" ImageUrl="~/Images/prev.png" OnClick="lbtnFirst_Click" />
                                    <asp:ImageButton ID="lbtnPrevious1" runat="server" ImageUrl="~/Images/prev1.png"
                                        OnClick="lbtnPrevious_Click" />
                                </td>
                                <td>
                                    <asp:DataList ID="dlPaging1" runat="server" RepeatDirection="Horizontal" OnItemCommand="dlPaging_ItemCommand"
                                        OnItemDataBound="dlPaging_ItemDataBound" Font-Names="Calibri" Font-Size="Medium"
                                        ForeColor="#333333">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkbtnPaging" runat="server" CommandArgument='<%# Eval("PageIndex") %>'
                                                CommandName="Paging" Text='<%# Eval("PageText") %>' ForeColor="#333333"></asp:LinkButton>&nbsp;
                                        </ItemTemplate>
                                    </asp:DataList>
                                </td>
                                <td>
                                    <asp:ImageButton ID="lbtnNext1" runat="server" ImageUrl="~/Images/next1.png" OnClick="lbtnNext_Click" />
                                    <asp:ImageButton ID="lbtnLast1" runat="server" ImageUrl="~/Images/next.png" OnClick="lbtnLast_Click" />
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
            <asp:DataList runat="server" ID="dListItems" CellPadding="2" RepeatColumns="3" 
                onitemdatabound="dListItems_ItemDataBound">
                <ItemTemplate>
                    <table width="220px" bgcolor="silver">
                        <tr>
                            <td align="center">
                                <br />
                                <table class="sample">
                                    <tr>
                                        <td>
                                            <a href="../DetalhesImovel.aspx?Imovel=<%# Eval("Id") %>"><asp:Image style="border: 0px;" ID="Image2" runat="server" Height="131px" Width="151px" ImageUrl='<%# Eval("Imagem", "~/Images/Imoveis/{0}") %>' /></a>
                                        </td>
                                    </tr>
                                </table>
                                <asp:Label ID="lblCategoria" runat="server" Font-Size="Small" Text='<%# Eval("Categoria") + " - " + Eval("Dormitorios") + " dorm" %>'></asp:Label>
                                <br />
                                <asp:Label ID="lblBairroCidadeEstado" runat="server" Font-Size="Small" Text='<%# Eval("Bairro")+" - "+Eval("Municipio")+"/"+Eval("Estado") %>'></asp:Label>
                                <br />
                                <asp:Label ID="lblValor" runat="server" Font-Size="Small" Text='<%# Eval("Valor", "{0:c}") %>'></asp:Label>
                                <br />
                                <a href="../DetalhesImovel.aspx?Imovel=<%# Eval("Id") %>"><asp:Label ID="lblDetalhes" runat="server" Font-Size="Small" 
                                    Text='Veja + Detalhes' Font-Bold="True" Font-Underline="False" 
                                    ForeColor="Black"></asp:Label></a>
                                <br />
                                <br />
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
                                    <asp:ImageButton ID="lbtnFirst" runat="server" ImageUrl="~/Images/prev.png" OnClick="lbtnFirst_Click" />
                                    <asp:ImageButton ID="lbtnPrevious" runat="server" ImageUrl="~/Images/prev1.png" OnClick="lbtnPrevious_Click" />
                                </td>
                                <td>
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
                                    <asp:ImageButton ID="lbtnNext" runat="server" ImageUrl="~/Images/next1.png" OnClick="lbtnNext_Click" />
                                    <asp:ImageButton ID="lbtnLast" runat="server" ImageUrl="~/Images/next.png" OnClick="lbtnLast_Click" />
                                </td>
                            </tr>
                            <tr align="center">
                                <td colspan="5" align="center" style="height: 30px" valign="top">
                                    <asp:Label ID="lblPageInfo" runat="server" Font-Names="Calibri" Font-Size="Small"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
