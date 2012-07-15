using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace imob_app.business
{
    public class Combo
    {
        public void CarregarCombo(ref DropDownList ddl, IEntidade entidade, string textField, string valueField, string primeiroItem)
        {
            business.IEntidade _entidade = entidade;
            ddl.Items.Clear();
            ddl.Items.Add(new ListItem(primeiroItem, ""));
            ddl.AppendDataBoundItems = true;
            ddl.DataSource = _entidade.SelecionarTodos();
            ddl.DataTextField = textField;
            ddl.DataValueField = valueField;
            ddl.DataBind();
        }

        public void CarregarCombo(ref DropDownList ddl, IEntidadeLocalizacao entidade, string textField, string valueField, string primeiroItem, int idEntidadeReferencia)
        {
            business.IEntidadeLocalizacao _entidade = entidade;
            ddl.Items.Clear();
            ddl.Items.Add(new ListItem(primeiroItem, ""));
            ddl.AppendDataBoundItems = true;
            ddl.DataSource = _entidade.SelecionarPorReferencia((short)idEntidadeReferencia);
            ddl.DataTextField = textField;
            ddl.DataValueField = valueField;
            ddl.DataBind();
        }
    }
}
