﻿using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections.Generic;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Hrp.Hem.Sap.Entity;

namespace Ipedf.Hrp.Hem.Sap.DataAccess
{
    [CauseObject(typeof(CauseObject_SYS_DATA_TYPE))]
    public partial class HelperObject_SYS_DATA_TYPE
    {
        #region Method Blok
        public static int Save(EntityObject_SYS_DATA_TYPE obj, IDbTransaction trans)
        {

            //平台自动生成代码
            obj.ID = Guid.NewGuid().ToString();
            string sSql = "insert into SYS_DATA_TYPE( IS_USABL, PARENT_ID, NAME, ID, CODE) values ( :IS_USABL, :PARENT_ID, :NAME, :ID, :CODE)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[5];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":IS_USABL";
            parameters[0].Size = 22;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[0].Value = obj.IS_USABL;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":PARENT_ID";
            parameters[1].Size = 36;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[1].Value = obj.PARENT_ID == null ? String.Empty : obj.PARENT_ID;
            parameters[2] = new OracleParameter();
            parameters[2].ParameterName = ":NAME";
            parameters[2].Size = 50;
            parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[2].Value = obj.NAME == null ? String.Empty : obj.NAME;
            parameters[3] = new OracleParameter();
            parameters[3].ParameterName = ":ID";
            parameters[3].Size = 36;
            parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[3].Value = obj.ID == null ? String.Empty : obj.ID;
            parameters[4] = new OracleParameter();
            parameters[4].ParameterName = ":CODE";
            parameters[4].Size = 50;
            parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[4].Value = obj.CODE == null ? String.Empty : obj.CODE;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int Update(EntityObject_SYS_DATA_TYPE obj, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "update SYS_DATA_TYPE set ";
            sSql += PrepareUpdate(obj, out parameters);
            sSql += " where  ID = :ID ";
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int Delete(EntityObject_SYS_DATA_TYPE obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "delete from SYS_DATA_TYPE where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static EntityObject_SYS_DATA_TYPE Get(EntityObject_SYS_DATA_TYPE obj)
        {

            //平台自动生成代码
            string sSql = "select  IS_USABL, PARENT_ID, NAME, ID, CODE from SYS_DATA_TYPE where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            #region Push Block
            EntityObject_SYS_DATA_TYPE dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_SYS_DATA_TYPE();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.PARENT_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.NAME = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            EntityObject_SYS_DATA_TYPE[] objs = new EntityObject_SYS_DATA_TYPE[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static EntityObject_SYS_DATA_TYPE Get(EntityObject_SYS_DATA_TYPE obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "select  IS_USABL, PARENT_ID, NAME, ID, CODE from SYS_DATA_TYPE where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            #region Push Block
            EntityObject_SYS_DATA_TYPE dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_SYS_DATA_TYPE();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.PARENT_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.NAME = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            EntityObject_SYS_DATA_TYPE[] objs = new EntityObject_SYS_DATA_TYPE[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static DisplayObject_SYS_DATA_TYPE[] List()
        {

            //平台自动生成代码
            string sSql = " select  SYS_DATA_TYPE.IS_USABL, SYS_DATA_TYPE.PARENT_ID, SYS_DATA_TYPE.NAME, SYS_DATA_TYPE.ID, SYS_DATA_TYPE.CODE from SYS_DATA_TYPE where (1=1)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[0];
            #endregion
            #region Push Block
            DisplayObject_SYS_DATA_TYPE dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SYS_DATA_TYPE();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.PARENT_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.NAME = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SYS_DATA_TYPE[] objs = new DisplayObject_SYS_DATA_TYPE[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string PrepareCause(CauseObject_SYS_DATA_TYPE cause, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
            if (cause.IS_USABL != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And SYS_DATA_TYPE.IS_USABL = :IS_USABL");
                param = new OracleParameter();
                param.ParameterName = ":IS_USABL";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.IS_USABL;
                paramList.Add(param);
            }
            if (cause.HasINValue("IS_USABL"))
            {
                strBuf.Append(cause.GetINSQL("SYS_DATA_TYPE", "IS_USABL"));
            }
            if (!string.IsNullOrEmpty(cause.PARENT_ID))
            {
                strBuf.Append(" And SYS_DATA_TYPE.PARENT_ID ").Append((cause.PARENT_ID.StartsWith("%") || cause.PARENT_ID.EndsWith("%")) ? " like " : " = ").Append(" :PARENT_ID");
                param = new OracleParameter();
                param.ParameterName = ":PARENT_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.PARENT_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("PARENT_ID"))
            {
                strBuf.Append(cause.GetINSQL("SYS_DATA_TYPE", "PARENT_ID"));
            }
            if (!string.IsNullOrEmpty(cause.NAME))
            {
                strBuf.Append(" And SYS_DATA_TYPE.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
                param = new OracleParameter();
                param.ParameterName = ":NAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.NAME;
                paramList.Add(param);
            }
            if (cause.HasINValue("NAME"))
            {
                strBuf.Append(cause.GetINSQL("SYS_DATA_TYPE", "NAME"));
            }
            if (!string.IsNullOrEmpty(cause.ID))
            {
                strBuf.Append(" And SYS_DATA_TYPE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
                param = new OracleParameter();
                param.ParameterName = ":ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("ID"))
            {
                strBuf.Append(cause.GetINSQL("SYS_DATA_TYPE", "ID"));
            }
            if (!string.IsNullOrEmpty(cause.CODE))
            {
                strBuf.Append(" And SYS_DATA_TYPE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
                param = new OracleParameter();
                param.ParameterName = ":CODE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.CODE;
                paramList.Add(param);
            }
            if (cause.HasINValue("CODE"))
            {
                strBuf.Append(cause.GetINSQL("SYS_DATA_TYPE", "CODE"));
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
        public static DisplayObject_SYS_DATA_TYPE[] Query(CauseObject_SYS_DATA_TYPE cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  SYS_DATA_TYPE.IS_USABL, SYS_DATA_TYPE.PARENT_ID, SYS_DATA_TYPE.NAME, SYS_DATA_TYPE.ID, SYS_DATA_TYPE.CODE from SYS_DATA_TYPE where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_SYS_DATA_TYPE dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SYS_DATA_TYPE();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.PARENT_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.NAME = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SYS_DATA_TYPE[] objs = new DisplayObject_SYS_DATA_TYPE[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static int Delete(CauseObject_SYS_DATA_TYPE cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "delete from SYS_DATA_TYPE where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static DisplayObject_SYS_DATA_TYPE[] Query(CauseObject_SYS_DATA_TYPE cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  SYS_DATA_TYPE.IS_USABL, SYS_DATA_TYPE.PARENT_ID, SYS_DATA_TYPE.NAME, SYS_DATA_TYPE.ID, SYS_DATA_TYPE.CODE from SYS_DATA_TYPE where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_SYS_DATA_TYPE dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SYS_DATA_TYPE();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.PARENT_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.NAME = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_SYS_DATA_TYPE[] objs = new DisplayObject_SYS_DATA_TYPE[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SYS_DATA_TYPE[] Query(CauseObject_SYS_DATA_TYPE cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  SYS_DATA_TYPE.IS_USABL, SYS_DATA_TYPE.PARENT_ID, SYS_DATA_TYPE.NAME, SYS_DATA_TYPE.ID, SYS_DATA_TYPE.CODE from SYS_DATA_TYPE where (1=1)";
            string sCauseSql = PrepareCause(cause, out parameters);
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("SYS_DATA_TYPE", paging, order, sSql, parameters, connection);
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
            DisplayObject_SYS_DATA_TYPE dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SYS_DATA_TYPE();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.PARENT_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.NAME = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SYS_DATA_TYPE[] objs = new DisplayObject_SYS_DATA_TYPE[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SYS_DATA_TYPE[] Query(CauseObject_SYS_DATA_TYPE cause, PagingParamter paging, OrderByParameter order, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  SYS_DATA_TYPE.IS_USABL, SYS_DATA_TYPE.PARENT_ID, SYS_DATA_TYPE.NAME, SYS_DATA_TYPE.ID, SYS_DATA_TYPE.CODE from SYS_DATA_TYPE where (1=1)";
            string sCauseSql = PrepareCause(cause, out parameters);
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
                    paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2 ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
                }
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("SYS_DATA_TYPE", paging, order, sSql, parameters, trans);
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
            DisplayObject_SYS_DATA_TYPE dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SYS_DATA_TYPE();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.PARENT_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.NAME = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_SYS_DATA_TYPE[] objs = new DisplayObject_SYS_DATA_TYPE[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string PrepareUpdate(EntityObject_SYS_DATA_TYPE obj, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            List<string> strBuf = new List<string>();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
            if (!obj.IsNotUpdate("IS_USABL"))
            {
                strBuf.Add("  SYS_DATA_TYPE.IS_USABL = :IS_USABL");
                param = new OracleParameter();
                param.ParameterName = ":IS_USABL";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.IS_USABL;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("PARENT_ID"))
            {
                strBuf.Add("  SYS_DATA_TYPE.PARENT_ID = :PARENT_ID");
                param = new OracleParameter();
                param.ParameterName = ":PARENT_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.PARENT_ID) ? string.Empty : obj.PARENT_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("NAME"))
            {
                strBuf.Add("  SYS_DATA_TYPE.NAME = :NAME");
                param = new OracleParameter();
                param.ParameterName = ":NAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("CODE"))
            {
                strBuf.Add("  SYS_DATA_TYPE.CODE = :CODE");
                param = new OracleParameter();
                param.ParameterName = ":CODE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
                paramList.Add(param);
            }
            //pk here
            param = new OracleParameter();
            param.ParameterName = ":ID";
            param.OracleType = System.Data.OracleClient.OracleType.Char;
            param.Size = 36;
            param.Value = obj.ID;
            paramList.Add(param);
            #endregion
            parameters = new OracleParameter[paramList.Count];
            paramList.CopyTo(parameters);
            return string.Join(", ", strBuf.ToArray());

        }
        #endregion
    }
}
