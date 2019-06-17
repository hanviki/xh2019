
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
	[CauseObject(typeof(CauseObject_SCM_B_QUOTEDPRICE_D))]
	public partial class BizLogicObject_SCM_B_QUOTEDPRICE_D: BizLogicBase<EntityObject_SCM_B_QUOTEDPRICE_D>,ServiceContract_SCM_B_QUOTEDPRICE_D
	{	
		#region Proxy 
		public BizLogicObject_SCM_B_QUOTEDPRICE_D() { }
        private static ServiceContract_SCM_B_QUOTEDPRICE_D singleton;
        public static ServiceContract_SCM_B_QUOTEDPRICE_D Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_SCM_B_QUOTEDPRICE_D();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_SCM_B_QUOTEDPRICE_D obj)
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
							int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_SCM_B_QUOTEDPRICE_D obj)
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
							int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_SCM_B_QUOTEDPRICE_D obj)
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
							int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_SCM_B_QUOTEDPRICE_D Get(EntityObject_SCM_B_QUOTEDPRICE_D obj)
		{
			if (LocalMode)
			{
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_SCM_B_QUOTEDPRICE_D.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_SCM_B_QUOTEDPRICE_D[] List()
		{
			if (LocalMode)
			{
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_SCM_B_QUOTEDPRICE_D.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_SCM_B_QUOTEDPRICE_D[] Query(CauseObject_SCM_B_QUOTEDPRICE_D cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_SCM_B_QUOTEDPRICE_D.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_SCM_B_QUOTEDPRICE_D cause)
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
							int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_SCM_B_QUOTEDPRICE_D[] Query(CauseObject_SCM_B_QUOTEDPRICE_D cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_SCM_B_QUOTEDPRICE_D.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_SCM_B_QUOTEDPRICE_D[] objs)
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
							foreach(EntityObject_SCM_B_QUOTEDPRICE_D obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//ƽ̨�Զ����ɴ���
					foreach (EntityObject_SCM_B_QUOTEDPRICE_D obj in objs)
					{
						amount += HelperObject_SCM_B_QUOTEDPRICE_D.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_SCM_B_QUOTEDPRICE_D[] objs)
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
							foreach(EntityObject_SCM_B_QUOTEDPRICE_D obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//ƽ̨�Զ����ɴ���
					foreach (EntityObject_SCM_B_QUOTEDPRICE_D obj in objs)
					{
						amount += HelperObject_SCM_B_QUOTEDPRICE_D.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_SCM_B_QUOTEDPRICE_D[] objs)
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
					foreach (EntityObject_SCM_B_QUOTEDPRICE_D obj in objs)
					{
						amount += HelperObject_SCM_B_QUOTEDPRICE_D.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_SCM_B_QUOTEDPRICE_D obj)
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
							int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_SCM_B_QUOTEDPRICE_D obj)
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
							int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_SCM_B_QUOTEDPRICE_D obj)
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
							int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_SCM_B_QUOTEDPRICE_D obj)
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
							int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_SCM_B_QUOTEDPRICE_D obj)
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
							int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_SCM_B_QUOTEDPRICE_D obj)
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
							int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_SCM_B_QUOTEDPRICE_D obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_SCM_B_QUOTEDPRICE_D.Save(obj, transaction);
					//ƽ̨�Զ����ɴ���          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_SCM_B_QUOTEDPRICE_D obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_SCM_B_QUOTEDPRICE_D.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_SCM_B_QUOTEDPRICE_D obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_SCM_B_QUOTEDPRICE_D.Delete(obj, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_SCM_B_QUOTEDPRICE_D cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_SCM_B_QUOTEDPRICE_D.Delete(cause, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_SCM_B_QUOTEDPRICE_D Load(string id , out EntityObject_COM_FILE com_file_id)
		{
			if (LocalMode)
			{
				EntityObject_SCM_B_QUOTEDPRICE_D obj = new EntityObject_SCM_B_QUOTEDPRICE_D();
				
			//ƽ̨�Զ����ɴ���
			com_file_id = new EntityObject_COM_FILE() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  com_file_id);                
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
				using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.Load(id , out com_file_id);
                }
			}
		}
		public EntityObject_SCM_B_QUOTEDPRICE_D Load(IDbTransaction transaction,string id , out EntityObject_COM_FILE com_file_id)
		{
			if (LocalMode)
			{
				EntityObject_SCM_B_QUOTEDPRICE_D obj = new EntityObject_SCM_B_QUOTEDPRICE_D();
				
			//ƽ̨�Զ����ɴ���
			com_file_id = new EntityObject_COM_FILE() ; 
     
				
						if (!string.IsNullOrEmpty(obj.COM_FILE_ID))
						{
							com_file_id.ID = obj.COM_FILE_ID;
							com_file_id = HelperObject_COM_FILE.Get(com_file_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_SCM_B_QUOTEDPRICE_D[] saveEntities, EntityObject_SCM_B_QUOTEDPRICE_D[] updateEntities, EntityObject_SCM_B_QUOTEDPRICE_D[] deleteEntities)
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
                            foreach (EntityObject_SCM_B_QUOTEDPRICE_D obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_SCM_B_QUOTEDPRICE_D.Save(obj, transaction);
                            }
                            foreach (EntityObject_SCM_B_QUOTEDPRICE_D obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_SCM_B_QUOTEDPRICE_D.Update(obj, transaction);
                            }
                            foreach (EntityObject_SCM_B_QUOTEDPRICE_D obj in deleteEntities)
                            {
                                HelperObject_SCM_B_QUOTEDPRICE_D.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_SCM_B_QUOTEDPRICE_D saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_SCM_B_QUOTEDPRICE_D.Save(saveBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = saveBaseEntity.COMMENTS_D;
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
                using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_SCM_B_QUOTEDPRICE_D deleteBaseEntity)
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
                            p. = deleteBaseEntity.COMMENTS_D;
                            HelperObject_.Delete(p, transaction);
                            HelperObject_SCM_B_QUOTEDPRICE_D.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_SCM_B_QUOTEDPRICE_D updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            HelperObject_SCM_B_QUOTEDPRICE_D.Update(updateBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = updateBaseEntity.COMMENTS_D;
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
                using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE_D>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}