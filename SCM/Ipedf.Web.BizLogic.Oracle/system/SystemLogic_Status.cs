using System;
using System.Collections.Generic;
using System.Text;
using Ipedf.Web.Entity;using Ipedf.Web.DataAccess;
using ConstLibrary = Ipedf.Common;
using Ipedf.Core;
using Ipedf.Common;
namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic
    {        
        public object GetStatus(object entity)
        {
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                return p5.GetValue(entity, null);
            }
            return null;
        }
        public void SetStatus(object entity, object state)
        {
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, state, null);
            }
        }
        public void SetAuditStatus(object entity)
        {
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (int)����״̬.�����, null);
            }
        }
        public void SetArchiveStatus(object entity)
        {
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (int)����״̬.�ѹ鵵, null);
            }
        }
        public bool IsAuditStatus(object entity)
        {
            object state = GetStatus(entity);
            if (state != null)
            {
                return Convert.ToInt32(state) == (int)����״̬.�����;
            }
            return false;
        }
        public bool IsArchiveStatus(object entity)
        {
            object state = GetStatus(entity);
            if (state != null)
            {
                return Convert.ToInt32(state) == (int)����״̬.�ѹ鵵;
            }
            return false;
        }
        public bool IsSubmitStatus(object entity)
        {
            object state = GetStatus(entity);
            if (state != null)
            {
                return Convert.ToInt32(state) == (int)����״̬.���ύ;
            }
            return false;
        }
        public bool IsEditStatus(object entity)
        {
            object state = GetStatus(entity);
            if (state != null)
            {
                return Convert.ToInt32(state) == (int)����״̬.�༭�� || Convert.ToInt32(state) == (int)����״̬.Ĭ��ֵ;
            }
            return true;
        }
        public bool IsCancelStatus(object entity)
        {
            object state = GetStatus(entity);
            if (state != null)
            {
                return Convert.ToInt32(state) == (int)����״̬.������;
            }
            return false;
        }
    }
}
