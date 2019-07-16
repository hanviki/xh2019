using System;
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
using Newtonsoft.Json;
using Ipedf.Core;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
	public partial class PageObject_BGT_D_BUDGET_DEPT_USER_Param : ComQueryParameterPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
			//ƽ̨�Զ����ɴ���
			this.ddlQueryUSER_ID.DataTable = "COM_USER";
		}        
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_D_BUDGET_DEPT_USER cause = new CauseObject_BGT_D_BUDGET_DEPT_USER();
			
			//ƽ̨�Զ����ɴ���
			if (!string.IsNullOrEmpty(ddlQueryUSER_ID.KeyValue))
			{
				cause.USER_ID = this.ddlQueryUSER_ID.KeyValue;
			}
			return cause;
        }
		protected override void OnClose(object sender, EventArgs e)
        {
            CauseObject_BGT_D_BUDGET_DEPT_USER  o = (CauseObject_BGT_D_BUDGET_DEPT_USER)PrepareQueryParameter();
            string parameter = JsonConvert.SerializeObject(o);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Request);
            parameters.Add("linkquery", parameter);
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_DEPT_USER.aspx", parameters);
            WebControlHelper.WriteScript(string.Concat("opener.location.href = '", url ,"';self.close();"));
        }
	}
}

