using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using imob_app.dao;

namespace imob_app.client
{
    public partial class CadastroImovel : System.Web.UI.Page
    {
        private int idImovel;
        private dao.imobappEntities _ctx;

        protected void Page_Load(object sender, EventArgs e)
        {
            //idImovel = Convert.ToInt32(Request.QueryString["Imovel"]);
            idImovel = 1;
            business.Imovel imov = new business.Imovel();            
            dao.imovel imovel = imov.SelecionarImovel(Convert.ToInt32(1));
            CarregarCombos();
            CarregarImagens(imovel);
            CarregarDetalhes(imovel);
            CarregarCaracteristicas(imovel);
        }

        private void CarregarCombos()
        {
            business.Combo<dao.estado>.CarregarCombo(ref ddlUF, new business.Estado(), "cd_estado", "id_estado", "UF *", true);
            business.Combo<dao.municipio>.CarregarCombo(ref ddlMunicipio, new business.Municipio(), "nm_municipio", "id_municipio", "Município *", true);
            business.Combo<dao.bairro>.CarregarCombo(ref ddlBairro, new business.Bairro(), "nm_bairro", "id_bairro", "Bairro *", true);
            business.Combo<dao.dormitorio>.CarregarCombo(ref ddlDormitorios, new business.Dormitorio(), "ds_item", "id", "Dormitorios *", true);
            business.Combo<dao.categoria>.CarregarCombo(ref ddlCategoria, new business.Categoria(), "ds_item", "id", "Tipo *", true);
            business.Combo<dao.logradouro>.CarregarCombo(ref ddlTipoLogradouro, new business.Logradouro(), "ds_logradouro", "id_logradouro", "Logradouro *", true);
            business.Combo<dao.padrao>.CarregarCombo(ref ddlPadrao, new business.Padrao(), "ds_item", "id", "Padrão *", true);
            business.Combo<dao.estadoimovel>.CarregarCombo(ref ddlEstadoImovel, new business.EstadoImovel(), "ds_item", "id", "Estado do Imóvel *", true);
            business.Combo<dao.garagem>.CarregarCombo(ref ddlGaragem, new business.Garagem(), "ds_item", "id", "Garagem *", true);
            business.Combo<dao.posicaoimovel>.CarregarCombo(ref ddlPosicaoImovel, new business.PosicaoImovel(), "ds_item", "id", "Posição do Imóvel *", true);
        }

        private void CarregarImagens(dao.imovel imovel)
        {
            _ctx = new imobappEntities();

            if (imovel.imagem != null || imovel.imagem.Count > 0)
                galeria.DataSource = imovel.imagem;
            else
            {
                var query = from i in _ctx.imagem where i.id_imagem == 1 select i;
                galeria.DataSource = query;
            }
        }

        private void CarregarDetalhes(dao.imovel imovel)
        {
            if (idImovel > 0)
            {
                ddlCategoria.SelectedValue = imovel.categoria.id.ToString();
                ddlUF.SelectedValue = imovel.bairro.municipio.estado.id_estado.ToString();
                ddlMunicipio.SelectedValue = imovel.bairro.municipio.id_municipio.ToString();
                ddlBairro.SelectedValue = imovel.bairro.id_bairro.ToString();
                ddlDormitorios.SelectedValue = imovel.dormitorio.id.ToString();
                ddlTipoLogradouro.SelectedValue = imovel.logradouro.id_logradouro.ToString();
                ddlPadrao.SelectedValue = imovel.padrao.id.ToString();
                ddlEstadoImovel.SelectedValue = imovel.padrao.id.ToString();
                ddlPosicaoImovel.SelectedValue = imovel.posicaoimovel.id.ToString();
                ddlGaragem.SelectedValue = imovel.garagem.id.ToString();
                txtValor.Text = imovel.vl_imovel.ToString();
                txtValorCondominio.Text = imovel.vl_condominio.ToString();
                txtValorIptu.Text = imovel.vl_iptu.ToString();
                lblId.Text = imovel.id_imovel.ToString();
                txtBanheiros.Text = imovel.qt_banheiro.ToString();
                ddlMunicipio.SelectedValue = imovel.garagem.ds_item;
                chkPortaria.Checked = (bool)imovel.ic_portaria;
                chkElevador.Checked = (bool)imovel.ic_elevador;
                chkVazio.Checked = (bool)imovel.ic_vazio;
                chkAtivo.Checked = (bool)imovel.ic_ativo;
                chkDestaque.Checked = (bool)imovel.ic_destaque;
                chkFinanciamento.Checked = (bool)imovel.ic_financiamento;
                txtEndereco.Text = imovel.ds_endereco;
                txtNumero.Text = imovel.ds_numero_endereco;
                txtComplemento.Text = imovel.ds_complemento;
                txtCep.Text = imovel.ds_cep;
                txtAreaTotal.Text = imovel.vl_area_total.ToString();
                txtAreaUtil.Text = imovel.vl_area_util.ToString();
                txtSuites.Text = imovel.qt_suite.ToString();
            }
                
        }

