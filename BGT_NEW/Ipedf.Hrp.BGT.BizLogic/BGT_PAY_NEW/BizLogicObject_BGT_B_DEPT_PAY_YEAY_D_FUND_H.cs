
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
	[CauseObject(typeof(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H))]
	public partial class BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H: BizLogicBase<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H>,ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H
	{	
		#region Proxy 
		public BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H() { }
        private static ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H singleton;
        public static ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj)
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
							int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj)
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
							int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj)
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
							int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H Get(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj)
		{
			if (LocalMode)
			{
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] List()
		{
			if (LocalMode)
			{
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] Query(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H cause)
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
							int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] Query(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] objs)
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
							foreach(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//ƽ̨�Զ����ɴ���
					foreach (EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj in objs)
					{
						amount += HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] objs)
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
							foreach(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//ƽ̨�Զ����ɴ���
					foreach (EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj in objs)
					{
						amount += HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] objs)
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
					foreach (EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj in objs)
					{
						amount += HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj)
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
							int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj)
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
							SystemLogic.Proxy.AuditAudit(obj);
							int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
							PostAudit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.����״̬.���ύ);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj)
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
							int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
							PostUndoAudit(obj, transaction);
							//ִ�г��ز���
							msg = SystemLogic.Proxy.BillUndoAudit(obj, transaction);
							if (!msg.Succeed) throw new Exception(msg.Message);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.����״̬.�����);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj)
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
							int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
							PostArchive(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.����״̬.�����);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj)
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
							int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
							PostSubmit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.����״̬.�༭��);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj)
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
							int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
							PostUndoSubmit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.����״̬.���ύ);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Save(obj, transaction);
					//ƽ̨�Զ����ɴ���          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Delete(obj, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Delete(cause, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H Load(string id , out EntityObject_COM_TYPE step_id)
		{
			if (LocalMode)
			{
				EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H();
				
			//ƽ̨�Զ����ɴ���
			step_id = new EntityObject_COM_TYPE() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  step_id);                
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.Load(id , out step_id);
                }
			}
		}
		public EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H Load(IDbTransaction transaction,string id , out EntityObject_COM_TYPE step_id)
		{
			if (LocalMode)
			{
				EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H();
				
			//ƽ̨�Զ����ɴ���
			step_id = new EntityObject_COM_TYPE() ; 
     
				
						obj.ID= id;
						obj = HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.STEP_ID))
						{
							step_id.ID = obj.STEP_ID;
							step_id = HelperObject_COM_TYPE.Get(step_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] saveEntities, EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] updateEntities, EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] deleteEntities)
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
                            foreach (EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj in deleteEntities)
                            {
                                HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Save(saveBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_.Save(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H deleteBaseEntity)
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
                            CauseObject_ p = new CauseObject_();
                            p. = deleteBaseEntity.ID;
                            HelperObject_.Delete(p, transaction);
                            HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            SystemLogic.Proxy.AuditEdit(updateBaseEntity);
                            HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H.Update(updateBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_.Save(obj, transaction);
                            }
                            foreach (EntityObject_ obj in updateDetailEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_.Update(obj, transaction);
                            }
                            foreach (EntityObject_ obj in deleteDetailEntities)
                            {
                                HelperObject_.Delete(obj, transaction);
                            }
                            PostSave(updateBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
