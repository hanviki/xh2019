﻿/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using log4net;
using System;
using System.IO;
using System.Web;
using System.Configuration;

namespace SapUserData
{
    public class LogFactory
    {
        static LogFactory()
        {
            FileInfo configFile = new FileInfo(System.Environment.CurrentDirectory + "//log4net.config");
            log4net.Config.XmlConfigurator.Configure(configFile);
        }
        public static Log GetLogger(Type type)
        {
            return new Log(LogManager.GetLogger(type));
        }
        public static Log GetLogger(string str)
        {
            return new Log(LogManager.GetLogger(str));
        }
    }
}
