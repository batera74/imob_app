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
            business.Combo<dao.estado>.CarregarCombo(ref ddlUF, new business.Estado(), "cd_estado", "id_estado", "UF *");
            business.Combo<dao.municipio>.CarregarCombo(ref ddlMunicipio, new business.Municipio(), "nm_municipio", "id_municipio", "Município *");
            business.Combo<dao.bairro>.CarregarCombo(ref ddlBairro, new business.Bairro(), "nm_bairro", "id_bairro", "Bairro *");
            business.Combo<dao.dormitorio>.CarregarCombo(ref ddlDormitorios, new business.Dormitorio(), "ds_item", "id", "Dormitorios *");
            business.Combo<dao.categoria>.CarregarCombo(ref ddlCategoria, new business.Categoria(), "ds_item", "id", "Tipo *");
            business.Combo<dao.logradouro>.CarregarCombo(ref ddlTipoLogradouro, new business.Logradouro(), "ds_logradouro", "id_logradouro", "Logradouro *");
            business.Combo<dao.padrao>.CarregarCombo(ref ddlPadrao, new business.Padrao(), "ds_item", "id", "Padrão *");
            business.Combo<dao.estadoimovel>.CarregarCombo(ref ddlEstadoImovel, new business.EstadoImovel(), "ds_item", "id", "Estado do Imóvel *");
            business.Combo<dao.garagem>.CarregarCombo(ref ddlGaragem, new business.Garagem(), "ds_item", "id", "Garagem *");
            business.Combo<dao.posicaoimovel>.CarregarCombo(ref ddlPosicaoImovel, new business.PosicaoImovel(), "ds_item", "id", "Posição do Imóvel *");
        }

        private void CarregarImagens(dao.imovel imovel)
        {
            dao.imobappEntities _ctx = new imobappEntities();

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
            CarregarDataListCaracteristicas(dtAcabamento, imovel.acabamento);
            CarregarDataListCaracteristicas(dtArmarios, imovel.armario);
            CarregarDataListCaracteristicas(dtIntima, imovel.intima);
            CarregarDataListCaracteristicas(dtLazer, imovel.lazer);
            CarregarDataListCaracteristicas(dtServicos, imovel.servico);
            CarregarDataListCaracteristicas(dtSocial, imovel.social);
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
    }
}