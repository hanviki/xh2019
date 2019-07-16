<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_View.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_View" %>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
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
     <style>
.WordWrap { WORD-BREAK: break-all }
</style>
</head>
<body topmargin="0" leftmargin="0">
    <form id="form1" runat="server">
    <div>
       <div id="editPannel" runat="server">
                                                <table border="0" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
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
                                                                            <Com:ComBaseBox ID="ddlInputBUDGET_DEPT_ID" Enabled="false" runat="server"></Com:ComBaseBox>
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
                                                                            <Com:ComDropDownList ID="ddlInputBUDGET_YEAR" runat="server">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>��������</nobr>
                                                                        </td>
                                                                        <td colspan="3">
                                                                            <Com:ComBaseBox ID="ddlInputBGT_D_BUDGET_ITEM_ID"  runat="server" Enabled = "false"></Com:ComBaseBox>
                                                                            
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
                                                                            <Com:ComTextBox ID="txtInputFUND_MONEY" runat="server" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                            <asp:RegularExpressionValidator ID="revtxtInputFUND_MONEY" runat="server" ControlToValidate="txtInputFUND_MONEY"
                                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">��������ȷ��С��</asp:RegularExpressionValidator>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>һ�µ�����</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY" ForeColor="Red" Enabled ="false" runat="server" >
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>�Ƿ�ͬ�����</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputIS_AGREE" Enabled="false"  runat="server">
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
                                                                            <Com:ComTextBox ID="txtInputFUND_MONEY1" runat="server" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtInputFUND_MONEY1"
                                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">��������ȷ��С��</asp:RegularExpressionValidator>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>�˶���</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY1" ForeColor="Red" Enabled ="false" runat="server" >
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
                                                                            <nobr>һ������˵��</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputDECALRE_CAUSE" TextMode="MultiLine" Columns="20" Enabled="false" Rows="2" Font-Size="12px"
                                                                                Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>һ��Ԥ�㹤��ίԱ��칫�����</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox Enabled="false" ID="txtInputFINANCE_IDEA" TextMode="MultiLine" Columns="20" Rows="2"
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
                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA1" TextMode="MultiLine" Columns="20" Rows="2"
                                                                             Enabled="false"   Font-Size="12px" Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="6">
                                                                            <Com:ComUpFile ID="upFiles" runat="server"></Com:ComUpFile>
                                                                        </td>
                                                                    </tr>
                                                                  <%--  <tr>
                                                                        <td>
                                                                            <nobr>�������</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA2" TextMode="MultiLine" Enabled="false" Columns="20"
                                                                                Rows="2" Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>--%>
                                                                </table>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div id="detailPannel" runat="server">
                                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0" style="margin-top:5px;" 
                                                                    cellpadding="0">
                                                                    <tr><td style="text-align:center">��Ŀ֧����ϸ</td></tr>
                                                                    <tr>
                                                                        <td>
                                                                            <ASP:GridView ID="gvDetailList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                                                BorderWidth="1px" DbClickEdit="false">
                                                                                <Columns>
                                                                                    <asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
           
                                                                                    <asp:BoundField DataField="FUND_NAME" HeaderText="֧������" ><ItemStyle Width="100px" Wrap="True"/> 
</asp:BoundField>
                                                                                    <asp:BoundField DataField="MONEY" HeaderText="һ��������" />
                                                                                    <asp:BoundField DataField="DECLARE_CAUSE" HeaderText="����˵��"><ItemStyle Width="200px" Wrap="True" />
</asp:BoundField>
                                                                                    <asp:BoundField DataField="CONTROL_MONEY" HeaderText="Ԥ��칫��һ�µ������" />
                                                                                    <asp:BoundField DataField="FINANCE_IDEA" HeaderText="Ԥ��칫��һ�����"><ItemStyle Width="10%" Wrap="True" />
