using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using Ipedf.Core;
using Ipedf.Web.Control;
using Ipedf.Web.BizLogic;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_CPN_INC_PROJECT : ComNestingEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {

        }
        protected override object PrepareDetailDataSource()
        {
            object dataSource = null;

            //ƽ̨�Զ����ɴ���
            CauseObject_BGT_B_CPN_INC_PROJECT_D cause = new CauseObject_BGT_B_CPN_INC_PROJECT_D();
            if (ViewState["CUR_OBJ"] != null)
                cause.BASE_ID = (ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT).ID;
            dataSource = BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.Query(cause);
            System.Collections.Generic.List<DisplayObject_BGT_B_CPN_INC_PROJECT_D> list = new System.Collections.Generic.List<DisplayObject_BGT_B_CPN_INC_PROJECT_D>();
            list.AddRange((DisplayObject_BGT_B_CPN_INC_PROJECT_D[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_CPN_INC_PROJECT_D>(5));
            dataSource = list.ToArray();
            return dataSource;
        }
        protected override void PrepareDetailInput()
        {
            this.gvDetailList.DataKeyNames = PrepareDetailGridKeyNames();
            this.gvDetailList.DataSource = CreateEmptyDataSource(typeof(DisplayObject_BGT_B_CPN_INC_PROJECT_D), NewInputRowCount);
            this.gvDetailList.DataBind();
        }
        protected override void PrepareBaseInput()
        {

            //ƽ̨�Զ����ɴ���
            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)Ipedf.Common.�Ƿ�״̬.��;
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", p);

            this.txtInputDECALRE_CAUSE.Text = string.Empty;

            this.txtInputTotalMONEY.Text = "0.00";

        }
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                List<EntityObject_BGT_B_CPN_INC_PROJECT_D> saveDetailEntities = new List<EntityObject_BGT_B_CPN_INC_PROJECT_D>();
                EntityObject_BGT_B_CPN_INC_PROJECT baseEntity = new EntityObject_BGT_B_CPN_INC_PROJECT();

                //ƽ̨�Զ����ɴ���
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
               
                baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
                baseEntity.NAME = txtInputNAME.Text;
               
                if (!string.IsNullOrEmpty(txtInputTotalMONEY.Text))
                    baseEntity.MONEY = decimal.Parse(txtInputTotalMONEY.Text);
                else
                    baseEntity.MONEY = 0;
                
                //AuditAdd(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                    
                        ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");
                        ComTextBox txtInputBASE_ID = (ComTextBox)row.FindControl("txtInputBASE_ID");
                        ComTextBox txtInputITEM_NAME = (ComTextBox)row.FindControl("txtInputITEM_NAME");
                        ComTextBox txtInputDECALRE_CAUSE_ = (ComTextBox)row.FindControl("txtInputDECALRE_CAUSE");
                        //ƽ̨�Զ����ɴ���
                        EntityObject_BGT_B_CPN_INC_PROJECT_D detailEntity = new EntityObject_BGT_B_CPN_INC_PROJECT_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //ƽ̨�Զ����ɴ���
                            if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                            else
                                detailEntity.MONEY = 0;
                            detailEntity.ITEM_NAME = txtInputITEM_NAME.Text;
                            detailEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE_.Text;
                            //AuditAdd(detailEntity);
                            saveDetailEntities.Add(detailEntity);
                        }
                    }
                }
                try
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ViewState["CUR_OBJ"] = baseEntity;
                    this.txtInputTotalMONEY.Text = baseEntity.MONEY.ToString();
                    PrepareDetailDataSourceControl(baseEntity.ID);
                    ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
                }
                catch (Exception expt)
                {
                    throw expt;
                }

            }
            else
            {
                List<EntityObject_BGT_B_CPN_INC_PROJECT_D> saveDetailEntities = new List<EntityObject_BGT_B_CPN_INC_PROJECT_D>();
                List<EntityObject_BGT_B_CPN_INC_PROJECT_D> updateDetailEntities = new List<EntityObject_BGT_B_CPN_INC_PROJECT_D>();
                List<EntityObject_BGT_B_CPN_INC_PROJECT_D> deleteDetailEntities = new List<EntityObject_BGT_B_CPN_INC_PROJECT_D>();
                EntityObject_BGT_B_CPN_INC_PROJECT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT;

                //ƽ̨�Զ����ɴ���
                if (!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.SelectedValue))
                    baseEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.SelectedValue;
               
                baseEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
                baseEntity.NAME = txtInputNAME.Text;
                
                if (!string.IsNullOrEmpty(txtInputTotalMONEY.Text))
                    baseEntity.MONEY = decimal.Parse(txtInputTotalMONEY.Text);
                else
                    baseEntity.MONEY = 0;
                
                //AuditEdit(baseEntity);
                foreach (GridViewRow row in gvDetailList.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox select = (CheckBox)row.FindControl("cbSelect");

                      
                        ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");
                       
                        ComTextBox txtInputITEM_NAME = (ComTextBox)row.FindControl("txtInputITEM_NAME");
                        ComTextBox txtInputDECALRE_CAUSE_ = (ComTextBox)row.FindControl("txtInputDECALRE_CAUSE");
                        //ƽ̨�Զ����ɴ���
                        EntityObject_BGT_B_CPN_INC_PROJECT_D detailEntity = new EntityObject_BGT_B_CPN_INC_PROJECT_D();

                        detailEntity.BASE_ID = baseEntity.ID;

                        detailEntity.ID = gvDetailList.DataKeys[row.RowIndex].Value.ToString();
                        if (select.Checked)
                        {

                            //ƽ̨�Զ����ɴ���
                          
                            if (!string.IsNullOrEmpty(txtInputMONEY.Text))
                                detailEntity.MONEY = decimal.Parse(txtInputMONEY.Text);
                            else
                                detailEntity.MONEY = 0;
                          
                            detailEntity.ITEM_NAME = txtInputITEM_NAME.Text;
                            detailEntity.DECALRE_CAUSE = txtInputDECALRE_CAUSE_.Text;
                            if (detailEntity.ID == string.Empty)
                            {
                                //AuditAdd(detailEntity);
                                saveDetailEntities.Add(detailEntity);
                            }
                            else
                            {
                                //AuditEdit(detailEntity);
                                updateDetailEntities.Add(detailEntity);
                            }
                        }
                        else
                        {
                            if (IsDeleteAble)
                            {
                                deleteDetailEntities.Add(detailEntity);
                            }
                        }
                    }
                }
                try
                {
                    BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                    ShowEditState(baseEntity);
                    this.txtInputTotalMONEY.Text = baseEntity.MONEY.ToString();
                    PrepareDetailDataSourceControl(baseEntity.ID);
                    ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
                }
                catch (Exception expt)
                {
                    throw expt;
                }

            }
            ShowDetailData();
            SetPageState(PageState.Edit);
        }
        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_B_CPN_INC_PROJECT_D entity = (EntityObject_BGT_B_CPN_INC_PROJECT_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;

              
                ComTextBox txtInputMONEY = (ComTextBox)e.Row.FindControl("txtInputMONEY");
                txtInputMONEY.Text = entity.MONEY == null ? "0" : entity.MONEY.ToString();
             
               
                ComTextBox txtInputITEM_NAME = (ComTextBox)e.Row.FindControl("txtInputITEM_NAME");
                txtInputITEM_NAME.Text = entity.ITEM_NAME == null ? String.Empty : entity.ITEM_NAME.ToString();
                ComTextBox txtInputDECALRE_CAUSE = (ComTextBox)e.Row.FindControl("txtInputDECALRE_CAUSE");
                txtInputDECALRE_CAUSE.Text = entity.DECALRE_CAUSE == null ? String.Empty : entity.DECALRE_CAUSE.ToString();
                RegisterSelectedScript(txtInputMONEY, select);
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_B_CPN_INC_PROJECT cause = new CauseObject_BGT_B_CPN_INC_PROJECT();
            return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_CPN_INC_PROJECT>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_CPN_INC_PROJECT_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;

            //ƽ̨�Զ����ɴ���
            CauseObject_BGT_B_CPN_INC_PROJECT cause = (CauseObject_BGT_B_CPN_INC_PROJECT)parameter;
            dataSource = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }
        protected override void PrepareBaseEdit(string id)
        {

            //ƽ̨�Զ����ɴ���
            EntityObject_BGT_B_CPN_INC_PROJECT baseEntity = new EntityObject_BGT_B_CPN_INC_PROJECT();
            baseEntity.ID = id;
            baseEntity = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.Get(baseEntity);

            SetForeignKeySelected(this.ddlInputBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), baseEntity.BUDGET_YEAR, "ID", "BUDGET_YEAR");

            this.txtInputDECALRE_CAUSE.Text = baseEntity.DECALRE_CAUSE == null ? string.Empty : baseEntity.DECALRE_CAUSE.ToString();
            this.txtInputNAME.Text = baseEntity.NAME == null ? string.Empty : baseEntity.NAME.ToString();

            this.txtInputTotalMONEY.Text = baseEntity.MONEY == null ? string.Empty : baseEntity.MONEY.ToString();

            ShowEditState(baseEntity);
            ViewState["CUR_OBJ"] = baseEntity;
            PrepareDetailDataSourceControl(id);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }

        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_PROJECT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.Submit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_PROJECT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.UndoSubmit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_PROJECT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.UndoAudit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_PROJECT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.Audit(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_PROJECT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.Cancel(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }

        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_PROJECT baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT;
            if (baseEntity != null)
            {
                baseEntity.SetUpdate("STATE");
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.Archive(baseEntity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_CPN_INC_PROJECT> deleteDetailEntities = new List<EntityObject_BGT_B_CPN_INC_PROJECT>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_CPN_INC_PROJECT entity = new EntityObject_BGT_B_CPN_INC_PROJECT();
                    entity.ID = gvResultList.DataKeys[row.RowIndex].Value.ToString();
                    if (select.Enabled)
                    {
                        if (select.Checked)
                        {
                            deleteDetailEntities.Add(entity);
                        }
                    }
                }
            }
            try
            {
                BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT.Proxy.BatchDelete(deleteDetailEntities.ToArray());
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
            }
            catch (Exception expt)
            {
                throw expt;
            }
            ShowData();
        }
        protected override void PrepareDetailDataSourceControl(string id)
        {

        }
    }
}

