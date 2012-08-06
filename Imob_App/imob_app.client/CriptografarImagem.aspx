<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CriptografarImagem.aspx.cs" Inherits="imob_app.client.CriptografarImagem" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Names="Calibri" 
            Text="Descrição da imagem:"></asp:Label>
        &nbsp;<asp:TextBox ID="txtFoto" runat="server" MaxLength="150" Width="200px"></asp:TextBox>
        <asp:TextBox ID="txtFoto0" runat="server" MaxLength="150" Width="200px"></asp:TextBox>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
    
    </div>
    </form>
</body>
</html>
