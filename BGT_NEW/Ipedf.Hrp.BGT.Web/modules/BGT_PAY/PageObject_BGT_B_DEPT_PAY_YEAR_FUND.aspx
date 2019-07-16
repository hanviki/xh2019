<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_PAY_YEAR_FUND.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_PAY_YEAR_FUND" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>
	<title>BGT_B_DEPT_PAY_YEAR_FUND</title>
	
	<link  href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet"/>
	<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
</head >
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
	            <td height="30" >
	                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="30"></td>
	                        <td><Com:ComControlBar ID="command" runat="server" HandoverState="True" /></td>
	                        <td width="16"></td>
                        </tr>
                    </table>
	            </td>	               
	        </tr>
           <tr >
				<td  >
				<table width="100%" border="0" cellspacing="0" cellpadding="0">
				     <tr >
						<td width="8"  >&nbsp;</td>
						<td>
	                             <table width="100%" border="0" cellspacing="0" cellpadding="0">
									<tr >
										<td  >
										<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">
											<tr>
												<td>
												<asp:Label ID="lblState" runat="server" Width="500px" ></asp:Label>
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
										<td >
											<div id="resultPannel" runat="server">
												 <Com:ComGridView ID="gvResultList" runat="server" AutoGenerateColumns="False"   BorderColor="#b5d6e6" BorderWidth="1px"  AllowPaging="True"  AllowSorting="True" BorderStyle="Double"  >
													<Columns>
														<asp:TemplateField HeaderText="V">
														    <headertemplate>
                                                                    <INPUT id="chkSelItem" type="checkbox" onclick="selectAll('gvResultList');" />
                                                                </headertemplate>
														    <ItemTemplate>
															    <asp:CheckBox ID="cbSelect" runat="server" />
														    </ItemTemplate>
													    </asp:TemplateField>							    
														
							<asp:BoundField DataField="BUDGET_DEPT_ID_NAME" HeaderText="Ԥ�����" /> 
							<asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="�������" /> 
							<asp:BoundField DataField="BGT_D_BUDGET_ITEM_ID_NAME" HeaderText="��������" /> 
							<asp:BoundField DataField="ITEM_NAME" HeaderText="" /> 
							<asp:BoundField DataField="DEPT_USER_ID_NAME" HeaderText="���Ÿ�����" /> 
							<asp:BoundField DataField="DECALRE_CAUSE" HeaderText="����˵��" /> 
							<asp:BoundField DataField="FUND_TYPE_ID_NAME" HeaderText="�������" /> 
							<asp:BoundField DataField="FUND_MONEY" HeaderText="���ѽ��" /> 
							<asp:BoundField DataField="STATE_NAME" HeaderText="״̬" /> 
							<asp:BoundField DataField="CODE" HeaderText="���ѱ���" /> 
													</Columns>
													<HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
													<FooterStyle CssClass="FooterStyle"></FooterStyle>                            
													<RowStyle CssClass="RowStyle"></RowStyle>
													<PagerStyle CssClass="PagerStyle"></PagerStyle>
													<SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
													<AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
												</Com:ComGridView>
												<Com:ComPager runat="server" ID="pager" />
											</div>
										</td>
									</tr>
									<tr>
										<td>
											<div id="editPannel" runat="server">
												<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">
													<tr>
														<td>
															<div id="basePannel" runat="server">
																<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">			
																	
				<tr>
					<td >
						<nobr>Ԥ�����</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputBUDGET_DEPT_ID" runat="server" ></Com:ComBaseBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>�������</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputBUDGET_YEAR" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>��������</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputBGT_D_BUDGET_ITEM_ID" runat="server" ></Com:ComBaseBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr></nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputITEM_NAME" runat="server" MaxLength = "200" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>���Ÿ�����</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputDEPT_USER_ID" runat="server" ></Com:ComBaseBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>����˵��</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputDECALRE_CAUSE" runat="server" MaxLength = "2000" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>�������</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputFUND_TYPE_ID" runat="server" ></Com:ComBaseBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>���ѽ��</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputFUND_MONEY" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputFUND_MONEY" runat="server" ControlToValidate="txtInputFUND_MONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">��������ȷ��С��</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>���ѱ���</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputCODE" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>����</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputNAME" runat="server" MaxLength = "100" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>�����ֶ�3</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputFREE_FIELD3" runat="server" MaxLength = "10" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>�����ֶ�1</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputFREE_FIELD" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>�����ֶ�2</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputFREE_FIELD2" runat="server" MaxLength = "200" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>�������</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputFINANCE_IDEA" runat="server" MaxLength = "500" ></Com:ComTextBox>
					</td>
				</tr>
																</table>
															</div>
														</td>
													</tr>
													<tr>
														<td >
															<div id="detailPannel" runat="server">
															<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">	
																<tr>
																	<td>
																		<Com:ComGridView ID="gvDetailList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6" BorderWidth="1px" DbClickEdit="false">
																			<Columns>
																				<asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
																				<asp:TemplateField HeaderText="V">
																					<headertemplate>
																							<INPUT id="chkSelItem" type="checkbox" onclick="selectAll('gvDetailList');" />
																						</headertemplate>
																					<ItemTemplate>
																						<asp:CheckBox ID="cbSelect" runat="server" />
																					</ItemTemplate>
																				</asp:TemplateField>
																				
							<asp:TemplateField HeaderText="����˵��">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputDECLARE_CAUSE" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="�豸ID">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputASSET_ID" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="������">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputMONEY" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="һ�㾭������">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputFUND_NAME" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="�豸����">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputAMOUNT" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="�豸����">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputPRICE" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="�ƻ����ʱ��">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputCOMPLETE_TIME" runat="server" ></Com:ComTextBox><img style="cursor: hand" onclick="tableClick(this)" src="../../images/calender.gif" >
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="�豸����">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputASSET_NAME" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="��������">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputBUILDING_NAME" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="һ�㾭������">
								<ItemTemplate>
									<Com:ComBaseBox ID="ddlInputACCOUNT_ITEM_ID" runat="server" ></Com:ComBaseBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="Ӧ�������÷���">
								<ItemTemplate>
									<Com:ComBaseBox ID="ddlInputBGT_D_ACCOUNT_ITEM_ID" runat="server" ></Com:ComBaseBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="�������">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputFINANCE_IDEA" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="�����ֶ�3">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputFREE_FIELD3" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="�����ֶ�">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputFREE_FIELD" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="�����ֶ�2">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputFREE_FIELD2" runat="server" ></Com:ComTextBox>
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
																		
							<Com:ComDropDownList ID="ddlDataSourceACCOUNT_ITEM_ID" runat="server" Visible="false"/>
							<Com:ComDropDownList ID="ddlDataSourceBGT_D_ACCOUNT_ITEM_ID" runat="server" Visible="false"/>
																	</td>
																</tr>
															</table>
															</div>
														</td>
													</tr>
												</table>
											</div>
										</td>
									</tr>
								</table>
	                        </td>
	                        <td width="8"  >&nbsp;</td>
	                    </tr>
	                </table>
	            </td>
	        </tr>	
			<tr>
	            <td height="35" >
	                <table width="100%" border="0" cellspacing="0" cellpadding="0">
	                    <tr>
	                        <td width="12" height="35"></td>
	                        <td >&nbsp;</td>   
	                        <td width="16"></td>   
	                    </tr>
	                </table>
	            </td>
	        </tr>			
		</table>		
	</div>
</form>
</body>
</html>

