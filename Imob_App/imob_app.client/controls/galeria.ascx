<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="galeria.ascx.cs" Inherits="imob_app.client.controls.galeria" %>
<script type="text/javascript">
    
</script>

<div id="divImage" style="display: none">
    <div style="float: left;">
        <img src="../images/lightbox-ico-loading.gif" height="20px" /> Aguarde...</div>
</div>
<table class="thumbs" border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <asp:DataList ID="dtlMini" runat="server" RepeatColumns="3" Height="146px" Width="252px"
                OnItemDataBound="dtlMini_ItemDataBound" 
                onitemcommand="dtlMini_ItemCommand">
                <ItemTemplate>
                    <td align="left">
                        <asp:HyperLink ID="hlkImagem" runat="server" CssClass="imovel-galeria" rel="player=img">
                            <div class="border_gal">
                                <asp:Image ID="imgImovel" runat="server" Width="74px" Height="63px" />
                            </div>
                        </asp:HyperLink>
                        <div style="text-align: center; width: 74px;">
                            <asp:CheckBox ID="chkPrincipal" runat="server" Text="Principal" AutoPostBack="true"
                                OnCheckedChanged="chkPrincipal_CheckedChanged" />
                            <br />
                            <asp:LinkButton ID="lnkExcluir" runat="server" CausesValidation="false" CommandName="Delete" OnClientClick="return confirm('Tem certeza que deseja excluir a imagem?');">Excluir</asp:LinkButton>
                        </div>
                    </td>
                </ItemTemplate>
            </asp:DataList>
        </tr>
    </tbody>
</table>
