<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_ADJUST_EXE_Resource.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_B_ADJUST_EXE_Resource" %>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="Generator" content="Ipedf" />
    <meta name="Author" content="http://www.itabby.com" />
    <meta name="Keywords" content="http://www.itabby.com" />
    <meta name="Description" content="" />
    <title>BGT_B_DEPT_FUND_EXE</title>

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
                <td height="30">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="30">
                            </td>
                            <td>
                                <Com:ComControlBar ID="command" runat="server" HandoverState="False" />
                            </td>
                            <td width="16">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="right" style="display:none;">
                    <nobr>����:</nobr>
                    <Com:ComTextBox runat="server" ID="txtQueryKey"></Com:ComTextBox><asp:ImageButton
                        runat="server" ID="btnSearch" ImageUrl="../../images/action/zoom.gif" OnClick="OnQuery" />
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
                                            <div id="resultPannel" runat="server">
                                                <Com:ComGridView ID="gvList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                    BorderWidth="1px" AllowPaging="True" AllowSorting="True" BorderStyle="Double"
                                                    DbClickEdit="false">
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
                                                        <asp:BoundField DataField="BGT_D_BUDGET_ITEM_ID_NAME" HeaderText="��������" />
                                                        <asp:BoundField DataField="CODE" HeaderText="���ѱ���" />
                                                        <asp:BoundField DataField="CONTROL_MONEY1" HeaderText="���ѽ��" />
                                                        <asp:BoundField DataField="FUND_TYPE_ID_NAME" HeaderText="�������" />
                                                        <asp:BoundField DataField="IS_FIXED_NAME" HeaderText="�Ƿ��������" />
                                                        <asp:BoundField DataField="DEPT_USER_ID" HeaderText="���Ҹ�����" />
                                                        <asp:BoundField DataField="IS_UPDATE_ITEM_NAME" HeaderText="�Ƿ�����������" />
                                                        <asp:BoundField DataField="IS_PERFORMANCE_NAME" HeaderText="�Ƿ�Ч������Ŀ" />
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
