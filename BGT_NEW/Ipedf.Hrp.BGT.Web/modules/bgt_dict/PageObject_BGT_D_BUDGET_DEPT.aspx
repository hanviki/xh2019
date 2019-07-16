<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_BUDGET_DEPT.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_D_BUDGET_DEPT" %>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="Generator" content="Ipedf" />
    <meta name="Author" content="http://www.itabby.com" />
    <meta name="Keywords" content="http://www.itabby.com" />
    <meta name="Description" content="" />
    <title>BGT_D_BUDGET_DEPT</title>

    <script src="<%=ResolveClientUrl("~/scripts/xp.js") %>" type="text/javascript"></script>

    <link href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet" />

    <script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>

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
                                        <td colspan="2">
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
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td valign="top" style="table-layout: fixed; width: 210px;display:none;">
                                            <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                cellpadding="0">
                                                <tr>
                                                    <td>
                                                        <div style="overflow: auto; position: relative; width: 200px; height: 300px;" valign="top">
                                                            <input type="textbox" style="width: 200px;" onkeyup="SearchValue(this,document.getElementById('tvTree'));" />
                                                            <Com:ComListBox runat="server" ID="tvTree" AutoPostBack="true" Width="200" Height="300" />
                                                        </div>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td valign="top" style="table-layout: fixed; width: 80%;">
                                            <div runat="server" id="resultPannel">
                                                <Com:ComGridView ID="gvList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                    BorderWidth="1px" AllowPaging="True" AllowSorting="True" BorderStyle="Double">
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="V">
                                                            <HeaderTemplate>
                                                                <input id="chkSelItem" type="checkbox" onclick="selectAll('gvList');" />
                                                            </HeaderTemplate>
                                                            <ItemTemplate>
                                                                <asp:CheckBox ID="cbSelect" runat="server" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="Ԥ�����" />
                                                        <asp:BoundField DataField="CODE" HeaderText="���ұ���" />
                                                        <asp:BoundField DataField="NAME" HeaderText="��������" />
                                                        <asp:BoundField DataField="DEPT_PROPERTY_ID_NAME" HeaderText="��������" />
                                                        <asp:BoundField DataField="DEPT_TYPE_ID_NAME" HeaderText="�������" />
                                                        <asp:BoundField DataField="IS_FUNCTION_NAME" HeaderText="�Ƿ�ְ�ܿ���" />
                                                        <asp:BoundField DataField="DEPT_ID_NAME" HeaderText="����" />
                                                        <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="PageObject_BGT_D_BUDGET_DEPT_USER.aspx?linkid={0}"
                                                            Text="�û���Ȩ" HeaderText="�û���Ȩ" Target="_blank" />
                                                        <asp:HyperLinkField Visible="false" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="PageObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.aspx?linkid={0}"
                                                            Text="Ԥ�㾭����Ȩ" HeaderText="Ԥ�㾭����Ȩ" Target="_blank" />
                                                        <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="PageObject_BGT_D_BUDGET_DEPT_CONTROLSTAGE.aspx?linkid={0}"
                                                            Text="�׶ο���" HeaderText="�׶ο���" Target="_blank" />
                                                    </Columns>
                                                    <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                    <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                    <RowStyle CssClass="RowStyle"></RowStyle>
                                                    <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                    <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                    <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                    <PagerSettings Visible="False" />
                                                </Com:ComGridView>
                                                <Com:ComPager runat="server" ID="pager" />
                                            </div>
                                            <div id="editPannel" runat="server">
                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                    cellpadding="0">
                                                    <tr>
                                                        <td>
                                                            <nobr><span style="color:Red">���ұ���</span></nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputCODE" runat="server" MaxLength="50"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr><span style="color:Red">��������</span></nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputNAME" runat="server" MaxLength="50"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>��������</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComDropDownList ID="ddlInputDEPT_PROPERTY_ID" runat="server">
                                                            </Com:ComDropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>�������</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComDropDownList ID="ddlInputDEPT_TYPE_ID" runat="server">
                                                            </Com:ComDropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr><span style="color:Red">�Ƿ�ְ�ܿ���</span></nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComDropDownList ID="ddlInputIS_FUNCTION" runat="server">
                                                            </Com:ComDropDownList>
                                                            <input type="textbox" style="width: 40px;" onkeyup="SearchValue(this,window.event.srcElement.previousSibling);" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr><span style="color:Red">��Ӧ����</span></nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComBaseBox ID="ddlInputDEPT_ID" runat="server"></Com:ComBaseBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <a href="../../Template/bgt/PageObject_BGT_D_BUDGET_DEPT.xls" onclick="javascript:void(0);"
                                                target="_blank">ģ������</a>
                                            <asp:FileUpload ID="btnScan" runat="server" />
                                            <asp:Button ID="btnUpload" runat="server" Text="����" Style="height: 26px" OnClick="btnUpload_Click" />
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
