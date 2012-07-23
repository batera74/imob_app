using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace imob_app.client
{
    /// <summary>
    /// Summary description for Photo
    /// </summary>
    public class Imagem : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            int idFoto = Convert.ToInt16(context.Request.QueryString["idFoto"]);

            using (Image image = business.Foto.ToImage(imob_app.business.Foto.Selecionar(idFoto)))
            {
                Bitmap bit = new Bitmap(image);
                context.Response.Clear();
                context.Response.ContentType = "image/jpeg";

                using (MemoryStream stream = new MemoryStream())
                {
                    bit.Save(stream, ImageFormat.Jpeg);
                    stream.WriteTo(context.Response.OutputStream);
                }
            }
        }

        public bool IsReusable { get { return true; } }
    }
}