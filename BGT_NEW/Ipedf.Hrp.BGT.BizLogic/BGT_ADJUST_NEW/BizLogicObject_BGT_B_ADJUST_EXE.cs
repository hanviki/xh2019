#define NESTING
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
using System.Collections.Generic;
namespace Ipedf.Web.BizLogic
{
    [CauseObject(typeof(CauseObject_BGT_B_ADJUST_EXE))]
    public partial class BizLogicObject_BGT_B_ADJUST_EXE : BizLogicBase<EntityObject_BGT_B_ADJUST_EXE>, ServiceContract_BGT_B_ADJUST_EXE
    {
        #region Proxy
        public BizLogicObject_BGT_B_ADJUST_EXE() { }
        private static ServiceContract_BGT_B_ADJUST_EXE singleton;
        public static ServiceContract_BGT_B_ADJUST_EXE Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_BGT_B_ADJUST_EXE();
                return singleton;
            }
        }
        #endregion
        #region Method Blok
        public BizLogicMsg Save(EntityObject_BGT_B_ADJUST_EXE obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            SystemLogic.Proxy.AuditAdd(obj);
                            int amount = HelperObject_BGT_B_ADJUST_EXE.Save(obj, transaction);
                            //ƽ̨�Զ����ɴ���
                            PostSave(obj, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
        }
        public BizLogicMsg Update(EntityObject_BGT_B_ADJUST_EXE obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            SystemLogic.Proxy.AuditEdit(obj);
                            int amount = HelperObject_BGT_B_ADJUST_EXE.Update(obj, transaction);
                            //ƽ̨�Զ����ɴ���
                            PostSave(obj, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
            }
        }
        public BizLogicMsg Delete(EntityObject_BGT_B_ADJUST_EXE obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            int amount = HelperObject_BGT_B_ADJUST_EXE.Delete(obj, transaction);
                            //ƽ̨�Զ����ɴ���
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
            }
        }
        public EntityObject_BGT_B_ADJUST_EXE Get(EntityObject_BGT_B_ADJUST_EXE obj)
        {
            if (LocalMode)
            {

                //ƽ̨�Զ����ɴ���
                return HelperObject_BGT_B_ADJUST_EXE.Get(obj);
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
            }
        }
        public DisplayObject_BGT_B_ADJUST_EXE[] List()
        {
            if (LocalMode)
            {

                //ƽ̨�Զ����ɴ���
                return HelperObject_BGT_B_ADJUST_EXE.List();
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.List();
                }
            }
        }
        public DisplayObject_BGT_B_ADJUST_EXE[] Query(CauseObject_BGT_B_ADJUST_EXE cause)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditQuery(cause);

                //ƽ̨�Զ����ɴ���
                return HelperObject_BGT_B_ADJUST_EXE.Query(cause);
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
            }
        }
        public BizLogicMsg Delete(CauseObject_BGT_B_ADJUST_EXE cause)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            int amount = HelperObject_BGT_B_ADJUST_EXE.Delete(cause, transaction);
                            //ƽ̨�Զ����ɴ���
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
            }
        }
        public DisplayObject_BGT_B_ADJUST_EXE[] Query(CauseObject_BGT_B_ADJUST_EXE cause, PagingParamter paging, OrderByParameter order)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditQuery(cause);

                //ƽ̨�Զ����ɴ���
                return HelperObject_BGT_B_ADJUST_EXE.Query(cause, paging, order);
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Query(cause, paging, order);
                }
            }
        }
        public BizLogicMsg BatchSave(EntityObject_BGT_B_ADJUST_EXE[] objs)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            foreach (EntityObject_BGT_B_ADJUST_EXE obj in objs)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                            }
                            int amount = 0;

                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_B_ADJUST_EXE obj in objs)
                            {
                                amount += HelperObject_BGT_B_ADJUST_EXE.Save(obj, transaction);
                            }
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_BGT_B_ADJUST_EXE[] objs)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            foreach (EntityObject_BGT_B_ADJUST_EXE obj in objs)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                            }
                            int amount = 0;

                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_B_ADJUST_EXE obj in objs)
                            {
                                amount += HelperObject_BGT_B_ADJUST_EXE.Update(obj, transaction);
                            }
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_BGT_B_ADJUST_EXE[] objs)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            int amount = 0;

                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_B_ADJUST_EXE obj in objs)
                            {
                                amount += HelperObject_BGT_B_ADJUST_EXE.Delete(obj, transaction);
                            }
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_BGT_B_ADJUST_EXE obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            SystemLogic.Proxy.AuditCancel(obj);
                            int amount = HelperObject_BGT_B_ADJUST_EXE.Update(obj, transaction);
                            //ƽ̨�Զ����ɴ���                       
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        
        public BizLogicMsg UndoAudit(EntityObject_BGT_B_ADJUST_EXE obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {

                            SystemLogic.Proxy.AuditUndoAudit(obj);
                            int amount = HelperObject_BGT_B_ADJUST_EXE.Update(obj, transaction);
                            //ƽ̨�Զ����ɴ���
                            PostUndoAudit(obj, transaction);
                            //ִ�г��ز���
                            msg = SystemLogic.Proxy.BillUndoAudit(obj, transaction);
                            if (!msg.Succeed) throw new Exception(msg.Message);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            SystemLogic.Proxy.AuditState(obj, Ipedf.Common.����״̬.�����);
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_BGT_B_ADJUST_EXE obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            SystemLogic.Proxy.AuditArchive(obj);
                            int amount = HelperObject_BGT_B_ADJUST_EXE.Update(obj, transaction);
                            //ƽ̨�Զ����ɴ���
                            PostArchive(obj, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            SystemLogic.Proxy.AuditState(obj, Ipedf.Common.����״̬.�����);
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }
        public BizLogicMsg Submit(EntityObject_BGT_B_ADJUST_EXE obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            SystemLogic.Proxy.AuditSubmit(obj);
                            int amount = HelperObject_BGT_B_ADJUST_EXE.Update(obj, transaction);
                            //ƽ̨�Զ����ɴ���
                            PostSubmit(obj, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            SystemLogic.Proxy.AuditState(obj, Ipedf.Common.����״̬.�༭��);
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_BGT_B_ADJUST_EXE obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            SystemLogic.Proxy.AuditUndoSubmit(obj);
                            int amount = HelperObject_BGT_B_ADJUST_EXE.Update(obj, transaction);
                            //ƽ̨�Զ����ɴ���
                            PostUndoSubmit(obj, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            SystemLogic.Proxy.AuditState(obj, Ipedf.Common.����״̬.���ύ);
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }

        public int SaveByTrans(EntityObject_BGT_B_ADJUST_EXE obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditAdd(obj);
                int amount = HelperObject_BGT_B_ADJUST_EXE.Save(obj, transaction);
                //ƽ̨�Զ����ɴ���          
                return amount;
            }
            else
            {
                throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_BGT_B_ADJUST_EXE obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditEdit(obj);
                return HelperObject_BGT_B_ADJUST_EXE.Update(obj, transaction);
                //ƽ̨�Զ����ɴ���
            }
            else
            {
                throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_BGT_B_ADJUST_EXE obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
                return HelperObject_BGT_B_ADJUST_EXE.Delete(obj, transaction);
                //ƽ̨�Զ����ɴ���
            }
            else
            {
                throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_BGT_B_ADJUST_EXE cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
                return HelperObject_BGT_B_ADJUST_EXE.Delete(cause, transaction);
                //ƽ̨�Զ����ɴ���
            }
            else
            {
                throw new InvalidConstraintException();
            }
        }
        public EntityObject_BGT_B_ADJUST_EXE Load(string id, out EntityObject_COM_USER dept_user_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id)
        {
            if (LocalMode)
            {
                EntityObject_BGT_B_ADJUST_EXE obj = new EntityObject_BGT_B_ADJUST_EXE();

                //ƽ̨�Զ����ɴ���
                dept_user_id = new EntityObject_COM_USER();
                budget_year = new EntityObject_BGT_D_BUDGET_YEAR();
                budget_dept_id = new EntityObject_BGT_D_BUDGET_DEPT();

                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            obj = Load(transaction, id, out  dept_user_id, out  budget_year, out  budget_dept_id);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return obj;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Load(id, out dept_user_id, out budget_year, out budget_dept_id);
                }
            }
        }
        public EntityObject_BGT_B_ADJUST_EXE Load(IDbTransaction transaction, string id, out EntityObject_COM_USER dept_user_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id)
        {
            if (LocalMode)
            {
                EntityObject_BGT_B_ADJUST_EXE obj = new EntityObject_BGT_B_ADJUST_EXE();

                //ƽ̨�Զ����ɴ���
                dept_user_id = new EntityObject_COM_USER();
                budget_year = new EntityObject_BGT_D_BUDGET_YEAR();
                budget_dept_id = new EntityObject_BGT_D_BUDGET_DEPT();


                obj.ID = id;
                obj = HelperObject_BGT_B_ADJUST_EXE.Get(obj, transaction);
                if (!string.IsNullOrEmpty(obj.DEPT_USER_ID))
                {
                    dept_user_id.ID = obj.DEPT_USER_ID;
                    dept_user_id = HelperObject_COM_USER.Get(dept_user_id, transaction);
                }
                if (!string.IsNullOrEmpty(obj.BUDGET_YEAR))
                {
                    budget_year.ID = obj.BUDGET_YEAR;
                    budget_year = HelperObject_BGT_D_BUDGET_YEAR.Get(budget_year, transaction);
                }
                if (!string.IsNullOrEmpty(obj.BUDGET_DEPT_ID))
                {
                    budget_dept_id.ID = obj.BUDGET_DEPT_ID;
                    budget_dept_id = HelperObject_BGT_D_BUDGET_DEPT.Get(budget_dept_id, transaction);
                }
                return obj;
            }
            else
            {
                throw new InvalidConstraintException();
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_BGT_B_ADJUST_EXE[] saveEntities, EntityObject_BGT_B_ADJUST_EXE[] updateEntities, EntityObject_BGT_B_ADJUST_EXE[] deleteEntities)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_B_ADJUST_EXE obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_ADJUST_EXE.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_ADJUST_EXE obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_B_ADJUST_EXE.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_ADJUST_EXE obj in deleteEntities)
                            {
                                HelperObject_BGT_B_ADJUST_EXE.Delete(obj, transaction);
                            }
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
        #endregion
        #region Relation Blok
#if NESTING
        public BizLogicMsg CommitSave(EntityObject_BGT_B_ADJUST_EXE saveBaseEntity, EntityObject_BGT_B_ADJUST_EXE_D[] saveDetailEntities)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            SystemLogic.Proxy.AuditAdd(saveBaseEntity);
                            HelperObject_BGT_B_ADJUST_EXE.Save(saveBaseEntity, transaction);

                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_B_ADJUST_EXE_D obj in saveDetailEntities)
                            {
                                obj.BASE_ID = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_ADJUST_EXE_D.Save(obj, transaction);
                            }
                            PostSave(saveBaseEntity, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_BGT_B_ADJUST_EXE deleteBaseEntity)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            //ƽ̨�Զ����ɴ���
                            CauseObject_BGT_B_ADJUST_EXE_D p = new CauseObject_BGT_B_ADJUST_EXE_D();
                            p.BASE_ID = deleteBaseEntity.ID;
                            HelperObject_BGT_B_ADJUST_EXE_D.Delete(p, transaction);
                            HelperObject_BGT_B_ADJUST_EXE.Delete(deleteBaseEntity, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }

#endif
        #endregion
    }
}