</asp:BoundField>
                                                                                    <asp:BoundField DataField="MONEY1" HeaderText="����������" />
                                                                                    <asp:BoundField DataField="CONTROL_MONEY1" HeaderText="�˶���" />
                                                                                    <asp:BoundField DataField="FINANCE_IDEA1" HeaderText="Ԥ��칫�Һ˶����" />

                                                                                </Columns>
                                                                                <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                                                <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                                               
                                                                                <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                                                <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                                                <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                                            </ASP:GridView>
                                                                             <ASP:GridView ID="gvDetailList1" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                                                BorderWidth="1px" DbClickEdit="false">
                                                                                <Columns>
                                                                                    <asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
           
                                                                                    <asp:BoundField DataField="FUND_NAME" HeaderText="֧������" >
</asp:BoundField>
                                                                                    <asp:BoundField DataField="MONEY" HeaderText="һ�ϼƻ�֧�����" />
                                                                                    <asp:BoundField DataField="COMPLETE_TIME" HeaderText="�ƻ����ʱ��" HtmlEncode=false DataFormatString="{0:yyyy-MM-dd}">
</asp:BoundField>
                                                                                    <asp:BoundField DataField="DECLARE_CAUSE" HeaderText="����˵��" />
                                                                                    <asp:BoundField DataField="CONTROL_MONEY" HeaderText="Ԥ��칫��һ�µ������"><ItemStyle Width="10%" Wrap="True" />
</asp:BoundField>
                                                                                    <asp:BoundField DataField="FINANCE_IDEA" HeaderText="Ԥ��칫��һ�����" />
                                                                                    <asp:BoundField DataField="MONEY1" HeaderText="���ϼƻ�֧�����" />
          <asp:BoundField DataField="CONTROL_MONEY1" HeaderText="�˶���" />
                                                                                    <asp:BoundField DataField="FINANCE_IDEA1" HeaderText="Ԥ��칫�Һ˶����" />

                                                                                </Columns>
                                                                                <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                                                <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                                               
                                                                                <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                                                <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                                                <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                                            </ASP:GridView>
                                                                            <ASP:GridView ID="gvDetailList2" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                                                BorderWidth="1px" DbClickEdit="false">
                                                                                <Columns>
                                                                                    <asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
           
                                                                                    <asp:BoundField DataField="ASSET_NAME" HeaderText="�豸����" >
</asp:BoundField>
                                                                                    <asp:BoundField DataField="PRICE" HeaderText="�豸����" />
                                                                                    <asp:BoundField DataField="AMOUNT" HeaderText="�豸����">
</asp:BoundField>
                                                                                    <asp:BoundField DataField="MONEY" HeaderText="һ��������" />
                                                                                    <asp:BoundField DataField="DECLARE_CAUSE" HeaderText="����˵��"><ItemStyle Width="10%" Wrap="True" />
</asp:BoundField>
                                                                                    <asp:BoundField DataField="CONTROL_MONEY" HeaderText="Ԥ��칫��һ�µ������" />
                                                                                    <asp:BoundField DataField="FINANCE_IDEA" HeaderText="Ԥ��칫��һ�����" />
          <asp:BoundField DataField="MONEY1" HeaderText="����������" />
                                                                                    <asp:BoundField DataField="CONTROL_MONEY1" HeaderText="�˶���" />
                                    <asp:BoundField DataField="FINANCE_IDEA1" HeaderText="Ԥ��칫�Һ˶����" />

                                                                                </Columns>
                                                                                <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                                                <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                                               
                                                                                <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                                                <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                                                <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                                            </ASP:GridView>
                                                                        </td>
                                                                    </tr>
                                                                    
                                                                </table>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            
                                            <div id="editPannel_1" runat="server">
                                                <table border="0" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                    cellpadding="0">
                                                    <tr>
                                                        <td>
                                                            <div id="Div2" runat="server">
                                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                                    cellpadding="0">
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>Ԥ�����</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComBaseBox ID="ddlInputBUDGET_DEPT_ID_1" Enabled="false" runat="server"></Com:ComBaseBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>���Ÿ�����</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="ddlInputDEPT_USER_ID_1" Enabled="false" runat="server"></Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>�������</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputBUDGET_YEAR_1" runat="server">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>��������</nobr>
                                                                        </td>
                                                                        <td colspan="3">
                                                                            <Com:ComBaseBox ID="ddlInputBGT_D_BUDGET_ITEM_ID_1" Enabled="false"  runat="server"></Com:ComBaseBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>�������</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="ddlInputFUND_TYPE_ID_1" runat="server" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>���ѽ��</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputFUND_MONEY_1" runat="server" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtInputFUND_MONEY"
                                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">��������ȷ��С��</asp:RegularExpressionValidator>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>���ѱ���</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCODE_1" runat="server" MaxLength="50" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                           
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>����˵��</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputDECALRE_CAUSE_1" TextMode="MultiLine" Columns="20" Rows="2" Font-Size="12px" Enabled ="false"
                                                                                Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="6">
                                                                            <Com:ComUpFile ID="upFiles_1" runat="server"></Com:ComUpFile>
                                                                        </td>
                                                                    </tr>
                                                                  <%--  <tr>
                                                                        <td>
                                                                            <nobr>�������</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA2" TextMode="MultiLine" Enabled="false" Columns="20"
                                                                                Rows="2" Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>--%>
                                                                </table>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div id="detailPannel_1" runat="server">
                                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                                    cellpadding="0">
                                                                    <tr><td style="text-align:center">��Ŀ֧����ϸ</td></tr>
                                                                    <tr>
                                                                        <td>
                                                                            <ASP:GridView ID="gvDetailList_1" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                                                BorderWidth="1px" DbClickEdit="false">
                                                                                <Columns>
                                                                                    <asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
                                                                                    <asp:BoundField DataField="FUND_NAME" HeaderText="֧����ϸ" >
