﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


namespace Layout.controls
{
    public partial class CustomDataList : System.Web.UI.UserControl
    {
        #region Public Properties
        public DataTable DataTableSource 
        { 
            get; 
            set; 
        }
        public int TotalRegistros { get; set; }
        #endregion

        #region Private Properties
        private int CurrentPage
        {
            get
            {
                object objPage = ViewState["_CurrentPage"];
                int _CurrentPage = 0;
                if (objPage == null)
                {
                    _CurrentPage = 0;
                }
                else
                {
                    _CurrentPage = (int)objPage;
                }
                return _CurrentPage;
            }
            set { ViewState["_CurrentPage"] = value; }
        }
        private int fistIndex
        {
            get
            {

                int _FirstIndex = 0;
                if (ViewState["_FirstIndex"] == null)
                {
                    _FirstIndex = 0;
                }
                else
                {
                    _FirstIndex = Convert.ToInt32(ViewState["_FirstIndex"]);
                }
                return _FirstIndex;
            }
            set { ViewState["_FirstIndex"] = value; }
        }
        private int lastIndex
        {
            get
            {

                int _LastIndex = 0;
                if (ViewState["_LastIndex"] == null)
                {
                    _LastIndex = 0;
                }
                else
                {
                    _LastIndex = Convert.ToInt32(ViewState["_LastIndex"]);
                }
                return _LastIndex;
            }
            set { ViewState["_LastIndex"] = value; }
        }
        #endregion

        #region PagedDataSource
        PagedDataSource _PageDataSource = new PagedDataSource();
        #endregion

        #region Private Methods
        /// <summary>
        /// Build DataTable to bind Main Items List
        /// </summary>
        /// <returns>DataTable</returns>
        /// 



        /// <summary>
        /// Binding Main Items List
        /// </summary>
        private void BindItemsList()
        {
            if (DataTableSource != null && DataTableSource.Rows.Count > 0)
            {
                DataTable dataTable = DataTableSource;
                _PageDataSource.DataSource = dataTable.DefaultView;
                _PageDataSource.AllowPaging = true;
                _PageDataSource.PageSize = TotalRegistros;
                _PageDataSource.CurrentPageIndex = CurrentPage;
                ViewState["TotalPages"] = _PageDataSource.PageCount;

                this.lblPageInfo.Text = "Página " + (CurrentPage + 1) + " de " + _PageDataSource.PageCount;
                this.lbtnPrevious.Enabled = !_PageDataSource.IsFirstPage;
                this.lbtnNext.Enabled = !_PageDataSource.IsLastPage;
                this.lbtnFirst.Enabled = !_PageDataSource.IsFirstPage;
                this.lbtnLast.Enabled = !_PageDataSource.IsLastPage;
                this.lbtnPrevious1.Enabled = !_PageDataSource.IsFirstPage;
                this.lbtnNext1.Enabled = !_PageDataSource.IsLastPage;
                this.lbtnFirst1.Enabled = !_PageDataSource.IsFirstPage;
                this.lbtnLast1.Enabled = !_PageDataSource.IsLastPage;

                this.dListItems.DataSource = _PageDataSource;
                this.dListItems.DataBind();
                this.doPaging();
            }
            else
            {
                this.lblPageInfo.Visible = this.lblPageInfo.Enabled = false;
                this.lbtnPrevious.Visible = this.lbtnPrevious.Enabled = false;
                this.lbtnNext.Visible = this.lbtnNext.Enabled = false;
                this.lbtnFirst.Visible = this.lbtnFirst.Enabled = false;
                this.lbtnLast.Visible = this.lbtnLast.Enabled = false;
                this.lbtnPrevious1.Visible = this.lbtnPrevious1.Enabled = false;
                this.lbtnNext1.Visible = this.lbtnNext1.Enabled = false;
                this.lbtnFirst1.Visible = this.lbtnFirst1.Enabled = false;
                this.lbtnLast1.Visible = this.lbtnLast1.Enabled = false;
                this.dListItems.Visible = this.dListItems.Enabled = false;
                this.lblInfo.Visible = true;
            }

        }

        /// <summary>
        /// Binding Paging List
        /// </summary>
        private void doPaging()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PageIndex");
            dt.Columns.Add("PageText");

            fistIndex = CurrentPage - 5;


            if (CurrentPage > 5)
            {
                lastIndex = CurrentPage + 5;
            }
            else
            {
                lastIndex = 10;
            }
            if (lastIndex > Convert.ToInt32(ViewState["TotalPages"]))
            {
                lastIndex = Convert.ToInt32(ViewState["TotalPages"]);
                fistIndex = lastIndex - 10;
            }

            if (fistIndex < 0)
            {
                fistIndex = 0;
            }

            for (int i = fistIndex; i < lastIndex; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i;
                dr[1] = i + 1;
                dt.Rows.Add(dr);
            }

            this.dlPaging.DataSource = dt;
            this.dlPaging.DataBind();
            this.dlPaging1.DataSource = dt;
            this.dlPaging1.DataBind();
        }
        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
                this.BindItemsList();
        }

        protected void dlPaging_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("Paging"))
            {
                CurrentPage = Convert.ToInt16(e.CommandArgument.ToString());
                this.BindItemsList();
            }
        }
        protected void dlPaging_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            LinkButton lnkbtnPage = (LinkButton)e.Item.FindControl("lnkbtnPaging");
            if (lnkbtnPage.CommandArgument.ToString() == CurrentPage.ToString())
            {
                lnkbtnPage.Enabled = false;
                lnkbtnPage.Style.Add("fone-size", "14px");
                lnkbtnPage.Font.Bold = true;
            }
        }

        protected void lbtnNext_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage += 1;
            this.BindItemsList();
        }

        protected void lbtnLast_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage = (Convert.ToInt32(ViewState["TotalPages"]) - 1);
            this.BindItemsList();
        }

        protected void lbtnPrevious_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage -= 1;
            this.BindItemsList();
        }

        protected void lbtnFirst_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage = 0;
            this.BindItemsList();
        }

        protected void dListItems_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            Image img = (Image)e.Item.FindControl("Image2");

            try
            {
                if (img.ImageUrl.Equals("") || img.ImageUrl == null)
                {
                    img.ImageUrl = "http://www.imobiliariainfinity.com.br/Images/Imoveis/sem_imagem.jpg";
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}

