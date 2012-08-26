using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using imob_app.entidades;

namespace imob_app.client
{
    public partial class MeusImoveis : BasePage
    {
        private int idUsuario;        

        protected void Page_Load(object sender, EventArgs e)
        {
            List<entidades.ImovelResultado> dataSource = (List<entidades.ImovelResultado>)Session["dataSource"];

            idUsuario = ((business.Sessao)Session["user"]).usuarioDb.id_usuario;
            //idUsuario = 123456;

            business.Imovel imov = new business.Imovel();

            if (!IsPostBack)
            {
                Session["dataSource"] = imov.SelecionarPorUsuario(idUsuario);
                dataSource = (List<entidades.ImovelResultado>)Session["dataSource"];                
                imoveis.DataSource = dataSource;
                imoveis.Admin = true;
            }
            else
                imoveis.DataSource = dataSource;
        }
    }
}