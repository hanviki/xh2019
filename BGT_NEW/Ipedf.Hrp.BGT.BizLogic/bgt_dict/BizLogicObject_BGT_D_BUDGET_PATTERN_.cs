
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Web.ServiceContract;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
using Ipedf.Wcf.ClientProxy;
namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_BGT_D_BUDGET_PATTERN
    {
        public override void PostSave(EntityObject_BGT_D_BUDGET_PATTERN entity, IDbTransaction transaction)
        {
            //�����������ģʽ,���ҽ���1�����ݵ��Ƿ�����Ϊ��
            decimal rpt = HelperObject_BGT_D_BUDGET_PATTERN.GetRepeartBudgetYear(transaction);
            if (rpt != 0)
                throw new Exception("ÿ��Ԥ����ֻ������һ��Ԥ��ģʽ");
            base.PostSave(entity, transaction);
        }
    }
}
