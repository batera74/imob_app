using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Facebook;
using imob_app.business;

namespace imob_app.client
{
    public class BasePage : System.Web.UI.Page
    {
        string ApplicationID = "467560186589271";
        string ApplicationSecret = "0c0022c39879ce73ca8992407c5c3d94";

        /// <summary>
        /// Gets the complete URL of the current page.
        /// </summary>
        /// <returns>The complete URL for the current page</returns>
        public string getPageUrl()
        {
            return Request.Url.AbsoluteUri;
        }

        /// <summary>
        /// Gets the name of the current page.
        /// </summary>
        /// <returns>The name of the current page</returns>
        public string getPageName()
        {
            return Request.Url.AbsoluteUri.Substring(Request.Url.AbsoluteUri.LastIndexOf("/") + 1, Request.Url.AbsoluteUri.Length - (Request.Url.AbsoluteUri.LastIndexOf("/") + 1));
        }

        /// <summary>
        /// Gets the name of the current page.
        /// </summary>
        /// <returns>The name of the current page</returns>
        public string getPageClearName()
        {
            string pageName = getPageName();
            if (pageName.IndexOf("?") < 0)
                return pageName;
            return pageName.Substring(0, pageName.IndexOf("?"));
        }

        /// <summary>
        /// Opens an URL into the target.
        /// </summary>
        /// <param name="url">The URL to open</param>
        protected void OpenUrl(string url)
        {
            OpenUrl(url, null, null);
        }

        protected void Restart()
        {
            Response.Redirect(getPageUrl(), true);
        }

        protected string GetLoggedUserLogin()
        {
            return Context.User.Identity.Name.Substring(Context.User.Identity.Name.LastIndexOf("\\") + 1);
        }

        /// <summary>
        /// Opens an URL into the target.
        /// </summary>
        /// <param name="url">The URL to open</param>
        /// <param name="target">The target to open the URL (ex: _self, _blank)</param>
        protected void OpenUrl(string url, string target)
        {
            OpenUrl(url, target, null);
        }

        /// <summary>
        /// Opens an URL into the target.
        /// </summary>
        /// <param name="url">The URL to open</param>
        /// <param name="target">The target to open the URL (ex: _self, _blank)</param>
        /// <param name="properties">The properies used to open whe window.</param>
        protected void OpenUrl(string url, string target, string properties)
        {
            string script = "<script>window.open('" + url + "'";
            if (target != null)
                script += ",'" + target + "'";
            if (properties != null)
                script += ",'" + properties + "'";
            script += ");</script>";
            Response.Write(script);
        }

        public void Alert(string message)
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "PopupScript", "<script language=\"javascript\">alert('" + message + "');</script>");
        }

        private void BasePage_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    string signedRequest;
                    // Gambi para debugarmos.....
                    if (getPageUrl().ToLower().IndexOf("localhost") > -1)
                    {
                        // Para obter seu token:
                        //https://www.facebook.com/dialog/oauth?client_id=YOUR_APP_ID&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token
                        // YOUR_APP_ID se refere ao valor da variável ApplicationID lá em cima. ;-)
                        // O token aparece na URL após o envio da chamada.


                        // Se o signedRequest abaixo não funfar, acesse http://apps.facebook.com/placetoyou e clique no link "Política de Privacidade". Pegue a linguiça e atribua à variável abaixo. ;-)
                        //signedRequest = "jNT3nTbUXBzKUNfQb4aPH8LSA9AZpwhGKo99idDN8Ws.eyJhbGdvcml0aG0iOiJITUFDLVNIQTI1NiIsImV4cGlyZXMiOjEzNDQzMTIwMDAsImlzc3VlZF9hdCI6MTM0NDMwNjEzNywib2F1dGhfdG9rZW4iOiJBQUFHcFBsYlZNRmNCQUM1SVdESkVYMzFMSXhqRDM0bmJOVWFyRDl6NDVBTVhUVlBNS1R3UDhmUEFCTFNDU2pISFg2OHdmbGRVRlhGcldSUUs4cmpoS0NxSTk2d01zcHB5NDIyOTFrVnlnNWN2cjBiSSIsInVzZXIiOnsiY291bnRyeSI6ImJyIiwibG9jYWxlIjoicHRfQlIiLCJhZ2UiOnsibWluIjoyMX19LCJ1c2VyX2lkIjoiMTAwMDAzNjk1NjYxMDc0In0";
                        signedRequest = "rRgyo5v3X-98q0koYojqSKtWDh-FcjylrHujbUXwgu8.eyJhbGdvcml0aG0iOiJITUFDLVNIQTI1NiIsImV4cGlyZXMiOjEzNDQzMTU2MDAsImlzc3VlZF9hdCI6MTM0NDMwODcwOSwib2F1dGhfdG9rZW4iOiJBQUFHcFBsYlZNRmNCQU1VN2VmdXk2TmplN0lBMWQ4WkFWY1duM0NtTnZMeVM2WkJtZWtZZlpDTE1vQm5nZWVRMTI2NWtwSmZ6Q1pCa2doTVhvbXZ1dUNLQVM0c1ZaQm1WTHRYR3RXNVpCT2hQNHp0SWRCWkFEbkUiLCJ1c2VyIjp7ImNvdW50cnkiOiJiciIsImxvY2FsZSI6InB0X0JSIiwiYWdlIjp7Im1pbiI6MjF9fSwidXNlcl9pZCI6IjEwMDAwMzY5NTY2MTA3NCJ9";
                    }
                    else
                    {
                        signedRequest = Request.Form["signed_request"];
                    }
                    var client = new FacebookClient();
                    object result;
                    if (client.TryParseSignedRequest(ApplicationSecret, signedRequest, out result))
                    {
                        var auth = result as IDictionary<string, object>;
                        string token = (string)auth["oauth_token"];
                        string userId = auth["user_id"].ToString();

                        //var user = new FacebookClient(token).Get("me") as IDictionary<string, object>;
                        //Session["user"] = user;                        

                        //Alert(user.ToString());
                    }
                    else
                    {
                        Response.Redirect("https://www.facebook.com/pages/Place-2-You-O-lugar-perfeito-para-sua-fam%C3%ADlia-ou-seus-neg%C3%B3cios/251693864933782");
                        Response.End();
                    }
                }
            }
            catch (Exception ex)
            {
                Alert("Erro ao tentar conectar ao Facebook: " + ex.Message);
                Alert("Mais detalhes: " + ex.StackTrace);
            }
        }

        private void BasePage_Error(object sender, EventArgs e)
        {
            imob_app.business.Sistema sistema = new imob_app.business.Sistema(Session["UserId"].ToString());
            string errorPage = ConfigurationManager.AppSettings["ErrorPage"];
            Exception ex = Server.GetLastError();
            string errorCode = sistema.RegistrarErro(ex);
            if (errorCode == "0")
                errorCode = "";
            if (errorPage != "")
                Response.Redirect(errorPage + "?errorcode=" + errorCode);
        }

        #region Web Form Designer generated code
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            string initialPage = "Erro.aspx";
            if (initialPage != null && initialPage != "")
                this.Error += new EventHandler(BasePage_Error);
            this.Load += new EventHandler(BasePage_Load);
        }
        #endregion
    }
}