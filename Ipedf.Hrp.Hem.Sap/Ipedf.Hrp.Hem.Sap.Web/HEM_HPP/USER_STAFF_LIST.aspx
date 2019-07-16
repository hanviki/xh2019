﻿<%@ Page Language="C#" MasterPageFile="~/Controls/Manage.Master" AutoEventWireup="true" CodeBehind="USER_STAFF_LIST.aspx.cs" 
Inherits="Ipedf.Hrp.Hem.Sap.Web.USER_STAFF_LIST" Title="用户简历" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="<%=ResolveClientUrl("~/css/modaldiv.css") %>" rel="stylesheet">
<style>
        .light_btn
        {
            margin-right: 10%;
        }
        .Content2-btn
        {
            margin-right: 1.2%;
            margin-bottom: 0.2%;
            line-height: 1.2;
        }
    </style>
    <script language="javascript" type="text/javascript">   
        $(function(){
            setHeightRep("appPosOver",320);
            var $el = $(".navBox .nav >li:eq(1)");
            var $els = $el.children("ul").find("li").eq(8).children("a");
            bigNav($el,"RECRUIT_STAFF_LIST.aspx");
            secondNav($els);
        });
        
        function setHeightRep(el,ht){
	        var minHeight = document.documentElement.clientHeight - ht+"px";
	        document.getElementById(el).style.minHeight = minHeight;
	        document.getElementById(el).minHeight = minHeight;
        }
        function showDiv(url) {  
        //debugger     
            document.getElementById('light').style.display='block';
            document.getElementById('fade').style.display='block';
            document.getElementById("iframe1").src = url;
        }
        function CloseDiv() {       
            document.getElementById('light').style.display='none';
            document.getElementById('fade').style.display='none';
            document.getElementById("iframe1").src = "";
        }
        function resizeTable(){
	        var _last = $(".table-header tr:eq(0)").children("td").last().index();
	        var _sclWid = $(".tb-wrapper").outerWidth()-$(".tablePos").outerWidth();
	        $(".tablePos tr:eq(0)").children("td").each(function(i){
		        var el = $(this);
		        _width = el.outerWidth();
		        if(i==_last&&_sclWid){
			        return false;
		        }
		        $(".table-header tr:eq(0)").children("td").eq(i).outerWidth(_width+"px");
	        });	
        }
        
        $(function(){        	
	        var _height = document.documentElement.clientHeight - 280+"px";
	        $(".tb-wrapper").height(_height);
	        resizeTable();
	        $(window).resize(function(){ resizeTable(); });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
姓名：<asp:TextBox ID="txt_NACHN" class="form-control" style="display:inline-block;"  Width="120px" runat="server"></asp:TextBox>&nbsp;
手机号码：<asp:TextBox ID="txt_MOBILE" style="display:inline-block;" Width="120px"  class="form-control" runat="server"></asp:TextBox>&nbsp;
应聘类型：<asp:DropDownList ID="ddlInputTYPE_ID" runat="server" Width="120px" class="form-control1"></asp:DropDownList>&nbsp;
<asp:Button ID="btn_query" runat="server" class="Content2-btn btn btn-primary btn-sm" Text="查询" OnClick="btn_query_Click" />
<div id="appPosOver">
        <table class="table table-bordered table-header">
                      <tr>
                        <td>
                            <strong>姓名</strong>
                        </td>
                        <td align="center">
                            <strong>出生日期</strong>
                        </td>
                        <td align="center">
                            <strong>性别</strong>
                        </td>
                        <td align="center">
                            <strong>手机号码</strong>
                        </td>
                        <td align="center">
                            <strong>电子邮件</strong>
                        </td>
                        <td align="center">
                            <strong>籍贯</strong>
                        </td>
                        <td align="center">
                            <strong>学校</strong>
                        </td>
                        <td align="center">
                            <strong>学历</strong>
                        </td>
                        <td align="center">
                            <strong>申请职位</strong>
                        </td>
                        <td align="center">
                            <strong>应聘类型</strong>
                        </td>
                        <td align="center">
                            <strong>资格证</strong>
                        </td>
                    </tr>
                        </table>
        <asp:Repeater ID="rpt_List" runat="server">
            <HeaderTemplate><div class="tb-wrapper">
                <table width="100%" id="tab_List" cellspacing="1" cellpadding="4" class="tablePos table table-bordered">
                    
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td style="width: 6%; text-align: center">
                        <a href="javascript:void(0)" onclick="showDiv('<%#UrlDetail(Eval("STAFF_TYPE_ID"))%>')">
                            <%# Eval("NACHN")%></a>
                    </td>
                    <td width="6%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "GBDAT", "{0:d}")%>
                    </td>
                    <td width="2%" align="center">
                        <%# Eval("GESCH").ToString() == "1" ? "男" : "女"%>
                    </td>
                    <td width="7%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "USRID_TEL")%>
                    </td>
                    <td width="13%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "USRID_MAIL")%>
                    </td>
                    <td width="13%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "ZHRJG")%>
                    </td>
                    <td width="20%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "INSTI")%>
                    </td>
                    <td width="4%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "SLART_NAME")%>
                    </td>
                    <td width="16%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "RECRUIT_POSITION")%>
                    </td>
                    <td width="6%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "TYPE_NAME")%>
                    </td>
                    <td width="7%" align="center">
                        <%# Eval("IS_CERTIFICATE").ToString() == "1" ? "是" : "否"%>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table></div>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    <div class="col-md-3">
        <asp:Label ID="lbl_PageNo" runat="server"></asp:Label>
        <asp:DropDownList ID="ddlInputPageSize" runat="server" Width="50px" AutoPostBack="true"
            onselectedindexchanged="ddlInputPageSize_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
     <input id="txt_hd_id" runat="server" type="hidden" />
    <div class="col-md-offset-9">
        <asp:LinkButton ID="lbt_home" runat="server" CausesValidation="False" OnClick="lbt_home_Click">首页</asp:LinkButton>
        <asp:LinkButton ID="lbt_back" runat="server" CausesValidation="False" OnClick="lbt_back_Click">前页</asp:LinkButton>
        <asp:LinkButton ID="lbt_next" runat="server" CausesValidation="False" OnClick="lbt_next_Click">后页</asp:LinkButton>
        <asp:LinkButton ID="lbt_last" runat="server" CausesValidation="False" OnClick="lbt_last_Click">尾页</asp:LinkButton>
        |
        <asp:TextBox ID="txt_PageNo" runat="server" Width="30">1</asp:TextBox>
        <asp:Button ID="btn_GoPage" runat="server" CausesValidation="False" OnClick="btn_GoPage_Click" class="btn btn-primary btn-sm btn-white"
            Text="GO" style="padding:1px 10px;" />
    </div>
    
    <div id="light" class="white_content alert">
        <div class="alert-wrapper">
            <div style="width: 100%; text-align: right; position: absolute;">
                <a href="javascript:void(0)" class='close' aria-hidden='true' style="border: 1px;
                    margin: 10px 20px 10px 0;" onclick="CloseDiv()">&times;</a>&nbsp;
            </div>
            <div style="min-height: 98%; min-width: 95.5%; padding: 4px; text-align: center;
                position: absolute; left: 0.8%;">
                <iframe id="iframe1" style="height: 87%; width: 99%; margin-top: 30px;position:absolute;left:15px;"
                    src="" frameborder="0" scrolling="yes"></iframe>
            </div>
            <div id="btnDIV" style="width: 50%; height: 5%; left: 25%; border: 1px; position: absolute;
                bottom: 2%;">
                <input id="btnClose" type="button" onclick="CloseDiv()" class="light_btn btn btn-primary btn-sm btn-white"
                    value="关闭" />
            </div>
        </div>
    </div>
    <div id="fade" class="black_overlay">
    </div>
</asp:Content>