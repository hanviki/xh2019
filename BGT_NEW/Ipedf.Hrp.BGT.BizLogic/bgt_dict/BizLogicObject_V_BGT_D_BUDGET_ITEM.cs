
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
	[CauseObject(typeof(CauseObject_V_BGT_D_BUDGET_ITEM))]
	public partial class BizLogicObject_V_BGT_D_BUDGET_ITEM: BizLogicBase<EntityObject_V_BGT_D_BUDGET_ITEM>,ServiceContract_V_BGT_D_BUDGET_ITEM
	{	
		#region Proxy 
		public BizLogicObject_V_BGT_D_BUDGET_ITEM() { }
        private static ServiceContract_V_BGT_D_BUDGET_ITEM singleton;
        public static ServiceContract_V_BGT_D_BUDGET_ITEM Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_BGT_D_BUDGET_ITEM();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_V_BGT_D_BUDGET_ITEM obj)
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
							int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_V_BGT_D_BUDGET_ITEM obj)
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
							int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_V_BGT_D_BUDGET_ITEM obj)
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
							int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_V_BGT_D_BUDGET_ITEM Get(EntityObject_V_BGT_D_BUDGET_ITEM obj)
		{
			if (LocalMode)
			{
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_V_BGT_D_BUDGET_ITEM.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_V_BGT_D_BUDGET_ITEM[] List()
		{
			if (LocalMode)
			{
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_V_BGT_D_BUDGET_ITEM.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_V_BGT_D_BUDGET_ITEM[] Query(CauseObject_V_BGT_D_BUDGET_ITEM cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_V_BGT_D_BUDGET_ITEM.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_V_BGT_D_BUDGET_ITEM cause)
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
							int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_V_BGT_D_BUDGET_ITEM[] Query(CauseObject_V_BGT_D_BUDGET_ITEM cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_V_BGT_D_BUDGET_ITEM.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_V_BGT_D_BUDGET_ITEM[] objs)
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
							foreach(EntityObject_V_BGT_D_BUDGET_ITEM obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//ƽ̨�Զ����ɴ���
					foreach (EntityObject_V_BGT_D_BUDGET_ITEM obj in objs)
					{
						amount += HelperObject_V_BGT_D_BUDGET_ITEM.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_V_BGT_D_BUDGET_ITEM[] objs)
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
							foreach(EntityObject_V_BGT_D_BUDGET_ITEM obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//ƽ̨�Զ����ɴ���
					foreach (EntityObject_V_BGT_D_BUDGET_ITEM obj in objs)
					{
						amount += HelperObject_V_BGT_D_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_V_BGT_D_BUDGET_ITEM[] objs)
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
					foreach (EntityObject_V_BGT_D_BUDGET_ITEM obj in objs)
					{
						amount += HelperObject_V_BGT_D_BUDGET_ITEM.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_V_BGT_D_BUDGET_ITEM obj)
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
							int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_V_BGT_D_BUDGET_ITEM obj)
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
							int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_V_BGT_D_BUDGET_ITEM obj)
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
							int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_V_BGT_D_BUDGET_ITEM obj)
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
							int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_V_BGT_D_BUDGET_ITEM obj)
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
							int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_V_BGT_D_BUDGET_ITEM obj)
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
							int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_V_BGT_D_BUDGET_ITEM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_V_BGT_D_BUDGET_ITEM.Save(obj, transaction);
					//ƽ̨�Զ����ɴ���          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_V_BGT_D_BUDGET_ITEM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_V_BGT_D_BUDGET_ITEM.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_V_BGT_D_BUDGET_ITEM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_V_BGT_D_BUDGET_ITEM.Delete(obj, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_V_BGT_D_BUDGET_ITEM cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_V_BGT_D_BUDGET_ITEM.Delete(cause, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_V_BGT_D_BUDGET_ITEM Load(string id )
		{
			if (LocalMode)
			{
				EntityObject_V_BGT_D_BUDGET_ITEM obj = new EntityObject_V_BGT_D_BUDGET_ITEM();
				
			//ƽ̨�Զ����ɴ���

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id );                
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
				using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Load(id );
                }
			}
		}
		public EntityObject_V_BGT_D_BUDGET_ITEM Load(IDbTransaction transaction,string id )
		{
			if (LocalMode)
			{
				EntityObject_V_BGT_D_BUDGET_ITEM obj = new EntityObject_V_BGT_D_BUDGET_ITEM();
				
			//ƽ̨�Զ����ɴ���
     
				  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_V_BGT_D_BUDGET_ITEM[] saveEntities, EntityObject_V_BGT_D_BUDGET_ITEM[] updateEntities, EntityObject_V_BGT_D_BUDGET_ITEM[] deleteEntities)
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
                            foreach (EntityObject_V_BGT_D_BUDGET_ITEM obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_V_BGT_D_BUDGET_ITEM.Save(obj, transaction);
                            }
                            foreach (EntityObject_V_BGT_D_BUDGET_ITEM obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_V_BGT_D_BUDGET_ITEM.Update(obj, transaction);
                            }
                            foreach (EntityObject_V_BGT_D_BUDGET_ITEM obj in deleteEntities)
                            {
                                HelperObject_V_BGT_D_BUDGET_ITEM.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_V_BGT_D_BUDGET_ITEM saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_V_BGT_D_BUDGET_ITEM.Save(saveBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = saveBaseEntity.COMMENTS_NAME;
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
                using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_V_BGT_D_BUDGET_ITEM deleteBaseEntity)
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
                            p. = deleteBaseEntity.COMMENTS_NAME;
                            HelperObject_.Delete(p, transaction);
                            HelperObject_V_BGT_D_BUDGET_ITEM.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_V_BGT_D_BUDGET_ITEM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            HelperObject_V_BGT_D_BUDGET_ITEM.Update(updateBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = updateBaseEntity.COMMENTS_NAME;
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
                using (ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_V_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
