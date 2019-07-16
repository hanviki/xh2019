<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_PAY_YEAR_FUND_f2.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_PAY_YEAR_FUND_f2" %>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<%@ Register Assembly="Ipedf.Hrp.BGT.Web.Control" Namespace="Ipedf.Hrp.BGT.Web.Control"
    TagPrefix="BGT" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta name="Generator" content="Ipedf" />
    <meta name="Author" content="http://www.itabby.com" />
    <meta name="Keywords" content="http://www.itabby.com" />
    <meta name="Description" content="" />
    <title>BGT_B_DEPT_PAY_YEAR_FUND</title>
    <link href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet" />

    <script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
<script type="text/javascript">
    function ClientFun(comBaseId, row) {//comBaseId �ؼ�ID��row��ѡComBaseBox����ֵ �Ƕ��� row.NAME,row.ID

        $("#txtInputCODE").val(row.CODE);
        $("#txtInputCODE_H").val(row.CODE);

    }
     </script>
</head>
<body topmargin="0" leftmargin="0">
    <form id="form1" runat="server">
    <div>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td>
                    <Com:ComPageNavigator runat="server" ID="navigator" />
                </td>
            </tr>
            <tr>
                <td height="30">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="30">
                            </td>
                            <td>
                                <Com:ComControlBar ID="command" runat="server" HandoverState="True" />
                            </td>
                            <td width="16">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="8">
                                &nbsp;
                            </td>
                            <td>
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td>
                                            <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                cellpadding="0">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblState" runat="server" Width="500px"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <Com:ComButton ID="btnDelete" runat="server" Text="ɾ��" />&nbsp;
                                                          ���ţ�<Com:ComBaseBox ID="ddlBUDGET_DEPT_ID" runat="server"></Com:ComBaseBox>��ȣ�<Com:ComDropDownList ID="ddlQueryBUDGET_YEAR" runat="server" ></Com:ComDropDownList>
                                                        &nbsp;<asp:Button runat="server" ID="btnSearch" Text="��ѯ" OnClick="OnQuery" />
                                                        &nbsp;<asp:Button runat="server" ID="btnExport" Text="����" OnClick="OnExport" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div id="resultPannel" runat="server">
                                                <BGT:BGTComGridView ID="gvResultList" runat="server" AutoGenerateColumns="False"
                                                    BorderColor="#b5d6e6" BorderWidth="1px" AllowPaging="True" AllowSorting="True"
                                                    BorderStyle="Double" ShowFooter="True">
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="V">
                                                            <HeaderTemplate>
                                                                <input id="chkSelItem" type="checkbox" onclick="selectAll('gvResultList');" />
                                                            </HeaderTemplate>
                                                            <ItemTemplate>
                                                                <asp:CheckBox ID="cbSelect" runat="server" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="�������" />
                                                        <asp:BoundField DataField="BUDGET_DEPT_ID_NAME" HeaderText="Ԥ�����" />
                                                        <asp:BoundField DataField="DEPT_USER_ID" HeaderText="���Ҹ�����" />
                                                        <asp:BoundField DataField="BGT_D_BUDGET_ITEM_ID_NAME" HeaderText="��������" />
                                                        <asp:BoundField DataField="CODE" HeaderText="���Ѵ���" />
                                                        <asp:BoundField DataField="IS_PERFORMANCE_NAME" HeaderText="�Ƿ�Ϊ��Ч������Ŀ" />
                                                        <asp:BoundField DataField="IS_FIXED_NAME" HeaderText="�Ƿ�Ϊ����Ԥ��" />
                                                        <asp:BoundField DataField="FUND_MONEY" HeaderText="һ���걨���" />
                                                        <asp:BoundField DataField="CONTROL_MONEY" HeaderText="һ�µ������" HeaderStyle-ForeColor="Red" />
                                                        <asp:BoundField DataField="ISAGREE" HeaderText="�Ƿ�ͬ�����" />
                                                        <asp:BoundField DataField="FUND_MONEY1" HeaderText="�����걨���" />
                                                        <asp:BoundField DataField="CONTROL_MONEY1" HeaderText="�˶���" HeaderStyle-ForeColor="Red"/>
                                                        <asp:BoundField DataField="FUND_TYPE_ID_NAME" HeaderText="�������" />
                                                        <asp:BoundField DataField="STATE_NAME" HeaderText="״̬" />
                                                        <asp:BoundField DataField="IS_ATTACH" HeaderText="�Ƿ��ϴ�����" />
                                                    </Columns>
                                                    <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                    <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                    <RowStyle CssClass="RowStyle"></RowStyle>
                                                    <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                    <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                    <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                </BGT:BGTComGridView>
                                                <Com:ComPager runat="server" ID="pager" />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div id="editPannel" runat="server">
                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                    cellpadding="0">
                                                    <tr>
                                                        <td>
                                                            <div id="basePannel" runat="server">
                                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                                    cellpadding="0">
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>Ԥ�����</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <%--<Com:ComBaseBox ID="ddlInputBUDGET_DEPT_ID" Enabled="false" runat="server"></Com:ComBaseBox>--%>
                                                                            <Com:ComDropDownList ID="ddlInputBUDGET_DEPT_ID" OnSelectedIndexChanged ="ddlInputBUDGET_DEPT_ID_Change" Height="24" AutoPostBack = "true" runat="server"></Com:ComDropDownList>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>���Ÿ�����</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="ddlInputDEPT_USER_ID" Enabled="false" runat="server"></Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>�������</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputBUDGET_YEAR" Enabled="false" runat="server">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>��������</nobr>
                                                                        </td>
                                                                        <td colspan="3">
                                                                            <Com:ComBaseBox ID="ddlInputBGT_D_BUDGET_ITEM_ID"  runat="server">
                                                                            </Com:ComBaseBox>
                                                                            <input type="button" onclick="$('#txtInputNewItem').attr('disabled', false); $('#ddlInputBGT_D_BUDGET_ITEM_ID_inputQuery').val(''); $('#ddlInputBGT_D_BUDGET_ITEM_ID_inputId').val(''); $('#ddlInputBGT_D_BUDGET_ITEM_ID_inputName').val('');" value="����" />
                                                                            <Com:ComTextBox ID="txtInputNewItem" runat="server" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>�������</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="ddlInputFUND_TYPE_ID" runat="server" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>һ�Ͼ��ѽ��</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputFUND_MONEY" runat="server" Enabled="false" onfocus="this.blur()">
                                                                            </Com:ComTextBox>
                                                                            <asp:RegularExpressionValidator ID="revtxtInputFUND_MONEY" runat="server" ControlToValidate="txtInputFUND_MONEY" Enabled ="false"
                                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">��������ȷ��С��</asp:RegularExpressionValidator>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>һ�µ�����</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY" ForeColor="Red"  runat="server" onfocus="this.blur()" >
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>�Ƿ�ͬ�����</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputIS_AGREE" Enabled ="false" runat="server">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                    <td>
                                                                            <nobr>���Ͼ��ѽ��</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputFUND_MONEY1" Enabled ="false" runat="server" onfocus="this.blur()">
                                                                            </Com:ComTextBox>
                                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtInputFUND_MONEY1"
                                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">��������ȷ��С��</asp:RegularExpressionValidator>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>�˶���</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY1" ForeColor="Red"  runat="server" onfocus="this.blur()">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>���ѱ���</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCODE" runat="server" MaxLength="50" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                           <asp:HiddenField ID="txtInputCODE_H" runat="server" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>��Ч����</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputIS_PERFORMANCE" runat="server">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>����Ԥ��</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputIS_FIXED" runat="server">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>һ������˵��</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputDECALRE_CAUSE" TextMode="MultiLine" Columns="20" Rows="2" Font-Size="12px" Enabled="false"
                                                                                Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>һ��Ԥ�㹤��ίԱ��칫�����</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA2" TextMode="MultiLine" Columns="20" Rows="2"
                                                                                Font-Size="12px" Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>��������˵��</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputDECALRE_CAUSE1" TextMode="MultiLine" Columns="20" Rows="2" Font-Size="12px" Enabled="false"
                                                                                Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>Ԥ�㹤��ίԱ��칫�Һ˶����</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA3" TextMode="MultiLine" Columns="20" Rows="2"
                                                                             Font-Size="12px" Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="6">
                                                                            <Com:ComUpFile ID="upFiles" runat="server"></Com:ComUpFile>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div id="detailPannel" runat="server">
                                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                                    cellpadding="0">
                                                                    <tr>
                                                                        <td>
                                                                            <Com:ComGridView ID="gvDetailList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                                                BorderWidth="1px" DbClickEdit="false">
                                                                                <Columns>
                                                                                    <asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
                                                                                    <asp:TemplateField HeaderText="V">
                                                                                        <HeaderTemplate>
                                                                                            <input id="chkSelItem" type="checkbox" onclick="selectAll('gvDetailList');" />
                                                                                        </HeaderTemplate>
                                                                                        <ItemTemplate>
                                                                                            <asp:CheckBox ID="cbSelect" runat="server" />
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="֧������">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputBUILDING_NAME" Enabled="false" TextMode="MultiLine" Font-Size="12px"
                                                                                                Columns="20" Rows="10" Width="96%" Height="35px" runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="һ�ϼƻ�֧�����">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputMONEY" Width="100" Enabled="false" runat="server" txtInputMONEY onchange="onmoneychange()"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="�ƻ����ʱ��">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputCOMPLETE_TIME" Width="100" Enabled="false" runat="server"></Com:ComTextBox><img
                                                                                                style="cursor: hand" onclick="tableClick(this)" src="../../images/calender.gif">
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="����˵��">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputDECLARE_CAUSE" Enabled="false" TextMode="MultiLine" Font-Size="12px"
                                                                                                Columns="20" Rows="10" Width="96%" Height="35px" runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="Ԥ��칫��һ�µ������">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtCONTROL_MONEY" Width="100" runat="server" txtCONTROL_MONEY onchange="oncontrolchange()"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="Ԥ��칫��һ�����">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA" TextMode="MultiLine" Font-Size="12px" Columns="20"
                                                                                                Rows="10" Width="96%" Height="35px" runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="����������" >
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputMONEY1" Enabled="false" Width="100"  runat="server"  txtInputMONEY1 onchange="onmoneychange1()"></Com:ComTextBox>Ԫ
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="�˶���">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY1" Width="100" runat="server" txtInputCONTROL_MONEY1 onchange="oncontrolchange1()"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="Ԥ��칫�Һ˶����" >
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA1" runat="server" TextMode="MultiLine"  Font-Size="12px" Columns="20" Rows="10" Width="96%" Height="35px"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                </Columns>
                                                                                <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                                                <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                                                <RowStyle CssClass="RowStyle"></RowStyle>
                                                                                <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                                                <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                                                <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                                            </Com:ComGridView>
                                                                            <Com:ComDropDownList ID="ddlDataSourceACCOUNT_ITEM_ID" runat="server" Visible="false" />
                                                                            <Com:ComDropDownList ID="ddlDataSourceBGT_D_ACCOUNT_ITEM_ID" runat="server" Visible="false" />
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                                                        <script type="text/javascript">
                                                                                                                                                      function onmoneychange() {
                                                                            //console.log("ontextchange");
                                                                            var InputMONEY = 0;
                                                                            $("#gvDetailList [txtInputMONEY]").each(function () {
                                                                                //console.log("aaaaaaa ");
                                                                                //console.dir($(this).val());
                                                                                InputMONEY = InputMONEY + parseInt($(this).val());
                                                                            })

                                                                            $("#txtInputFUND_MONEY").val(InputMONEY);
                                                                                  }

                                                                                                                     function onmoneychange1() {
                                                                            //console.log("ontextchange1");
                                                                            var InputMONEY = 0;
                                                                            $("#gvDetailList [txtInputMONEY1]").each(function () {
                                                                                //console.log("aaaaaaa ");
                                                                                //console.dir($(this).val());
                                                                                InputMONEY = InputMONEY + parseInt($(this).val());
                                                                            })

                                                                            $("#txtInputFUND_MONEY1").val(InputMONEY);
                                                                                            }

                                                                        function oncontrolchange() {
                                                                            console.log("ontextchange");
                                                                            var InputMONEY = 0;
                                                                            $("#gvDetailList [txtCONTROL_MONEY]").each(function () {
                                                                                //console.log("aaaaaaa ");
                                                                                //console.dir($(this).val());
                                                                                InputMONEY = InputMONEY + parseInt($(this).val());
                                                                            })

                                                                            $("#txtInputCONTROL_MONEY").val(InputMONEY);
                                                                                             }

                                                                                                                                      function oncontrolchange1() {
                                                                            console.log("ontextchange1");
                                                                            var InputMONEY = 0;
                                                                            $("#gvDetailList [txtInputCONTROL_MONEY1]").each(function () {
                                                                                //console.log("aaaaaaa ");
                                                                                //console.dir($(this).val());
                                                                                InputMONEY = InputMONEY + parseInt($(this).val());
                                                                            })

                                                                            $("#txtInputCONTROL_MONEY1").val(InputMONEY);
                                                                        }
                                                                    </script>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td width="8">
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td height="35">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="35">
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td width="16">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
