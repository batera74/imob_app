using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imob_app.client
{
    public partial class Pesquisa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            business.Imovel imovel = new business.Imovel();
            imoveis.DataSource = imovel.SelecionarTodos().OfType<dao.ImovelResultado>().ToList(); ;        
        }
    }
}