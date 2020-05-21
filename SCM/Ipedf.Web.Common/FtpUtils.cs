﻿using System;
using System.IO;
using System.Net;

namespace Ipedf.Web.Common
{
    /// <summary>
    /// web地址：   http://djk8888csdn.3vcm.net/
    /// FTP地址：	ftp://013.3vftp.com/
    /// FTP账号：	djk8888csdn
    /// FTP密码：	123456  
    /// </summary>
    public class FtpWeb
    {
        public static string ftpHost = "ftp://192.168.64.200/";//FTP的ip地址或域名 
        public static string ftpUserID = "adminx";//ftp账号
        public static string ftpPassword = "xhftpadmin";//ftp密码

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="ftpURI">ftp上的路径</param>
        /// <param name="filename">ftp上的文件名</param>
        /// <param name="fileLength">文件大小</param>
        /// <param name="localStream">本地文件流</param>
        /// <param name="errorMsg">报错信息</param>
        /// <returns></returns>
        public static bool Upload(string ftpURI, string filename, int fileLength, Stream localStream, out string errorMsg)
        {
            errorMsg = "";
            Stream fileStream = null;//本地文件流
            Stream requestStream = null;//ftp文件流      
            try
            {
                fileStream = localStream;//本地文件流

                Uri uri = new Uri(ftpHost + ftpURI + "/" + filename);//ftp完整路径
                FtpWebRequest uploadRequest = (FtpWebRequest)WebRequest.Create(uri);//创建FtpWebRequest实例uploadRequest  
                uploadRequest.Method = WebRequestMethods.Ftp.UploadFile;//将FtpWebRequest属性设置为上传文件  
                uploadRequest.Credentials = new NetworkCredential(ftpUserID, ftpPassword);//认证FTP用户名密码  
                requestStream = uploadRequest.GetRequestStream();//ftp上的空文件

                int buffLength = 2048; //开辟2KB缓存区  
                byte[] buff = new byte[buffLength];
                int contentLen;
                contentLen = fileStream.Read(buff, 0, buffLength);

                while (contentLen != 0)
                {
                    requestStream.Write(buff, 0, contentLen);//将本地文件流写入到ftp上的空文件中去
                    contentLen = fileStream.Read(buff, 0, buffLength);
                }
                requestStream.Close();
                fileStream.Close();
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
            finally
            {
                if (fileStream != null) fileStream.Close();
                if (requestStream != null) requestStream.Close();
            }
        }
        //创建文件夹
        public static string CreateDirectory(string ftpDir)
        {
            FtpWebRequest request = SetFtpConfig(WebRequestMethods.Ftp.MakeDirectory, ftpDir);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            return response.StatusDescription;
        }
        private static FtpWebRequest SetFtpConfig(string method, string ftpDir)
        {
            return SetFtpConfig(method, ftpDir, "");
        }
        private static FtpWebRequest SetFtpConfig(string method, string ftpDir, string fileName)
        {
            ftpDir = string.IsNullOrEmpty(ftpDir) ? "" : ftpDir.Trim();
            return SetFtpConfig(ftpHost, ftpUserID, ftpPassword, method, ftpDir, fileName);
        }

        private static FtpWebRequest SetFtpConfig(string host, string username, string password, string method, string RemoteDir, string RemoteFileName)
        {
            System.Net.ServicePointManager.DefaultConnectionLimit = 50;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + RemoteDir + "/" + RemoteFileName);
            request.Method = method;
            request.Credentials = new NetworkCredential(username, password);
            request.UsePassive = false;
            request.UseBinary = true;
            request.KeepAlive = false;
            return request;
        }
        /// <summary>
        /// FTP文件下载(代码仅供参考)
        /// </summary>
        /// <param name="ftpURI">fpt文件路径</param>
        /// <param name="localPath">本地文件路径</param>
        /// <param name="fileName">ftp文件名</param>
        /// <param name="errorMsg">报错信息</param>
        /// <returns></returns>
        public static bool Download(string ftpURI, string localPath, string fileName, out string errorMsg)
        {
            errorMsg = "";
            FtpWebRequest reqFTP = null;
            FileStream outputStream = null;
            Stream ftpStream = null;
            FtpWebResponse response = null;
            try
            {
                outputStream = new FileStream(localPath + "/" + fileName, FileMode.OpenOrCreate);//创建本地空文件

                Uri uri = new Uri(ftpHost + ftpURI + "/" + fileName);//ftp完整路径
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);//登录ftp
                response = (FtpWebResponse)reqFTP.GetResponse();
                ftpStream = response.GetResponseStream();//读取ftp上文件流
                long cl = response.ContentLength;
                int bufferSize = 2048;//缓冲
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);//将ftp文件流写入到本地空文件中去
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
            finally
            {
                if (ftpStream != null) ftpStream.Close();
                if (outputStream != null) outputStream.Close();
                if (response != null) response.Close();
            }
        }

        public static Stream DownLoadStream(string ftpURI, string fileName, out string errorMsg) {
            errorMsg = "";
            FtpWebRequest reqFTP = null;
            Stream ftpStream = null;
            FtpWebResponse response = null;
            Stream outputStream = null;
            try
            {
               

                Uri uri = new Uri(ftpHost + ftpURI + "/" + fileName);//ftp完整路径
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);//登录ftp
                response = (FtpWebResponse)reqFTP.GetResponse();
                ftpStream = response.GetResponseStream();//读取ftp上文件流
                long cl = response.ContentLength;
                int bufferSize = 2048;//缓冲
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);//将ftp文件流写入到本地空文件中去
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                return outputStream;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return outputStream;
            }
            finally
            {
                if (ftpStream != null) ftpStream.Close();
                if (outputStream != null) outputStream.Close();
                if (response != null) response.Close();
            }
        }

    }
}