<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstouInteressado.aspx.cs"
    Inherits="imob_app.client.EstouInteressado" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/style.css">
    <script src="js/jquery-1.7.1.min.js"></script>
    <script src="js/cufon-yui.js"></script>
    <script src="js/Kozuka_Gothic_Pro_OpenType_300.font.js"></script>
    <script src="js/Kozuka_Gothic_Pro_OpenType_400.font.js"></script>
    <script src="js/Kozuka_Gothic_Pro_OpenType_500.font.js"></script>
    <script src="js/Kozuka_Gothic_Pro_OpenType_700.font.js"></script>
    <script src="js/Kozuka_Gothic_Pro_OpenType_900.font.js"></script>
    <script src="js/cufon-replace.js"></script>
    <script src="js/script.js"></script>
    <script src="js/jquery.jqtransform.js"></script>

    <style>
        body
        {
            overflow: hidden;
        }
    </style>

</head>
<body>
    <form id="interessado" runat="server">
    <div class="estouInteressado">
        <h3 class="head-1">
            <em class="heading-row"><i>Estou interessado no seu imóvel.</i></em><em class="heading-row-2_">Quero
                saber mais sobre ele!</em></h3>
        <div id="formInteresse">
            <div class="row-1">
                <span class="text-form fleft">Assunto:&nbsp;&nbsp;&nbsp;&nbsp;</span>
                <input type="text" value="Estou interessado no seu imóvel!" name="Assunto">
            </div>
            <br />
            <div class="row-1">
                <span class="text-form fleft">Mensagem:</span>
                <textarea>Mensagem *</textarea>
            </div>
            <div class="fright" style="margin-top: 15px;">
                <asp:LinkButton CssClass="btn" ID="lnkPesquisarAvancado" runat="server">Enviar</asp:LinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
