using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

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
            int heightDiff, maxHeight = 450;
            double porcentagemFoto;

            Image image = business.Foto.ToImage(imob_app.business.Foto.Selecionar(idFoto));

            if (image.Height > 500)
            {
                heightDiff = image.Height - maxHeight;
                porcentagemFoto = 1.0 - ((double)heightDiff / (double)image.Height);
                image = Resize(image, porcentagemFoto);
            }

            using (image)
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

        public Image Resize(Image img, double percentage)
        {
            //get the height and width of the image
            int originalW = img.Width;
            int originalH = img.Height;

            //get the new size based on the percentage change
            int resizedW = (int)(originalW * percentage);
            int resizedH = (int)(originalH * percentage);

            //create a new Bitmap the size of the new image
            Bitmap bmp = new Bitmap(resizedW, resizedH);
            //create a new graphic from the Bitmap
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //draw the newly resized image
            graphic.DrawImage(img, 0, 0, resizedW, resizedH);
            //dispose and free up the resources
            graphic.Dispose();
            //return the image
            return (Image)bmp;
        }
    }
}