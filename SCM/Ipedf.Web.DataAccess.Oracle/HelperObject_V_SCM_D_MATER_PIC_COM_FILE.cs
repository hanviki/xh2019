using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.DataAccess
{
	[CauseObject(typeof(CauseObject_V_SCM_D_MATER_PIC_COM_FILE))]
	public partial class HelperObject_V_SCM_D_MATER_PIC_COM_FILE
	{		
		#region Method Blok
		public static int Save(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_SCM_D_MATER_PIC_COM_FILE( GYSACCOUNT, ID, GYSNAME, COMMENTS, MATNR, PRODUCE_AREA, STATE, CHARGE, SPEC, CREATE_TIME, SPELL_CODE, TXZ01, CLIENT_NAME, SERVER_NAME, MATER_ID) values ( :GYSACCOUNT, :ID, :GYSNAME, :COMMENTS, :MATNR, :PRODUCE_AREA, :STATE, :CHARGE, :SPEC, :CREATE_TIME, :SPELL_CODE, :TXZ01, :CLIENT_NAME, :SERVER_NAME, :MATER_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[15];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":GYSACCOUNT";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":GYSNAME";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.GYSNAME == null ? String.Empty:obj.GYSNAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":COMMENTS";
			parameters[3].Size = 1000;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":MATNR";
			parameters[4].Size = 20;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.MATNR == null ? String.Empty:obj.MATNR;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":PRODUCE_AREA";
			parameters[5].Size = 200;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.PRODUCE_AREA == null ? String.Empty:obj.PRODUCE_AREA;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":STATE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.STATE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CHARGE";
			parameters[7].Size = 10;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.CHARGE == null ? String.Empty:obj.CHARGE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":SPEC";
			parameters[8].Size = 200;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CREATE_TIME";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.CREATE_TIME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":SPELL_CODE";
			parameters[10].Size = 20;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.SPELL_CODE == null ? String.Empty:obj.SPELL_CODE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":TXZ01";
			parameters[11].Size = 200;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.TXZ01 == null ? String.Empty:obj.TXZ01;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":CLIENT_NAME";
			parameters[12].Size = 50;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.CLIENT_NAME == null ? String.Empty:obj.CLIENT_NAME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":SERVER_NAME";
			parameters[13].Size = 100;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.SERVER_NAME == null ? String.Empty:obj.SERVER_NAME;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":MATER_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.MATER_ID == null ? String.Empty:obj.MATER_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_SCM_D_MATER_PIC_COM_FILE set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj,CauseObject_V_SCM_D_MATER_PIC_COM_FILE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_SCM_D_MATER_PIC_COM_FILE set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_SCM_D_MATER_PIC_COM_FILE where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_SCM_D_MATER_PIC_COM_FILE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_SCM_D_MATER_PIC_COM_FILE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_SCM_D_MATER_PIC_COM_FILE Get(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  GYSACCOUNT, ID, GYSNAME, COMMENTS, MATNR, PRODUCE_AREA, STATE, CHARGE, SPEC, CREATE_TIME, SPELL_CODE, TXZ01, CLIENT_NAME, SERVER_NAME, MATER_ID from V_SCM_D_MATER_PIC_COM_FILE where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_MATER_PIC_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_MATER_PIC_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MATNR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHARGE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SPELL_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SERVER_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MATER_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_SCM_D_MATER_PIC_COM_FILE[] objs = new EntityObject_V_SCM_D_MATER_PIC_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_SCM_D_MATER_PIC_COM_FILE Get(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  GYSACCOUNT, ID, GYSNAME, COMMENTS, MATNR, PRODUCE_AREA, STATE, CHARGE, SPEC, CREATE_TIME, SPELL_CODE, TXZ01, CLIENT_NAME, SERVER_NAME, MATER_ID from V_SCM_D_MATER_PIC_COM_FILE where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_MATER_PIC_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_MATER_PIC_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MATNR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHARGE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SPELL_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SERVER_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MATER_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_SCM_D_MATER_PIC_COM_FILE[] objs = new EntityObject_V_SCM_D_MATER_PIC_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_SCM_D_MATER_PIC_COM_FILE.GYSACCOUNT, V_SCM_D_MATER_PIC_COM_FILE.ID, V_SCM_D_MATER_PIC_COM_FILE.GYSNAME, V_SCM_D_MATER_PIC_COM_FILE.COMMENTS, V_SCM_D_MATER_PIC_COM_FILE.MATNR, V_SCM_D_MATER_PIC_COM_FILE.PRODUCE_AREA, V_SCM_D_MATER_PIC_COM_FILE.STATE, V_SCM_D_MATER_PIC_COM_FILE.CHARGE, V_SCM_D_MATER_PIC_COM_FILE.SPEC, V_SCM_D_MATER_PIC_COM_FILE.CREATE_TIME, V_SCM_D_MATER_PIC_COM_FILE.SPELL_CODE, V_SCM_D_MATER_PIC_COM_FILE.TXZ01, V_SCM_D_MATER_PIC_COM_FILE.CLIENT_NAME, V_SCM_D_MATER_PIC_COM_FILE.SERVER_NAME, V_SCM_D_MATER_PIC_COM_FILE.MATER_ID from V_SCM_D_MATER_PIC_COM_FILE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_SCM_D_MATER_PIC_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_MATER_PIC_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MATNR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHARGE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SPELL_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SERVER_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MATER_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] objs = new DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_SCM_D_MATER_PIC_COM_FILE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":C_GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :C_MATNR");
				param = new OracleParameter();
				param.ParameterName =":C_MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "MATNR"));
			}
			if(!string.IsNullOrEmpty(cause.PRODUCE_AREA))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.PRODUCE_AREA ").Append((cause.PRODUCE_AREA.StartsWith("%") || cause.PRODUCE_AREA.EndsWith("%")) ? " like " : " = ").Append(" :C_PRODUCE_AREA");
				param = new OracleParameter();
				param.ParameterName =":C_PRODUCE_AREA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.PRODUCE_AREA;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRODUCE_AREA"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "PRODUCE_AREA"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.CHARGE))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.CHARGE ").Append((cause.CHARGE.StartsWith("%") || cause.CHARGE.EndsWith("%")) ? " like " : " = ").Append(" :C_CHARGE");
				param = new OracleParameter();
				param.ParameterName =":C_CHARGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.CHARGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHARGE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "CHARGE"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "SPEC"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.CREATE_TIME < :C_CREATE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.SPELL_CODE))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.SPELL_CODE ").Append((cause.SPELL_CODE.StartsWith("%") || cause.SPELL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.SPELL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPELL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "SPELL_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :C_TXZ01");
				param = new OracleParameter();
				param.ParameterName =":C_TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "TXZ01"));
			}
			if(!string.IsNullOrEmpty(cause.CLIENT_NAME))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.CLIENT_NAME ").Append((cause.CLIENT_NAME.StartsWith("%") || cause.CLIENT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_CLIENT_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_CLIENT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CLIENT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("CLIENT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "CLIENT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SERVER_NAME))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.SERVER_NAME ").Append((cause.SERVER_NAME.StartsWith("%") || cause.SERVER_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_SERVER_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_SERVER_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.SERVER_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SERVER_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "SERVER_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MATER_ID))
			{
				strBuf.Append(" And V_SCM_D_MATER_PIC_COM_FILE.MATER_ID ").Append((cause.MATER_ID.StartsWith("%") || cause.MATER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MATER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MATER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MATER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_PIC_COM_FILE", "MATER_ID"));
			}
			if (!string.IsNullOrEmpty(cause.GetCustomCondition())) 
			{ 
				strBuf.Append(cause.GetCustomCondition()); 
			} 
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return strBuf.ToString();


		}
		public static DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] Query(CauseObject_V_SCM_D_MATER_PIC_COM_FILE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_MATER_PIC_COM_FILE.GYSACCOUNT, V_SCM_D_MATER_PIC_COM_FILE.ID, V_SCM_D_MATER_PIC_COM_FILE.GYSNAME, V_SCM_D_MATER_PIC_COM_FILE.COMMENTS, V_SCM_D_MATER_PIC_COM_FILE.MATNR, V_SCM_D_MATER_PIC_COM_FILE.PRODUCE_AREA, V_SCM_D_MATER_PIC_COM_FILE.STATE, V_SCM_D_MATER_PIC_COM_FILE.CHARGE, V_SCM_D_MATER_PIC_COM_FILE.SPEC, V_SCM_D_MATER_PIC_COM_FILE.CREATE_TIME, V_SCM_D_MATER_PIC_COM_FILE.SPELL_CODE, V_SCM_D_MATER_PIC_COM_FILE.TXZ01, V_SCM_D_MATER_PIC_COM_FILE.CLIENT_NAME, V_SCM_D_MATER_PIC_COM_FILE.SERVER_NAME, V_SCM_D_MATER_PIC_COM_FILE.MATER_ID from V_SCM_D_MATER_PIC_COM_FILE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_MATER_PIC_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_MATER_PIC_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MATNR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHARGE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SPELL_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SERVER_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MATER_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] objs = new DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] Query(CauseObject_V_SCM_D_MATER_PIC_COM_FILE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_MATER_PIC_COM_FILE.GYSACCOUNT, V_SCM_D_MATER_PIC_COM_FILE.ID, V_SCM_D_MATER_PIC_COM_FILE.GYSNAME, V_SCM_D_MATER_PIC_COM_FILE.COMMENTS, V_SCM_D_MATER_PIC_COM_FILE.MATNR, V_SCM_D_MATER_PIC_COM_FILE.PRODUCE_AREA, V_SCM_D_MATER_PIC_COM_FILE.STATE, V_SCM_D_MATER_PIC_COM_FILE.CHARGE, V_SCM_D_MATER_PIC_COM_FILE.SPEC, V_SCM_D_MATER_PIC_COM_FILE.CREATE_TIME, V_SCM_D_MATER_PIC_COM_FILE.SPELL_CODE, V_SCM_D_MATER_PIC_COM_FILE.TXZ01, V_SCM_D_MATER_PIC_COM_FILE.CLIENT_NAME, V_SCM_D_MATER_PIC_COM_FILE.SERVER_NAME, V_SCM_D_MATER_PIC_COM_FILE.MATER_ID from V_SCM_D_MATER_PIC_COM_FILE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_MATER_PIC_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_MATER_PIC_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MATNR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHARGE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SPELL_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SERVER_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MATER_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] objs = new DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] Query(CauseObject_V_SCM_D_MATER_PIC_COM_FILE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_MATER_PIC_COM_FILE.GYSACCOUNT, V_SCM_D_MATER_PIC_COM_FILE.ID, V_SCM_D_MATER_PIC_COM_FILE.GYSNAME, V_SCM_D_MATER_PIC_COM_FILE.COMMENTS, V_SCM_D_MATER_PIC_COM_FILE.MATNR, V_SCM_D_MATER_PIC_COM_FILE.PRODUCE_AREA, V_SCM_D_MATER_PIC_COM_FILE.STATE, V_SCM_D_MATER_PIC_COM_FILE.CHARGE, V_SCM_D_MATER_PIC_COM_FILE.SPEC, V_SCM_D_MATER_PIC_COM_FILE.CREATE_TIME, V_SCM_D_MATER_PIC_COM_FILE.SPELL_CODE, V_SCM_D_MATER_PIC_COM_FILE.TXZ01, V_SCM_D_MATER_PIC_COM_FILE.CLIENT_NAME, V_SCM_D_MATER_PIC_COM_FILE.SERVER_NAME, V_SCM_D_MATER_PIC_COM_FILE.MATER_ID from V_SCM_D_MATER_PIC_COM_FILE where (1=1)";
			string sCauseSql = PrepareCause(cause,out parameters);
			sSql += sCauseSql;
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			if (paging != null)
			{
				string countSql = string.Empty;
				if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				else
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_MATER_PIC_COM_FILE",paging, order, sSql, parameters, connection);
			}
			else if (order != null)
			{
				sSql += order.ToString();
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
			}
			else
			{
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
			}
			DisplayObject_V_SCM_D_MATER_PIC_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_MATER_PIC_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MATNR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHARGE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SPELL_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SERVER_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MATER_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] objs = new DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] Query(CauseObject_V_SCM_D_MATER_PIC_COM_FILE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_MATER_PIC_COM_FILE.GYSACCOUNT, V_SCM_D_MATER_PIC_COM_FILE.ID, V_SCM_D_MATER_PIC_COM_FILE.GYSNAME, V_SCM_D_MATER_PIC_COM_FILE.COMMENTS, V_SCM_D_MATER_PIC_COM_FILE.MATNR, V_SCM_D_MATER_PIC_COM_FILE.PRODUCE_AREA, V_SCM_D_MATER_PIC_COM_FILE.STATE, V_SCM_D_MATER_PIC_COM_FILE.CHARGE, V_SCM_D_MATER_PIC_COM_FILE.SPEC, V_SCM_D_MATER_PIC_COM_FILE.CREATE_TIME, V_SCM_D_MATER_PIC_COM_FILE.SPELL_CODE, V_SCM_D_MATER_PIC_COM_FILE.TXZ01, V_SCM_D_MATER_PIC_COM_FILE.CLIENT_NAME, V_SCM_D_MATER_PIC_COM_FILE.SERVER_NAME, V_SCM_D_MATER_PIC_COM_FILE.MATER_ID from V_SCM_D_MATER_PIC_COM_FILE where (1=1)";
			string sCauseSql = PrepareCause(cause,out parameters);
			sSql += sCauseSql;
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			if (paging != null)
			{
				string countSql = string.Empty;
				if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				else
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_MATER_PIC_COM_FILE",paging, order, sSql, parameters, trans);
			}
			else if (order != null)
			{
				sSql += order.ToString();
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
			}
			else
			{
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
			}
			DisplayObject_V_SCM_D_MATER_PIC_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_MATER_PIC_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MATNR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHARGE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SPELL_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SERVER_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MATER_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] objs = new DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.GYSACCOUNT = :U_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.GYSNAME = :U_GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.MATNR = :U_MATNR");
				param = new OracleParameter();
				param.ParameterName = ":U_MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRODUCE_AREA"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.PRODUCE_AREA = :U_PRODUCE_AREA");
				param = new OracleParameter();
				param.ParameterName = ":U_PRODUCE_AREA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.PRODUCE_AREA) ? string.Empty : obj.PRODUCE_AREA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHARGE"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.CHARGE = :U_CHARGE");
				param = new OracleParameter();
				param.ParameterName = ":U_CHARGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.CHARGE) ? string.Empty : obj.CHARGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPELL_CODE"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.SPELL_CODE = :U_SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.SPELL_CODE) ? string.Empty : obj.SPELL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.TXZ01 = :U_TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":U_TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CLIENT_NAME"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.CLIENT_NAME = :U_CLIENT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_CLIENT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CLIENT_NAME) ? string.Empty : obj.CLIENT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SERVER_NAME"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.SERVER_NAME = :U_SERVER_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_SERVER_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.SERVER_NAME) ? string.Empty : obj.SERVER_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATER_ID"))
			{
				strBuf.Add("  V_SCM_D_MATER_PIC_COM_FILE.MATER_ID = :U_MATER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MATER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MATER_ID) ? string.Empty : obj.MATER_ID;
				paramList.Add(param);
			}
			//pk here
			if(appendpk)
			{
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