        private void CarregarCaracteristicas(dao.imovel imovel)
        {
            _ctx = new imobappEntities();
            var acabamento = from a in _ctx.acabamento select a;
            CarregarTodasCaracteristicas(dtAcabamento, acabamento);

            var armario = from a in _ctx.armario select a;
            CarregarTodasCaracteristicas(dtArmarios, armario);

            var intima = from a in _ctx.intima select a;
            CarregarTodasCaracteristicas(dtIntima, intima);

            var lazer = from a in _ctx.lazer select a;
            CarregarTodasCaracteristicas(dtLazer, lazer);

            var servico = from a in _ctx.servico select a;
            CarregarTodasCaracteristicas(dtServicos, servico);

            var social = from a in _ctx.social select a;
            CarregarTodasCaracteristicas(dtSocial, social);

            //CarregarDataListCaracteristicas(dtAcabamento, imovel.acabamento);
            //CarregarDataListCaracteristicas(dtArmarios, imovel.armario);
            //CarregarDataListCaracteristicas(dtIntima, imovel.intima);
            //CarregarDataListCaracteristicas(dtLazer, imovel.lazer);
            //CarregarDataListCaracteristicas(dtServicos, imovel.servico);
            //CarregarDataListCaracteristicas(dtSocial, imovel.social);
        }

        private void CarregarDataListCaracteristicas(DataList dataList, IEnumerable source)
        {
            List<string> nInformado = new List<string>() { "Não Informado" };

            if (source != null)
                dataList.DataSource = source;
            else
                dataList.DataSource = nInformado;

            dataList.DataBind();
        }

        private void CarregarTodasCaracteristicas(DataList dataList, IEnumerable source)
        {
            List<string> nInformado = new List<string>() { "Items não cadastrados" };

            if (source != null)
                dataList.DataSource = source;
            else
                dataList.DataSource = nInformado;

            dataList.DataBind();
        }

        protected void dtAcabamento_ItemDataBound(object sender, DataListItemEventArgs e)
        {            
            _ctx = new imobappEntities();
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");

            var query = from i in _ctx.imovel select i.acabamento;
            List<dao.acabamento> acabamentos = query.First().ToList();


            foreach (var item in acabamentos)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;                    
            }
        }

        protected void dtArmarios_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            _ctx = new imobappEntities();
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");

            var query = from i in _ctx.imovel select i.armario;
            List<dao.armario> armarios = query.First().ToList();


            foreach (var item in armarios)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }

        protected void dtIntima_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            _ctx = new imobappEntities();
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");

            var query = from i in _ctx.imovel select i.intima;
            List<dao.intima> intimas = query.First().ToList();


            foreach (var item in intimas)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }

        protected void dtLazer_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            _ctx = new imobappEntities();
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");

            var query = from i in _ctx.imovel select i.lazer;
            List<dao.lazer> lazeres = query.First().ToList();


            foreach (var item in lazeres)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }

        protected void dtServicos_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            _ctx = new imobappEntities();
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");

            var query = from i in _ctx.imovel select i.servico;
            List<dao.servico> servicos = query.First().ToList();


            foreach (var item in servicos)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }

        protected void dtSocial_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            _ctx = new imobappEntities();
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");

            var query = from i in _ctx.imovel select i.social;
            List<dao.social> sociais = query.First().ToList();


            foreach (var item in sociais)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }        
    }
}