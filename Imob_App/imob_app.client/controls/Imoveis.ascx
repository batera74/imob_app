<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Imoveis.ascx.cs" Inherits="imob_app.client.controls.Imoveis" %>
<link href="css/imoveis_rpt.css" rel="stylesheet" type="text/css" />
<div class="resultset">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="result">
                <asp:Image ID="Image1" runat="server" Width="150px" Height="150px"/>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
