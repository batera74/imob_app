using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using imob_app.dao;
using System.Configuration;
using System.IO;

namespace imob_app.client
{
    public partial class CadastroImovel : BasePage
    {
        private int idImovel;

        private string Temp = ConfigurationManager.AppSettings["ImagesTempDir"];

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dao.imovel imov;
                business.Imovel imovBiz = new business.Imovel();
                business.Imagem imgBiz = new business.Imagem();
                idImovel = Convert.ToInt32(Request.QueryString["Imovel"]);

                imgBiz.DeletarImagensNaoAssociadas();
                CarregarCombos();
                CarregarCaracteristicas();

                if (idImovel > 0)
                {                                    
                    imov = imovBiz.SelecionarImovel(Convert.ToInt32(idImovel));
                    Session["idImovel"] = imov.id_imovel;                    
                    CarregarDetalhes(imov);                    
                }
                else
                {
                    Session["idImovel"] = 0;
                }
            }
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

        private void CarregarDetalhes(dao.imovel imovel)
        {
            if (idImovel > 0)
            {
                lblId.Text = imovel.id_imovel.ToString();
                ddlCategoria.SelectedValue = imovel.categoria.id.ToString();
                ddlDormitorios.SelectedValue = imovel.dormitorio.id.ToString();
                txtValor.Text = imovel.vl_imovel.ToString();
                ddlTipoLogradouro.SelectedValue = imovel.logradouro.id_logradouro.ToString();
                txtEndereco.Text = imovel.ds_endereco;
                txtNumero.Text = imovel.ds_numero_endereco;
                txtComplemento.Text = imovel.ds_complemento;
                txtCep.Text = imovel.ds_cep;
                ddlUF.SelectedValue = imovel.bairro.municipio.estado.id_estado.ToString();
                ddlMunicipio.SelectedValue = imovel.bairro.municipio.id_municipio.ToString();
                ddlBairro.SelectedValue = imovel.bairro.id_bairro.ToString();
                txtAreaTotal.Text = imovel.vl_area_total.ToString();
                txtAreaUtil.Text = imovel.vl_area_util.ToString();
                txtValorCondominio.Text = imovel.vl_condominio.ToString();
                txtValorIptu.Text = imovel.vl_iptu.ToString();
                txtBanheiros.Text = imovel.qt_banheiro.ToString();
                txtSuites.Text = imovel.qt_suite.ToString();
                ddlPadrao.SelectedValue = imovel.padrao.id.ToString();
                ddlEstadoImovel.SelectedValue = imovel.padrao.id.ToString();
                ddlPosicaoImovel.SelectedValue = imovel.posicaoimovel.id.ToString();
                ddlGaragem.SelectedValue = imovel.garagem.id.ToString();
                chkPortaria.Checked = (bool)imovel.ic_portaria;
                chkElevador.Checked = (bool)imovel.ic_elevador;
                chkVazio.Checked = (bool)imovel.ic_vazio;
                chkFinanciamento.Checked = (bool)imovel.ic_financiamento;
                chkAtivo.Checked = (bool)imovel.ic_ativo;
                chkDestaque.Checked = (bool)imovel.ic_destaque;
            }
        }

        private void CarregarCaracteristicas()
        {
            CarregarTodasCaracteristicas(dtAcabamento, new business.Acabamento().SelecionarTodos());
            CarregarTodasCaracteristicas(dtArmarios, new business.Armario().SelecionarTodos());
            CarregarTodasCaracteristicas(dtIntima, new business.Intima().SelecionarTodos());
            CarregarTodasCaracteristicas(dtLazer, new business.Lazer().SelecionarTodos());
            CarregarTodasCaracteristicas(dtServicos, new business.Servico().SelecionarTodos());
            CarregarTodasCaracteristicas(dtSocial, new business.Social().SelecionarTodos());
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
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");
            List<dao.acabamento> acabamentos = new business.Imovel().SelecionarAcabamento();

            foreach (var item in acabamentos)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }

        protected void dtArmarios_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");

            List<dao.armario> armarios = new business.Imovel().SelecionarArmario();

