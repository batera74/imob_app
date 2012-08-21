using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Threading;
using imob_app.dao;
using System.IO;

namespace imob_app.client.controls
{
    public partial class galeria : System.Web.UI.UserControl
    {
        private const string Temp = @"C:\Users\GUILHERME\Documents\GitHub\imob_app\Imob_App\Imagens_Temp\";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CarregarImagens();
            else if (Session["imgPersiste"] != null)
            {
                SalvarImagem();
            }
        }

        public IEnumerable DataSource
        {
            get;
            set;
        }

        public bool Admin
        {
            get;
            set;
        }

        protected void dtlMini_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            dao.imagem dataImg = (dao.imagem)e.Item.DataItem;
            CheckBox chk = (CheckBox)e.Item.FindControl("chkPrincipal");
            LinkButton lnk = (LinkButton)e.Item.FindControl("lnkExcluir");
            Image img = (Image)e.Item.FindControl("imgImovel");
            HyperLink hlk = (HyperLink)e.Item.FindControl("hlkImagem");

            if (!Admin || dataImg.id_imagem == 0)
            {
                chk.Visible = false;
                lnk.Visible = false;
            }

            if (dataImg.id_imagem > 0)
            {
                img.ImageUrl = "/Imagem.ashx?idFoto=" + dataImg.id_imagem;
                hlk.NavigateUrl = "/Imagem.ashx?idFoto=" + dataImg.id_imagem;
                lnk.Attributes.Add("idImagem", dataImg.id_imagem.ToString());
                lnk.CommandArgument = dataImg.id_imagem.ToString();
                img.AlternateText = dataImg.ds_imagem;
                chk.Checked = dataImg.ic_principal;
                chk.Enabled = !dataImg.ic_principal;
                chk.Attributes.Add("idImagem", dataImg.id_imagem.ToString());
            }
            else
            {
                img.ImageUrl = "/images/sem_imagem.gif";
                hlk.NavigateUrl = "/images/sem_imagem.gif";
            }
        }

        private void CarregarImagens()
        {
            int idImovel = Convert.ToInt32(Request.QueryString["Imovel"]);

            if (idImovel > 0)
            {

                business.Imovel imovBiz = new business.Imovel();

                dao.imovel imov = imovBiz.SelecionarImovel(idImovel);

                if (imov.imagem != null && imov.imagem.Count > 0)
                    this.DataSource = imov.imagem;
                else
                {
                    dao.imagem img = new imagem();
                    img.ds_imagem = "Sem imagem";
                    img.id_imagem = 0;

                    this.DataSource = new List<dao.imagem>() { img };
                }

                dtlMini.DataSource = DataSource;
                dtlMini.DataBind();
            }
        }

        protected void chkPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            business.Imagem imgBiz = new business.Imagem();
            int idImovel = Convert.ToInt32(Request.QueryString["Imovel"]);
            CheckBox chk = (CheckBox)sender;
            int id = Convert.ToInt32(chk.Attributes["idImagem"]);

            imgBiz.SetPrincipal(id, idImovel);

            CarregarImagens();
        }

        protected void dtlMini_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int idImagem = Convert.ToInt32(e.CommandArgument);
            business.Imagem imgBiz;

            if (e.CommandName.Equals("Delete"))
            {
                try
                {
                    imgBiz = new business.Imagem();
                    dao.imagem img = imgBiz.Selecionar(idImagem);

                    if (!img.ic_principal)
                    {
                        imgBiz.Deletar(img);
                        Alert("Imagem excluída com sucesso!");
                        CarregarImagens();
                    }
                    else
                        Alert("Não é possível excluir a imagem principal!");
                }
                catch
                {
                    Alert("Ocorreu um erro ao exluir a imagem!");
                }
            }
        }

        public void Alert(string message)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + message + "!');", true);
        }

        protected void SalvarImagem()
        {
            //Limpa diretório temporário de imagens
            LimparTemp();

            //Instância nova imagem
            dao.imagem img = new dao.imagem();

            //FileUpload que contém a imagem à ser feita o upload
            AjaxControlToolkit.AsyncFileUpload fileUpload = (AjaxControlToolkit.AsyncFileUpload)Session["imgPersiste"];

            //Path da imagem
            string file = UploadPhoto(fileUpload);

            //Limpa a Session
            Session["imgPersiste"] = null;

            //Set das propriedades da nova imagem
            img.ic_principal = false;
            img.ds_imagem = "Texto";
            img.ds_imagem_cripto = ToString(file);

            if (Request.QueryString["Imovel"] != null)
            {
                business.Imovel imov = new business.Imovel();
                imov.AdicionarImagem(img, Convert.ToInt32(Request.QueryString["Imovel"]));
            }
            else
                AssociarImagemAImovelNovo(img);

            CarregarImagens();
        }

        private void AssociarImagemAImovelNovo(dao.imagem img)
        {
            business.Imagem imgBiz = new business.Imagem();
            imgBiz.Adicionar(img);
        }

        private string UploadPhoto(AjaxControlToolkit.AsyncFileUpload file)
        {
            string path = "";
            try
            {
                if (file.HasFile)
                {
                    if (file.PostedFile.ContentLength < 1048576)
                    {
                        Boolean fileOK = false;
                        if (file.HasFile)
                        {
                            String fileExtension = System.IO.Path.GetExtension(file.FileName).ToLower();
                            String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };

                            for (int i = 0; i < allowedExtensions.Length; i++)
                            {
                                if (fileExtension == allowedExtensions[i])
                                    fileOK = true;
                            }
                        }
                        if (fileOK)
                        {
                            try
                            {
                                path = Temp + DateTime.Now.ToString("ddMMyy") + "_" + file.FileName;
                                file.SaveAs(path);
                            }
                            catch (Exception ex)
                            {
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "init", "<script>alert('" + ex.Message + ".');</script>");
                            }
                        }
                        else
                        {
                            string msg = "Só poderá carregar imagens neste campo.";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "init", "<script>alert('" + msg + ".');</script>");
                        }
                    }
                    else
                    {
                        string msg = "Limite máximo para a imagem é de 1MB.";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "init", "<script>alert('" + msg + ".');</script>");
                    }
                }

                file.Dispose();
                return path;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string ToString(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path");

            System.Drawing.Image im = System.Drawing.Image.FromFile(path);
            MemoryStream ms = new MemoryStream();
            im.Save(ms, im.RawFormat);
            byte[] array = ms.ToArray();
            ms.Close();
            return Convert.ToBase64String(array);
        }

        public static void LimparTemp()
        {
            string[] filePaths = Directory.GetFiles(Temp);
            foreach (string filePath in filePaths)
                File.Delete(filePath);
        }
    }
}