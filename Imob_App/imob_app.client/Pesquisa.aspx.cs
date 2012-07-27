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
            int estado = Convert.ToInt32(Request.QueryString["estado"]);
            int municipio = Convert.ToInt32(Request.QueryString["municipio"]);
            int bairro = Convert.ToInt32(Request.QueryString["bairro"]);
            int dormitorio = Convert.ToInt32(Request.QueryString["dormitorios"]);
            int categoria = Convert.ToInt32(Request.QueryString["categoria"]);
            decimal valorDe, valorAte;
            bool result = Decimal.TryParse(Request.QueryString["valorDe"].ToString(), out valorDe);
            bool result2 = Decimal.TryParse(Request.QueryString["valorDe"].ToString(), out valorAte);

            business.Imovel imov = new business.Imovel();
            imoveis.DataSource = Carregar(estado, municipio, bairro, dormitorio, categoria, valorDe, valorAte);
        }

        public List<entidades.ImovelResultado> Carregar(int estado, int municipio, int bairro, int dormitorio, int categoria,
                                                        decimal valorDe, decimal valorAte)
        {

            if (estado > 0 && municipio > 0 && bairro > 0)
            {                
                dao.bairro novoBairro = new dao.bairro() { id_bairro = (short)bairro };
            }

            return null;
        }
    }
}