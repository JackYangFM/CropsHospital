using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace Hospital.Utility
{
    public class WebRequestHelper
    {
        /// <summary>
        /// 获取Get 请求url数据
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static T DoGet<T>(string url)
        {
            //var newurl = AppSettingsHelper.ApiUrl + url;
            var request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            string result;
            var response = (HttpWebResponse)request.GetResponse();
            using (var stream = new StreamReader(response.GetResponseStream()))
            {
                result = stream.ReadToEnd();
            }

            var jss = new JavaScriptSerializer();
            return jss.Deserialize<T>(result);
        }

        public static T DoPost<T>(string url, string param) where T : new()
        {
            string code = System.Web.HttpUtility.UrlEncode(param);
            //var newurl = AppSettingsHelper.ApiUrl + url + "?json=" + code;
            var newurl = url + "?json=" + code;

            ServicePointManager.DefaultConnectionLimit = 300;
            System.GC.Collect();
            var cookieContainer = new CookieContainer();
            // 设置提交的相关参数
            HttpWebRequest request = null;
            HttpWebResponse sendSmsResponse = null;
            Stream dataStream = null;
            StreamReader sendSmsResponseStream = null;
            try
            {
                request = WebRequest.Create(newurl) as HttpWebRequest;
                if (request != null)
                {
                    request.Method = "POST";
                    request.KeepAlive = false;
                    request.ServicePoint.ConnectionLimit = 300;
                    request.AllowAutoRedirect = true;
                    request.Timeout = 30000;
                    request.ReadWriteTimeout = 30000;
                    request.ContentType = "application/json";
                    request.Accept = "application/xml";
                    request.Headers.Add("X-Auth-Token", HttpUtility.UrlEncode("openstack"));
                    string strContent = param;
                    byte[] bytes = Encoding.UTF8.GetBytes(strContent);
                    request.Proxy = null;
                    request.CookieContainer = cookieContainer;
                    using (dataStream = request.GetRequestStream())
                    {
                        dataStream.Write(bytes, 0, bytes.Length);
                    }
                    sendSmsResponse = (HttpWebResponse)request.GetResponse();
                    if (sendSmsResponse.StatusCode == HttpStatusCode.RequestTimeout)
                    {
                        if (sendSmsResponse != null)
                        {
                            sendSmsResponse.Close();
                            sendSmsResponse = null;
                        }
                        if (request != null)
                        {
                            request.Abort();
                        }
                        return new T();
                    }
                }
                sendSmsResponseStream = new StreamReader(sendSmsResponse.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                string strRespone = sendSmsResponseStream.ReadToEnd();

                var jss = new JavaScriptSerializer();
                return jss.Deserialize<T>(strRespone);
            }
            catch (Exception ex)
            {

                if (dataStream != null)
                {
                    dataStream.Close();
                    dataStream.Dispose();
                    dataStream = null;
                }
                if (sendSmsResponseStream != null)
                {
                    sendSmsResponseStream.Close();
                    sendSmsResponseStream.Dispose();
                    sendSmsResponseStream = null;
                }
                if (sendSmsResponse != null)
                {
                    sendSmsResponse.Close();
                    sendSmsResponse = null;
                }
                if (request != null)
                {
                    request.Abort();
                }
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                    dataStream.Dispose();
                }
                if (sendSmsResponseStream != null)
                {
                    sendSmsResponseStream.Close();
                    sendSmsResponseStream.Dispose();
                }
                if (sendSmsResponse != null)
                {
                    sendSmsResponse.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
            }

            return new T();
        }
    }
}
