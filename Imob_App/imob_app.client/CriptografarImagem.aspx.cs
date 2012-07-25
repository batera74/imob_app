using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

namespace imob_app.client
{
    public partial class CriptografarImagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string file = UploadPhoto(FileUpload1);
            int id = Convert.ToInt32(txtFoto0.Text);
            dao.imobappEntities ctx = new dao.imobappEntities();
            dao.imagem img = new dao.imagem();
            dao.imovel imov = ctx.imovel.FirstOrDefault(i => i.id_imovel == id);            
            img.ic_principal = true;
            img.ds_imagem = txtFoto.Text;
            img.ds_imagem_cripto = ToString(file);
            imov.imagem.Add(img);            
            ctx.SaveChanges();
        }

        private string UploadPhoto(FileUpload file)
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
                                string path1 = @"C:\Users\GUILHERME\Documents\GitHub\imob_app\Imob_App\Imagens_Temp\";
                                path = path1 + DateTime.Now.ToString("ddMMyy") + "_" + file.FileName;
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
    }
}