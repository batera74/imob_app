using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using imob_app.entidades;

namespace imob_app.client
{
    public partial class MeusImoveis : System.Web.UI.Page
    {
        private int idUsuario;
        private List<ImovelResultado> dataSource;

        protected void Page_Load(object sender, EventArgs e)
        {
            business.Imovel imov = new business.Imovel();
            //idUsuario = (int)Session["user"];
            idUsuario = 1;

            if (!IsPostBack)
            {
                dataSource = imov.SelecionarPorUsuario(idUsuario);
                imoveis.DataSource = dataSource;
                imoveis.Admin = true;
            }
            else
                imoveis.DataSource = dataSource;
        }
    }
}