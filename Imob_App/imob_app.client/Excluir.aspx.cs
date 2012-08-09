using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using imob_app.business;

namespace imob_app.client
{
    public partial class Excluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idImovel = (int)Session["Imovel"];
            bool excluido;

            business.Imovel imov = new business.Imovel();
            excluido = imov.Excluir(idImovel);

            if (excluido)
                Response.Write(business.Funcoes.Alerta("Imóvel excluído com sucesso!"));
            else
                Response.Write(business.Funcoes.Alerta("Não foi possível excluir o imóvel!"));
        }
    }
}