            foreach (var item in armarios)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }

        protected void dtIntima_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");
            List<dao.intima> intimas = new business.Imovel().SelecionarIntima();

            foreach (var item in intimas)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }

        protected void dtLazer_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");
            List<dao.lazer> lazeres = new business.Imovel().SelecionarLazer();

            foreach (var item in lazeres)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }

        protected void dtServicos_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");
            List<dao.servico> servicos = new business.Imovel().SelecionarServico();

            foreach (var item in servicos)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }

        protected void dtSocial_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            CheckBox chk = (CheckBox)e.Item.FindControl("chk");
            Label lbl = (Label)e.Item.FindControl("lbl");
            List<dao.social> sociais = new business.Imovel().SelecionarSocial();

            foreach (var item in sociais)
            {
                if (lbl.Text.Equals(item.ds_item))
                    chk.Checked = true;
            }
        }

        protected void FileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            Session["imgPersiste"] = FileUpload1;
        }

        protected void lnkSalvar_Click(object sender, EventArgs e)
        {
            SalvarImovel();
        }

        private void SalvarImovel()
        {
            business.Imovel imovBiz = new business.Imovel();
            imobappEntities _ctx = new imobappEntities();
            dao.imovel imov;

            if (Convert.ToInt32(Session["idImovel"]) > 0)
                imov = imovBiz.SelecionarImovel(Convert.ToInt32(Session["idImovel"]), _ctx);
            else
                imov = new imovel();

            imov.categoria = new business.Categoria().Selecionar(Convert.ToInt16(ddlCategoria.SelectedValue), _ctx);
            imov.dormitorio = new business.Dormitorio().Selecionar(Convert.ToInt16(ddlDormitorios.SelectedValue), _ctx);
            imov.vl_imovel = Convert.ToDecimal(txtValor.Text);
            imov.logradouro = new business.Logradouro().Selecionar(Convert.ToInt16(ddlTipoLogradouro.SelectedValue), _ctx);
            imov.ds_endereco = txtEndereco.Text;
            imov.ds_numero_endereco = txtNumero.Text;
            imov.ds_complemento = txtComplemento.Text;
            imov.ds_cep = txtCep.Text;
            imov.bairro = new business.Bairro().Selecionar(Convert.ToInt32(ddlBairro.SelectedValue), _ctx);
            imov.vl_area_total = Convert.ToDecimal(txtAreaTotal.Text);
            imov.vl_area_util = Convert.ToDecimal(txtAreaUtil.Text);
            imov.vl_condominio = Convert.ToDecimal(txtValorCondominio.Text);
            imov.vl_iptu = Convert.ToDecimal(txtValorIptu.Text);
            imov.qt_banheiro = Convert.ToInt16(txtBanheiros.Text);
            imov.qt_suite = Convert.ToInt16(txtSuites.Text);
            imov.padrao = new business.Padrao().Selecionar(Convert.ToInt16(ddlPadrao.SelectedValue), _ctx);
            imov.estadoimovel = new business.EstadoImovel().Selecionar(Convert.ToInt16(ddlEstadoImovel.SelectedValue), _ctx);
            imov.posicaoimovel = new business.PosicaoImovel().Selecionar(Convert.ToInt16(ddlPosicaoImovel.SelectedValue), _ctx);
            imov.garagem = new business.Garagem().Selecionar(Convert.ToInt16(ddlGaragem.SelectedValue), _ctx);
            imov.ic_portaria = chkPortaria.Checked;
            imov.ic_elevador = chkElevador.Checked;
            imov.ic_vazio = chkVazio.Checked;
            imov.ic_financiamento = chkFinanciamento.Checked;
            imov.ic_ativo = chkAtivo.Checked;
            imov.ic_destaque = chkDestaque.Checked;
            SalvarCaracteristicas(imov, _ctx);

            _ctx.SaveChanges();
        }        

        private void SalvarCaracteristicas(dao.imovel imov, imobappEntities _ctx)
        {
            SalvarAcabamento(imov, _ctx);
            SalvarArmario(imov, _ctx);
            SalvarSocial(imov, _ctx);
            SalvarServico(imov, _ctx);
            SalvarIntima(imov, _ctx);
            SalvarLazer(imov, _ctx);
        }

        private void SalvarAcabamento(dao.imovel imov, imobappEntities _ctx)
        {
            imov.acabamento.Clear();

            foreach (DataListItem item in dtAcabamento.Items)
            {
                CheckBox chk = (CheckBox)item.FindControl("chk");

                if (chk.Checked)
                {
                    Label lbl = (Label)item.FindControl("lbl");
                    imov.acabamento.Add(new business.Acabamento().Selecionar(lbl.Text, _ctx));
                }
            }
        }

        private void SalvarArmario(dao.imovel imov, imobappEntities _ctx)
        {
            imov.armario.Clear();

            foreach (DataListItem item in dtArmarios.Items)
            {
                CheckBox chk = (CheckBox)item.FindControl("chk");

                if (chk.Checked)
                {
                    Label lbl = (Label)item.FindControl("lbl");
                    imov.armario.Add(new business.Armario().Selecionar(lbl.Text, _ctx));
                }
            }
        }

        private void SalvarSocial(dao.imovel imov, imobappEntities _ctx)
        {
            imov.social.Clear();

            foreach (DataListItem item in dtSocial.Items)
            {
                CheckBox chk = (CheckBox)item.FindControl("chk");

                if (chk.Checked)
                {
                    Label lbl = (Label)item.FindControl("lbl");
                    imov.social.Add(new business.Social().Selecionar(lbl.Text, _ctx));
                }
            }
        }

        private void SalvarServico(dao.imovel imov, imobappEntities _ctx)
        {
            imov.servico.Clear();

            foreach (DataListItem item in dtSocial.Items)
            {
                CheckBox chk = (CheckBox)item.FindControl("chk");

                if (chk.Checked)
                {
                    Label lbl = (Label)item.FindControl("lbl");
                    imov.servico.Add(new business.Servico().Selecionar(lbl.Text, _ctx));
                }
            }
        }

        private void SalvarIntima(dao.imovel imov, imobappEntities _ctx)
        {
            imov.intima.Clear();

            foreach (DataListItem item in dtSocial.Items)
            {
                CheckBox chk = (CheckBox)item.FindControl("chk");

                if (chk.Checked)
                {
                    Label lbl = (Label)item.FindControl("lbl");
                    imov.intima.Add(new business.Intima().Selecionar(lbl.Text, _ctx));
                }
            }
        }

        private void SalvarLazer(dao.imovel imov, imobappEntities _ctx)
        {
            imov.lazer.Clear();

            foreach (DataListItem item in dtSocial.Items)
            {
                CheckBox chk = (CheckBox)item.FindControl("chk");

                if (chk.Checked)
                {
                    Label lbl = (Label)item.FindControl("lbl");
                    imov.lazer.Add(new business.Lazer().Selecionar(lbl.Text, _ctx));
                }
            }
        }
    }
}