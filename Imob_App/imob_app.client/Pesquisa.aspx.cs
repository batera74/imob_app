using System;
using System.Globalization;
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
            int result;

            int estado = (Int32.TryParse(Request.QueryString["estado"], out result)?result:0);
            int municipio = (Int32.TryParse(Request.QueryString["municipio"], out result) ? result : 0);
            int bairro = (Int32.TryParse(Request.QueryString["bairro"], out result) ? result : 0);
            int dormitorio = (Int32.TryParse(Request.QueryString["dormitorios"], out result) ? result : 0);
            int categoria = (Int32.TryParse(Request.QueryString["categoria"], out result) ? result : 0); 
            
            decimal valorDe, valorAte;
            NumberStyles style = NumberStyles.AllowDecimalPoint;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");
            
            Decimal.TryParse(Request.QueryString["valorDe"].ToString(), style, culture, out valorDe);
            Decimal.TryParse(Request.QueryString["valorAte"].ToString(), style, culture, out valorAte);

            business.Imovel imov = new business.Imovel();
            imoveis.DataSource = Carregar(estado, municipio, bairro, dormitorio, categoria, valorDe, valorAte);
        }

        public List<entidades.ImovelResultado> Carregar(int estado, int municipio, int bairro, int dormitorio, int categoria,
                                                        decimal valorDe, decimal valorAte)
        {

            //if (estado > 0 && municipio > 0 && bairro > 0)
            //{                
            //    dao.bairro novoBairro = new dao.bairro() { id_bairro = (short)bairro };
            //}

            //return null;

            business.Imovel imov = new business.Imovel();            
            return imov.SelecionarTodos();

        }
    }
}