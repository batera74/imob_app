<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="galeria.ascx.cs" Inherits="imob_app.client.controls.galeria" %>
<script type="text/javascript">
    // Get the instance of PageRequestManager.
    var prm = Sys.WebForms.PageRequestManager.getInstance();
    // Add initializeRequest and endRequest
    prm.add_initializeRequest(prm_InitializeRequest);
    prm.add_endRequest(prm_EndRequest);

    // Called when async postback begins
    function prm_InitializeRequest(sender, args) {
        // get the divImage and set it to visible
        var panelProg = $get('divImage');
        panelProg.style.display = '';
    }

    // Called when async postback ends
    function prm_EndRequest(sender, args) {
        // get the divImage and hide it again
        var panelProg = $get('divImage');
        panelProg.style.display = 'none';
    }
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
