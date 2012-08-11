<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="galeria.ascx.cs" Inherits="imob_app.client.controls.galeria" %>
<table class="thumbs" border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <asp:DataList ID="dtlMini" runat="server" RepeatColumns="3" Height="146px" Width="252px">
                <ItemTemplate>
                    <td>
                        <a class="imovel-galeria" href="../Imagem.ashx?idFoto=<%# Eval("id_imagem") %>" rel="player=img">
                            <img Height="63px" Width="74px" src='<%# Eval("id_imagem", "../Imagem.ashx?idFoto={0}") %>' alt="<%# Eval("ds_imagem") %>"
                                class="border_gal"></a>                        
                    </td>
                </ItemTemplate>
            </asp:DataList>
        </tr>
    </tbody>
</table>
