﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Down_Excel.aspx.cs" Inherits="Ipedf.Web.Down_Excel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <h3>请下载2017年1-8月经费预算</h3>
    <a href="../../UploadFile/bgt/<%=ExcelName%>.xlsx" onclick="javascript:void(0);"
                                                                                target="_blank">下载</a>
    </div>
    </form>
</body>
</html>
