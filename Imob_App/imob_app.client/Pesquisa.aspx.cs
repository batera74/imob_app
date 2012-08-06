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
        private List<ImovelResultado> dataSource;

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

            if (!IsPostBack)
            {
                dataSource = Carregar(estado, municipio, bairro, dormitorio, categoria, valorDe, valorAte);
                imoveis.DataSource = dataSource;
            }
            else
                imoveis.DataSource = dataSource;
        }

        public List<entidades.ImovelResultado> Carregar(int idEstado, int idMunicipio, int idBairro, int idDormitorio, int idCategoria,
                                                        decimal valorDe, decimal valorAte)
        {
            business.Imovel imov = new business.Imovel();
            return imov.Pesquisar(idEstado, idMunicipio, idBairro, idDormitorio, idCategoria, valorDe, valorAte);
        }
    }
}