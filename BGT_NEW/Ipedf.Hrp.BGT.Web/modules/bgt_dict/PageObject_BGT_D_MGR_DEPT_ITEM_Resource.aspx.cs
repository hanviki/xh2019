﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Reflection;
using Ipedf.Web.Control;
using Ipedf.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Common;
namespace Ipedf.Web
{
	public partial class PageObject_BGT_D_MGR_DEPT_ITEM_Resource : ComSimpleListPage
	{
        public override bool OpLimitRequest
        {
            get
            {
                return false;
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
            this.command[Ipedf.Web.Control.ButtonType.Custom].Text = Ipedf.Web.Common.ButtonText.Confirm;
            this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = true;
            this.command[Ipedf.Web.Control.ButtonType.Query].Visible = true;
		}
		protected override void OnCustom(object sender, EventArgs e)
        {
            List<string> el = new List<string>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_DEPT entity = new EntityObject_BGT_D_BUDGET_DEPT();
                    entity.ID = gvList.DataKeys[row.RowIndex].Value.ToString();
                    if (select.Checked)
                    {
                        el.Add(entity.ID);
                    }
                }
            }
            string parameter = JsonConvert.SerializeObject(el.ToArray());
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
            parameters.Add("linksource", parameter);
            parameters.Remove("linkquery");
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_MGR_DEPT_ITEM.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url, "';self.close();"));           
        }
		protected override void PrepareCause()
		{
			
		}
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_DEPT cause = (CauseObject_BGT_D_BUDGET_DEPT)parameter;
            cause.IS_FUNCTION = 2;
            cause.SetCustomCondition(" and BGT_D_BUDGET_DEPT.Budget_Year = (select id from BGT_D_BUDGET_YEAR where IS_AVAILABE=1 and rownum = 1) ");
			dataSource = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override string PrepareOrderByColumn()
        {
            return "Create_Time";
        }
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_DEPT cause = new CauseObject_BGT_D_BUDGET_DEPT();
			
			return cause;
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_DEPT>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_MGR_DEPT_ITEM_Resource_PARAM.aspx", parameters);
            string scripts = WebControlHelper.GetOpenWindowScript(url, 500, 500);
            return scripts;
        }
        
	}
}

