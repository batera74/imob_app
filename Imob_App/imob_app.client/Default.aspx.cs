using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facebook;

namespace imob_app.client
{
    public partial class _Default : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var client = new FacebookClient();
                var me = client.Get("lrombesso") as IDictionary<string, object>;
                string firstName = (string)me["first_name"];
                string lastName = me["last_name"].ToString();
                Alert("Teste de conexão com o Facebook: Obtendo informações públicas do Leo: " + me.ToString());
            }
            catch(Exception ex)
            {
                Alert("Erro ao tentar conectar ao Facebook: " + ex.Message);
                Alert("Mais detalhes: " + ex.StackTrace);
            }
        }
    }
}