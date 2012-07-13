<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Imoveis.ascx.cs" Inherits="imob_app.client.controls.Imoveis" %>
<link href="css/dataList.css" rel="stylesheet" type="text/css" />
<link href="css/imoveis_rpt.css" rel="stylesheet" type="text/css" />
<link href="../css/style.css" rel="stylesheet" type="text/css" />
<div class="resultset">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <article class="grid_5 vr-separator-1">
            	<div class="top-box">
                <asp:Image ID="Image1" runat="server" Width="100" Height="100"></asp:Image>
                    <h5 class="head-1"><strong>Tudo</strong><b>Online</b></h5>
                    <ul class="list-1 pad-left">
                    	<li><a href="more.html">Texto 1</a></li>
                        <li><a href="more.html">Texto 2</a></li>
                        <li><a href="more.html">Texto 3</a></li>
                    </ul>
                    <a href="more.html" class="button">Ver mais ></a>
                </div>
            </article>
        </ItemTemplate>
    </asp:DataList>
</div>
