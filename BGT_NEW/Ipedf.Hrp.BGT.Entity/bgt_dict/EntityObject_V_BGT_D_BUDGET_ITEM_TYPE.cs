using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.Serialization;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_D_BUDGET_ITEM_TYPE")]
	public partial class CauseObject_V_BGT_D_BUDGET_ITEM_TYPE:CauseBase
	{
		#region Attribute Block
		
			//ƽ̨�Զ����ɴ���
		System.String _IMPORT_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  IMPORT_TYPE_ID{get{ return  _IMPORT_TYPE_ID;}set{ _IMPORT_TYPE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.String _BUDGET_YEAR = string.Empty;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String _ITEM_TYPE = string.Empty;
		[DataMember]
		public System.String  ITEM_TYPE{get{ return  _ITEM_TYPE;}set{ _ITEM_TYPE = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.Decimal _IS_END = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_END{get{ return  _IS_END;}set{ _IS_END = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _DATA_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_TYPE_ID{get{ return  _DATA_TYPE_ID;}set{ _DATA_TYPE_ID = value;}}
		System.String _PARENT_ID = string.Empty;
		[DataMember]
		public System.String  PARENT_ID{get{ return  _PARENT_ID;}set{ _PARENT_ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.Decimal _IS_MERGE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_MERGE{get{ return  _IS_MERGE;}set{ _IS_MERGE = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _TYPE_ID = string.Empty;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.Decimal _IS_CARRYOVER = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_CARRYOVER{get{ return  _IS_CARRYOVER;}set{ _IS_CARRYOVER = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _PREPARE_PATTERN_ID = string.Empty;
		[DataMember]
		public System.String  PREPARE_PATTERN_ID{get{ return  _PREPARE_PATTERN_ID;}set{ _PREPARE_PATTERN_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _USAGE_ID = string.Empty;
		[DataMember]
		public System.String  USAGE_ID{get{ return  _USAGE_ID;}set{ _USAGE_ID = value;}}
		System.String _ITEM_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_TYPE_ID{get{ return  _ITEM_TYPE_ID;}set{ _ITEM_TYPE_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_D_BUDGET_ITEM_TYPE")]
	public partial class DisplayObject_V_BGT_D_BUDGET_ITEM_TYPE:EntityObject_V_BGT_D_BUDGET_ITEM_TYPE
	{
		#region Attribute Block
		
			//ƽ̨�Զ����ɴ���

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_BGT_D_BUDGET_ITEM_TYPE")]
	public partial class EntityObject_V_BGT_D_BUDGET_ITEM_TYPE:EntityBase
	{
		#region Attribute Block
		
			//ƽ̨�Զ����ɴ���
		System.String  _IMPORT_TYPE_ID;
		[DataMember]
		public System.String  IMPORT_TYPE_ID{get{ return  _IMPORT_TYPE_ID;}set{ _IMPORT_TYPE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _TYPE_NAME;
		[DataMember]
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.String  _BUDGET_YEAR;
		[DataMember]
		public System.String  BUDGET_YEAR{get{ return  _BUDGET_YEAR;}set{ _BUDGET_YEAR = value;}}
		System.String  _ITEM_TYPE;
		[DataMember]
		public System.String  ITEM_TYPE{get{ return  _ITEM_TYPE;}set{ _ITEM_TYPE = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.Decimal  _IS_END;
		[DataMember]
		public System.Decimal  IS_END{get{ return  _IS_END;}set{ _IS_END = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _DATA_TYPE_ID;
		[DataMember]
		public System.String  DATA_TYPE_ID{get{ return  _DATA_TYPE_ID;}set{ _DATA_TYPE_ID = value;}}
		System.String  _PARENT_ID;
		[DataMember]
		public System.String  PARENT_ID{get{ return  _PARENT_ID;}set{ _PARENT_ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.Decimal  _IS_MERGE;
		[DataMember]
		public System.Decimal  IS_MERGE{get{ return  _IS_MERGE;}set{ _IS_MERGE = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _TYPE_ID;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.Decimal  _IS_CARRYOVER;
		[DataMember]
		public System.Decimal  IS_CARRYOVER{get{ return  _IS_CARRYOVER;}set{ _IS_CARRYOVER = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _PREPARE_PATTERN_ID;
		[DataMember]
		public System.String  PREPARE_PATTERN_ID{get{ return  _PREPARE_PATTERN_ID;}set{ _PREPARE_PATTERN_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _USAGE_ID;
		[DataMember]
		public System.String  USAGE_ID{get{ return  _USAGE_ID;}set{ _USAGE_ID = value;}}
		System.String  _ITEM_TYPE_ID;
		[DataMember]
		public System.String  ITEM_TYPE_ID{get{ return  _ITEM_TYPE_ID;}set{ _ITEM_TYPE_ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}	
}
