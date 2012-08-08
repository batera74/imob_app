<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="galeria.ascx.cs" Inherits="imob_app.client.controls.galeria" %>
<link rel="stylesheet" href="controls/css/galeria/shadowbox.css" media="screen" />
<script src="controls/js/galeria/shadowbox.js"></script>
<script src="controls/js/galeria/demo.js"></script>
<script type="text/javascript">
    Shadowbox.init({        
        overlayOpacity: 0.8
    }, setupDemos);

</script>
<table class="thumbs" border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <asp:DataList ID="dtlMini" runat="server" RepeatColumns="3" Height="146px" Width="252px">
                <ItemTemplate>
                    <td>
                        <a class="imovel-galeria" href="../Imagem.ashx?idFoto=<%# Eval("id_imagem") %>" rel="player=img">
                            <img Height="63px" Width="74px" src='<%# Eval("id_imagem", "../Imagem.ashx?idFoto={0}") %>' alt="<%# Eval("ds_imagem") %>"
                                class="border"></a>
                    </td>
                </ItemTemplate>
            </asp:DataList>
        </tr>
    </tbody>
</table>
