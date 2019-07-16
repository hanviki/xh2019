﻿using System;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Ipedf.Web.Control;
using Ipedf.Core;
using Ipedf.Hrp.Hem.Sap.BizLogic;
using Ipedf.Hrp.Hem.Sap.Entity;
using Ipedf.Common;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class APPLY_PHONE_MSSAGE_LIST : Manage_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (!IsPostBack)
            {
                try
                {
                    DdlBindData();
                    BindData();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void DdlBindData()
        {
            CauseObject_SYS_DATA_TYPE cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1013";
            ddlInputPageSize.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputPageSize.DataTextField = "NAME";
            ddlInputPageSize.DataValueField = "CODE";
            ddlInputPageSize.DataBind();
        }

        protected void BindData()
        {
            int[] arrPage = new int[3] { 0, 0, 0 };

            ViewState["pageNum"] = arrPage;
            ShowQueryResult("1", CauseObject_Where());
        }

        public CauseObject_V_HEM_APPLY_PHONE_MSSAGE CauseObject_Where()
        {
            return getCauseObject();
        }

        protected void ShowQueryResult(string page, CauseObject_V_HEM_APPLY_PHONE_MSSAGE parameter)
        {
            CauseObject_V_HEM_APPLY_PHONE_MSSAGE cause = parameter;
            try
            {
                int[] arrPage = (int[])ViewState["pageNum"];
                int npage = GetPageIndex(page, arrPage, txt_PageNo);
                int PageSize = 10;
                if (ddlInputPageSize.Items.Count != 0)
                {
                    PageSize = int.Parse(ddlInputPageSize.SelectedValue);
                }

                PagingParamter paging = new PagingParamter() { PageIndex = npage, PageSize = PageSize };
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "SEND_TIME" };
                DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] disQuery = BizLogicObject_V_HEM_APPLY_PHONE_MSSAGE.Proxy.Query(cause, paging, orderBy);
                arrPage[0] = paging.PageIndex;
                arrPage[1] = paging.TotalRecords;
                arrPage[2] = paging.PageCount;
                ViewState["pageNum"] = arrPage;
                rpt_List.DataSource = disQuery;
                rpt_List.DataBind();
                PageText(paging, lbt_back, lbt_next, lbl_PageNo, txt_PageNo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void ddlInputPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }

        public CauseObject_V_HEM_APPLY_PHONE_MSSAGE getCauseObject()
        {
            string NACHN = txt_NACHN.Text;
            string SEND_PHONE = txt_SEND_PHONE.Text;
            string RECRUIT_POSITION = txt_RECRUIT_POSITION.Text;
            CauseObject_V_HEM_APPLY_PHONE_MSSAGE cause = new CauseObject_V_HEM_APPLY_PHONE_MSSAGE();
            string sqlWhere = "";
            if (!string.IsNullOrEmpty(SEND_PHONE))
            {
                cause.SEND_PHONE = SEND_PHONE;
            }
            if (!string.IsNullOrEmpty(NACHN))
            {
                sqlWhere = sqlWhere + " AND V_HEM_APPLY_PHONE_MSSAGE.NACHN LIKE '%" + NACHN + "%'";
            }

            if (!string.IsNullOrEmpty(RECRUIT_POSITION))
            {
                sqlWhere = sqlWhere + " AND V_HEM_APPLY_PHONE_MSSAGE.RECRUIT_POSITION LIKE '%" + RECRUIT_POSITION + "%'";
            }

            string Is_Send = ddlInputIsSend.SelectedValue;
            if (!string.IsNullOrEmpty(Is_Send))
            {
                if (Is_Send == "0")
                {
                    sqlWhere = sqlWhere + " AND V_HEM_APPLY_PHONE_MSSAGE.IS_SEND_NAME = '否' AND V_HEM_APPLY_PHONE_MSSAGE.SEND_ERROR IS NULL";
                }
                else if (Is_Send == "1")
                {
                    sqlWhere = sqlWhere + " AND V_HEM_APPLY_PHONE_MSSAGE.IS_SEND_NAME = '是' AND V_HEM_APPLY_PHONE_MSSAGE.SEND_ERROR IS NULL";
                }
                else
                {
                    sqlWhere = sqlWhere + " AND V_HEM_APPLY_PHONE_MSSAGE.IS_SEND_NAME = '否' AND V_HEM_APPLY_PHONE_MSSAGE.SEND_ERROR IS NOT NULL";
                }
            }

            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;
            if (UserInfo.ACCOUNT.ToUpper() != "ADMIN")
            {
                sqlWhere = sqlWhere + " AND ( V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID = '" + UserInfo.USER_ID + "' OR V_HEM_APPLY_PHONE_MSSAGE.IS_PUBLIC = 1 )";
            }

            if (!string.IsNullOrEmpty(sqlWhere))
            {
                cause.SetCustomCondition(sqlWhere);
            }
            return cause;
        }

        protected void btn_query_Click(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }

        protected void lbt_home_Click(object sender, EventArgs e)
        {
            ShowQueryResult("home", CauseObject_Where());
        }
        protected void lbt_back_Click(object sender, EventArgs e)
        {
            ShowQueryResult("back", CauseObject_Where());
        }
        protected void lbt_next_Click(object sender, EventArgs e)
        {
            ShowQueryResult("next", CauseObject_Where());
        }
        protected void lbt_last_Click(object sender, EventArgs e)
        {
            ShowQueryResult("last", CauseObject_Where());
        }
        protected void btn_GoPage_Click(object sender, EventArgs e)
        {
            ShowQueryResult("custom", CauseObject_Where());
        }
    }
}
