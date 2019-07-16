<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_PAY_YEAR_FUND_EXE1.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_PAY_YEAR_FUND_EXE1" EnableEventValidation="false"%>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_D_BUDGET_ITEM</title>
	<script src="<%=ResolveClientUrl("~/scripts/xp.js") %>" type="text/javascript"></script>
	
	<link  href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet"/>
	<link  href="<%=ResolveClientUrl("~/styles/web.css") %>" type="text/css" rel="stylesheet"/>
	<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
	<script type="text/javascript" src="<%=ResolveClientUrl("~/scripts/gridviewscroll.js") %>"></script>
</head >
<body>
    <form id="form1" runat="server">
    <div>
        <table >
            <tr>			                                
                <td  valign="top"> 
                    <table >			
                        <tr>                            
                            <td align="left">
                               <nobr>Ԥ�����:</nobr><Com:ComDropDownList ID="ddlQueryBUDGET_YEAR" runat="server" AutoPostBack="true" OnSelectedIndexChanged ="ddlQueryBUDGET_YEAR_Changed"></Com:ComDropDownList>
                                <nobr>����:</nobr><Com:ComBaseBox ID="ddlBUDGET_DEPT_ID" runat="server"></Com:ComBaseBox>&nbsp;<nobr>����:</nobr><Com:ComTextBox Width="100" ID="txtQueryBEGINDELIVER_DATE" runat="server"></Com:ComTextBox><img style="cursor: hand" onclick="if(!document.getElementById('txtQueryBEGINDELIVER_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtQueryBEGINDELIVER_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" ><asp:RegularExpressionValidator ID="revtxtQueryBEGINDELIVER_DATE" Visible="false" runat="server" ControlToValidate="txtQueryBEGINDELIVER_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">��������ȷ������</asp:RegularExpressionValidator>~<Com:ComTextBox Width="100" ID="txtQueryENDDELIVER_DATE" runat="server"></Com:ComTextBox><img style="cursor: hand" onclick="if(!document.getElementById('txtQueryENDDELIVER_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtQueryENDDELIVER_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" ><asp:RegularExpressionValidator ID="revtxtQueryENDDELIVER_DATE" runat="server" ControlToValidate="txtQueryENDDELIVER_DATE" ErrorMessage="" Visible="false" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">��������ȷ������</asp:RegularExpressionValidator>&nbsp;<nobr>���Ѵ���:</nobr><Com:ComTextBox ID="Beg_Code" runat="server" Width="100"></Com:ComTextBox>~<Com:ComTextBox ID="End_Code" Width="100" runat="server"></Com:ComTextBox>&nbsp;<asp:Button runat="server" ID="btnSearch" OnClick="OnQuery" Text="��ѯ" />&nbsp;<asp:Button runat="server" ID="btnShow" OnClick="btnMX" Text="��ʾ��ϸ" />&nbsp;<asp:Button runat="server" ID="btnOut" OnClick="btnOutExcel_Click" Text="����" />
                            </td>
                        </tr>
                        <tr>
                            <td >
                            <asp:Literal ID="ltScript" runat="server"></asp:Literal>
                                <div style="overflow: auto; position:relative; WIDTH:100%; HEIGHT:370px" valign="top" >
                                    <ASP:GridView ID="gvList" runat="server" AutoGenerateColumns="False" BorderStyle="None" CellPadding="0" GridLines ="None"  AllowSorting="True" OnRowCreated="gvResultList_RowCreated" HeaderStyle-CssClass="GridViewScrollHeader" OnRowDataBound="OnResultGridRowDataBound" ShowFooter="false"  DbClickEdit="false" >
                                        <Columns>
                                        <asp:TemplateField>
           <HeaderTemplate>
                <asp:CheckBox runat="server" ID="cbHead" onclick="javascript:selectAll('gvList_Content',this.checked);">
                </asp:CheckBox>
           </HeaderTemplate>
           <ItemTemplate>
                <asp:CheckBox runat="server" ID="cbItem"></asp:CheckBox>
           </ItemTemplate>
        </asp:TemplateField>
                                        <asp:BoundField DataField="ZFI_YSBMID" HeaderText="���Ŵ���" />
                                        <asp:BoundField DataField="ZFI_BMMC" HeaderText="��������" />
                                        <asp:BoundField DataField="ZFI_JFID" HeaderText="���Ѵ���" />
                                        <asp:BoundField DataField="KTEXT" HeaderText="��������" />
                                        <asp:BoundField DataField="ZFI_NCYS" HeaderText="���Ԥ��" />
                                        <asp:BoundField DataField="ZFI_NZTZ" HeaderText="���е���" />
                                        <asp:BoundField DataField="ZFI_TZHYS" HeaderText="������Ԥ��" />
                                        <asp:BoundField DataField="ZFI_YZXYS" HeaderText="��ִ��Ԥ��" />
                                        <asp:BoundField DataField="ZFI_SYYS" HeaderText="ʣ��Ԥ��" />
                                        <asp:BoundField DataField="ZFI_YSZXL_C" HeaderText="Ԥ��ִ����" />
                                        </Columns>
                                        <HeaderStyle CssClass="GridViewScrollHeader"></HeaderStyle>
                                        <RowStyle CssClass="GridViewScrollItem"></RowStyle>
                                        <FooterStyle CssClass="GridViewScrollFooterFreeze"></FooterStyle> 
                                    </ASP:GridView> 
                                    <Com:ComPager runat="server" ID="pager" Visible="false" OnPageIndex_Changed="pager_PageIndex_Changed" />
                                </div>
                            </td>
                        </tr>	
                    </table>
                </td>
            </tr>
       </table>
    </div>
    </form>
</body>
<script type="text/javascript">
    function selectAll(ctlName, bool) {
        var ctl = document.getElementById(ctlName); //���ݿؼ����ڿͻ��������ֵ�ID��ȡ�ؼ�
        var checkbox = ctl.getElementsByTagName('input'); //��ȡ�ÿؼ��ڱ�ǩΪinput�Ŀؼ�
        /*����Button��TextBox��CheckBox��RadioButton���͵ķ������˿ؼ��ڽ��ͳ�Html�ؼ��󣬶�Ϊ<input type=''./>��ͨ��type�������ǵ����͡�*/
        for (var i = 0; i < checkbox.length; i++) {
            if (checkbox[i].type == 'checkbox') {
                checkbox[i].checked = bool;
            }
        } 
    }
    var width = window.parent.document.body.clientWidth - 240;
    var height = window.parent.document.body.clientHeight - 420;
    //�õ�ҳ��߶�
    var yScroll = (window.parent.document.body.scrollHeight > window.parent.document.body.clientHeight) ? window.parent.document.body.scrollHeight : window.parent.document.body.clientHeight;
    yScroll = yScroll -400
    //alert(yScroll);
    //�õ�ҳ����
    var xScroll = (window.parent.document.body.scrollWidth > window.parent.document.body.clientWidth) ? window.parent.document.body.scrollWidth : window.parent.document.body.scrollWidth;
    xScroll = xScroll - 240;
    //alert(xScroll);
    var gridViewScroll = null;
    window.onload = function() {
        gridViewScroll = new GridViewScroll({
        elementID: "gvList",
            width: xScroll,
            height: yScroll,
            freezeColumn: false,
            freezeFooter: false,
            freezeColumnCssClass: "GridViewScrollItemFreeze",
            freezeFooterCssClass: "GridViewScrollFooterFreeze",
            freezeHeaderRowCount: 1,
            freezeColumnCount: 1
        });
        gridViewScroll.enhance();
    }
    </script>
</html>
