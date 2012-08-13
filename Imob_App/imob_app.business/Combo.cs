using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using imob_app.business.Contratos;

namespace imob_app.business
{
    public static class Combo<T>
    {
        public static void CarregarCombo(ref DropDownList ddl, IEntidade<T> entidade, string textField, string valueField, string primeiroItem, bool todos)
        {
            IEntidade<T> _entidade = entidade;
            ddl.Items.Clear();
            ddl.Items.Add(new ListItem(primeiroItem, ""));
            ddl.AppendDataBoundItems = true;
            ddl.DataSource = (todos ? _entidade.SelecionarTodos() : _entidade.SelecionarExistentes());
            ddl.DataTextField = textField;
            ddl.DataValueField = valueField;
            ddl.DataBind();
        }

        public static void CarregarCombo(ref DropDownList ddl, IEntidadeLocalizacao<T> entidade, string textField, string valueField, string primeiroItem, int idEntidadeReferencia, bool todos)
        {
            IEntidadeLocalizacao<T> _entidade = entidade;
            ddl.Items.Clear();
            ddl.Items.Add(new ListItem(primeiroItem, ""));
            ddl.AppendDataBoundItems = true;
            ddl.DataSource = (todos ? _entidade.SelecionarPorReferencia((short)idEntidadeReferencia) : _entidade.SelecionarExistentesPorReferencia((short)idEntidadeReferencia));
            ddl.DataTextField = textField;
            ddl.DataValueField = valueField;
            ddl.DataBind();
        }
    }
}