</asp:BoundField>
                                                                                    <asp:BoundField DataField="MONEY" HeaderText="������" />
                                                      <asp:BoundField DataField="DECLARE_CAUSE" HeaderText="����˵��" />
                                  
                                                                                </Columns>
                                                                                <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                                                <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                                                
                                                                                <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                                                <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                                                <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                                            </ASP:GridView>
                                                                            <ASP:GridView ID="gvDetailList_2" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                                                BorderWidth="1px" DbClickEdit="false">
                                                                                <Columns>
                                                                                    <asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
           
                                                                                    <asp:BoundField DataField="FUND_NAME" HeaderText="֧����ϸ" >
</asp:BoundField>
                                                                                    <asp:BoundField DataField="MONEY" HeaderText="�ƻ�֧�����" />
                                                                                    <asp:BoundField DataField="COMPLETE_TIME" HeaderText="�ƻ����ʱ��" HtmlEncode=false DataFormatString="{0:yyyy-MM-dd}">
</asp:BoundField>
                                                                                    <asp:BoundField DataField="DECLARE_CAUSE" HeaderText="����˵��" />
                                                                                    

                                                                                </Columns>
                                                                                <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                                                <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                                               
                                                                                <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                                                <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                                                <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                                            </ASP:GridView>
                                                                            <Com:ComDropDownList ID="ddlDataSourceACCOUNT_ITEM_ID" runat="server" Visible="false" />
                                                                            <Com:ComDropDownList ID="ddlDataSourceBGT_D_ACCOUNT_ITEM_ID" runat="server" Visible="false" />
                                                                      <ASP:GridView ID="gvDetailList_3" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                                                BorderWidth="1px" DbClickEdit="false">
                                                                                <Columns>
                                                                                    <asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
           
                                                                                    <asp:BoundField DataField="ASSET_NAME" HeaderText="�豸����" >
</asp:BoundField>
                                                                                    <asp:BoundField DataField="PRICE" HeaderText="�豸����" />
                                                                                    <asp:BoundField DataField="AMOUNT" HeaderText="�豸����">
</asp:BoundField>
                                                                                    <asp:BoundField DataField="MONEY" HeaderText="������" />
                                                                                    <asp:BoundField DataField="DECLARE_CAUSE" HeaderText="����˵��"><ItemStyle Width="10%" Wrap="True" />
</asp:BoundField>
                                                                                    

                                                                                </Columns>
                                                                                <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                                                <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                                               
                                                                                <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                                                <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                                                <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                                            </ASP:GridView>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
    </div>
    </form>
</body>
</html>
