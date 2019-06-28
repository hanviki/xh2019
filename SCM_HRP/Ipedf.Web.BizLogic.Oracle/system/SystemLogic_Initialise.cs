using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Web.UI.HtmlControls;
using System.Text;
using System.Xml;
using System.IO;
using Ipedf.Core;
using System.Data.SqlClient;
using Ipedf.Web.DataAccess;
using System.Security.Cryptography;
using System.Collections;
using Ipedf.Web.DataAccess;
using System.Text;
using System.Collections.Specialized;
//using ExamSys.Common.system;
using System.Data.OracleClient;
using Ipedf.Web.Entity;
using Ipedf.Common;
namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic
    {
        #region Proxy
        private SystemLogic() { }
        private static SystemLogic singleton;
        public static SystemLogic Proxy
        {
            get
            {
                if (singleton == null) singleton = new SystemLogic();
                return singleton;
            }
        }
        #endregion	
        /// <summary>
        /// ִ��Com_Data��ʼ������
        /// </summary>
        public  BizLogicMsg ExecuteInitialiseDataTransaction()
        {
            throw new Exception("�����ѷ���");
            //IDatabaseProduct databaseProduct = new Oracle9I();
            //List<string> views = new List<string>();
            //List<string> tables = new List<string>();
            //try
            //{
            //    views.AddRange(databaseProduct.LoadViews(IDALProvider.IDAL.ConnectionString));
            //    tables.AddRange(databaseProduct.LoadTables(IDALProvider.IDAL.ConnectionString));
            //}
            //catch(Exception expt)
            //{
            //    return new BizLogicMsg(expt.Message);
            //}
            //List<string> targets = new List<string>();
            //foreach (string view in views)
            //{
            //    if (view.ToUpper().IndexOf("V_") == 0)
            //    {
            //        targets.Add(view.ToUpper());
            //    }
            //}
            //foreach (string table in tables)
            //{
            //    if (table.ToUpper().IndexOf("COM_") == 0 || table.ToUpper().IndexOf("BIZ_") == 0)
            //    {
            //        targets.Add(table.ToUpper());
            //    }
            //}
            //using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            //{
            //    using (IDbTransaction transaction = connection.BeginTransaction())
            //    {
            //        //ɾ����������
            //        CauseObject_COM_DATA p = new CauseObject_COM_DATA();
            //        HelperObject_COM_DATA.Delete(p, transaction);
            //        //׷����������
            //        foreach (string target in targets)
            //        {
            //            EntityObject_COM_DATA data = new EntityObject_COM_DATA();
            //            data.COMMENTS = target;
            //            data.NAME = target;
            //            SystemLogic.Proxy.AuditAdd(data);
            //            HelperObject_COM_DATA.Save(data, transaction);
            //        }
            //        try
            //        {                        
            //            transaction.Commit();
            //            return new BizLogicMsg();
            //        }
            //        catch (Exception expt)
            //        {
            //            transaction.Rollback();
            //            return new BizLogicMsg(expt.Message);
            //        }
            //        finally
            //        {
            //            connection.Close();
            //        }
            //    }
            //}
        }
        /// <summary>
        /// ִ��Com_Role_M_Data��ʼ������,��ҵ������,Com_Depart,Com_Employee������֯�޶�����ע�ᵽ���н�ɫ
        /// </summary>
        public  BizLogicMsg ExecuteInitialiseRoleDataTransaction()
        {            
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    CauseObject_COM_DATA pData = new CauseObject_COM_DATA();
                    DisplayObject_COM_DATA[] datas = HelperObject_COM_DATA.Query(pData, transaction);
                    CauseObject_COM_ROLE pRole = new CauseObject_COM_ROLE();
                    DisplayObject_COM_ROLE[] roles = HelperObject_COM_ROLE.Query(pRole, transaction);
                    //�����������
                    CauseObject_COM_ROLE_M_DATA pRmd = new CauseObject_COM_ROLE_M_DATA();
                    HelperObject_COM_ROLE_M_DATA.Delete(pRmd, transaction);
                    //��֯�޶�����
                    CauseObject_COM_STRATEGY pStrategy = new CauseObject_COM_STRATEGY();
                    pStrategy.STRATEGY_CODE = "OrganiseQuerayAditStrategy";
                    DisplayObject_COM_STRATEGY[] strategies = HelperObject_COM_STRATEGY.Query(pStrategy, transaction);
                    //Com_User
                    //pData = new CauseObject_COM_DATA();
                    //pData.NAME = "COM_USER";
                    //DisplayObject_COM_DATA[] users = HelperObject_COM_DATA.Query(pData, transaction);
                    //Com_Depart
                    pData = new CauseObject_COM_DATA();
                    pData.NAME = "COM_DEPART";
                    DisplayObject_COM_DATA[] departs = HelperObject_COM_DATA.Query(pData, transaction);
                    //Com_Employee
                    pData = new CauseObject_COM_DATA();
                    pData.NAME = "COM_EMPLOYEE";
                    DisplayObject_COM_DATA[] employees = HelperObject_COM_DATA.Query(pData, transaction);
                    if (strategies.Length == 1)
                    {
                        //�����н�ɫ����ҵ�����ݽ�����֯�޶�����ע��
                        foreach (DisplayObject_COM_DATA data in datas)
                        {
                            foreach (DisplayObject_COM_ROLE role in roles)
                            {
                                EntityObject_COM_ROLE_M_DATA rmd = new EntityObject_COM_ROLE_M_DATA();
                                rmd.DATA_ID = data.ID;
                                rmd.ROLE_ID = role.ID;
                                rmd.STRATEGY_ID = strategies[0].ID;
                                SystemLogic.Proxy.AuditAdd(rmd);
                                HelperObject_COM_ROLE_M_DATA.Save(rmd, transaction);
                            }
                        }
                        //�����н�ɫ����Com_User,Com_Depart,Com_Employee������֯�޶�����ע��
                        foreach (DisplayObject_COM_ROLE role in roles)
                        {
                            //if (users.Length == 1)
                            //{
                            //    //Com_User
                            //    EntityObject_COM_ROLE_M_DATA rmd = new EntityObject_COM_ROLE_M_DATA();
                            //    rmd.DATA_ID = users[0].ID;
                            //    rmd.ROLE_ID = role.ID;
                            //    rmd.STRATEGY_ID = strategies[0].ID;
                            //    SystemLogic.AuditAdd(rmd);
                            //    HelperObject_COM_ROLE_M_DATA.Save(rmd, transaction);
                            //}
                            if (departs.Length == 1)
                            {
                                //Com_Depart
                                EntityObject_COM_ROLE_M_DATA rmd = new EntityObject_COM_ROLE_M_DATA();
                                rmd.DATA_ID = departs[0].ID;
                                rmd.ROLE_ID = role.ID;
                                rmd.STRATEGY_ID = strategies[0].ID;
                                SystemLogic.Proxy.AuditAdd(rmd);
                                HelperObject_COM_ROLE_M_DATA.Save(rmd, transaction);
                            }
                            if (employees.Length == 1)
                            {
                                //Com_Employee
                                EntityObject_COM_ROLE_M_DATA rmd = new EntityObject_COM_ROLE_M_DATA();
                                rmd.DATA_ID = employees[0].ID;
                                rmd.ROLE_ID = role.ID;
                                rmd.STRATEGY_ID = strategies[0].ID;
                                SystemLogic.Proxy.AuditAdd(rmd);
                                HelperObject_COM_ROLE_M_DATA.Save(rmd, transaction);
                            }
                        }
                    }
                    try
                    {                        
                        transaction.Commit();
                        return new BizLogicMsg();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        return new BizLogicMsg(expt.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        /// <summary>
        /// ִ��Com_Strategy��ʼ������,���Ӵ����߲��Ժ���֯�޶�����
        /// </summary>
        public  BizLogicMsg ExecuteInitialiseStrategyTransaction()
        {
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    //�����������
                    CauseObject_COM_STRATEGY pStrategy = new CauseObject_COM_STRATEGY();
                    HelperObject_COM_STRATEGY.Delete(pStrategy, transaction);
                    //�����߲���
                    EntityObject_COM_STRATEGY strategy = new EntityObject_COM_STRATEGY();
                    strategy.COMMENTS = "���ݽ������߿ɼ�";
                    strategy.STATE = (decimal)����״̬.����;
                    strategy.STRATEGY_CODE = "CreateUserQuerayAditStrategy";
                    strategy.STRATEGY_NAME = "�����߲���";
                    strategy.STRATEGY_TYPE = "Ipedf.Web.BizLogic.CreateUserQuerayAditStrategy";
                    //��֯�޶�����
                    HelperObject_COM_STRATEGY.Save(strategy, transaction);
                    strategy = new EntityObject_COM_STRATEGY();
                    strategy.COMMENTS = "���ݽ���ǰ��֯���û��ɼ�";
                    strategy.STATE = (decimal)����״̬.����;
                    strategy.STRATEGY_CODE = "OrganiseQuerayAditStrategy";
                    strategy.STRATEGY_NAME = "��֯�޶�����";
                    strategy.STRATEGY_TYPE = "Ipedf.Web.BizLogic.OrganiseLimitQuerayAditStrategy";
                    HelperObject_COM_STRATEGY.Save(strategy, transaction);
                    try
                    {                       
                        transaction.Commit();
                        return new BizLogicMsg();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        return new BizLogicMsg(expt.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

    }

}
