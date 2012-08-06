using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imob_app.client
{
    public partial class Default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CarregarCombosPesquisa();

        }

        private void CarregarCombosPesquisa()
        {
            
            business.Combo<dao.estado>.CarregarCombo(ref ddlUF, new business.Estado(), "cd_estado", "id_estado", "UF *");
            business.Combo<dao.municipio>.CarregarCombo(ref ddlMunicipio, new business.Municipio(), "nm_municipio", "id_municipio", "Município *");
            business.Combo<dao.bairro>.CarregarCombo(ref ddlBairro, new business.Bairro(), "nm_bairro", "id_bairro", "Bairro *");
            business.Combo<dao.dormitorio>.CarregarCombo(ref ddlDormitorios, new business.Dormitorio(), "ds_item", "id", "Dormitorios *");
            business.Combo<dao.categoria>.CarregarCombo(ref ddlCategoria, new business.Categoria(), "ds_item", "id", "Tipo *");
        }

        protected void ddlUF_SelectedIndexChanged(object sender, EventArgs e)
        {            
            business.Combo<dao.municipio>.CarregarCombo(ref ddlMunicipio, new business.Municipio(),
                "nm_municipio", "id_municipio", "Município *", Convert.ToInt16(ddlUF.SelectedValue));
        }

        protected void ddlMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {            
            business.Combo<dao.bairro>.CarregarCombo(ref ddlBairro, new business.Bairro(),
                "nm_bairro", "id_bairro", "Bairro *", Convert.ToInt16(ddlMunicipio.SelectedValue));
        }

        protected void lnkPesquisarAvancado_Click(object sender, EventArgs e)
        {
            if (ValoresValidos())
            {
            Response.Redirect("Pesquisa.aspx?estado=" + ddlUF.SelectedValue
                + "&municipio=" + ddlMunicipio.SelectedValue
                + "&bairro=" + ddlBairro.SelectedValue
                + "&dormitorios=" + ddlDormitorios.SelectedValue
                + "&categoria=" + ddlCategoria.SelectedValue
                + "&valorDe=" + txtValorDe.Text
                + "&valorAte=" + txtValorAte.Text);
            }
        }

        protected bool ValoresValidos()
        {
            NumberStyles style = NumberStyles.AllowDecimalPoint;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");
            decimal number;

            if (!Decimal.TryParse(txtValorDe.Text, style, culture, out number))
            {
                if (txtValorDe.Text.IndexOf("DE") > -1)
                {
                    txtValorDe.Text = "0";
                }
                else
                {
                    Alert("O valor mínimo está preenchido incorretamente. Favor verificar.");
                    return false;
                }
            }
            if (!Decimal.TryParse(txtValorAte.Text, style, culture, out number))
            {
                if (txtValorAte.Text.IndexOf("ATÉ") > -1)
                {
                    txtValorAte.Text = "0";
                }
                else
                {
                    Alert("O valor máximo está preenchido incorretamente. Favor verificar.");
                    return false;
                }
            }
            return true;
        }

        protected void Alert(string mensagem)
        {
            Response.Write("<script>alert('" + mensagem + "')</script>");
        }
    }
}