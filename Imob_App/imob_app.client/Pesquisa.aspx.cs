using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using imob_app.entidades;

namespace imob_app.client
{
    public partial class Pesquisa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            business.Imovel imovel = new business.Imovel();
            List<entidades.ImovelResultado> lista = imovel.SelecionarTodos().OfType<entidades.ImovelResultado>().ToList();
            imovel.PreencherIdFotoPrincipal(lista);
            imoveis.DataSource = lista;
        }
    }
}