using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Hospital.DBHelper;

namespace Hospital.Utility
{
    /// <summary>
    /// 通用函数
    /// </summary>
    public class Tool
    {
        #region MD5 加密
        /// <summary>
        /// MD5 加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Md5(string str)
        {
            //32位
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
        }
        #endregion

        #region 获取星期几
        /// <summary>
        /// 获取今天星期几
        /// </summary>
        /// <returns></returns>
        public static string GetWeek()
        {
            return System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
        }
        #endregion

        #region 后台用户加密方法
        /// <summary>
        /// 创建密码加密中使用到的密钥
        /// </summary>
        /// <returns></returns>
        public static string CreateSalt()
        {
            byte[] bytSalt = new byte[8];
            RNGCryptoServiceProvider rng;

            rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytSalt);

            return Convert.ToBase64String(bytSalt);
        }

        /// <summary>
        /// 将指定密码加密
        /// </summary>
        /// <param name="cleanString">用户明文密码</param>
        /// <param name="salt">密钥</param>
        /// <returns>返回加密密码字符串</returns>
        public static string Encrypt(string cleanString, string salt)
        {
            Byte[] clearBytes;
            Byte[] hashedBytes;

            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding("unicode");

            clearBytes = encoding.GetBytes(salt.ToLower().Trim() + cleanString.Trim());

            hashedBytes = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(clearBytes);

            return BitConverter.ToString(hashedBytes).Replace("-", "");

        }
        #endregion

        #region "检测是否为有效邮件地址格式"
        /// <summary>
        /// 检测是否为有效邮件地址格式
        /// </summary>
        /// <param name="strIn">输入邮件地址</param>
        /// <returns></returns>
        public static bool IsValidEmail(string strIn)
        {
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        #endregion

        #region "获取用户IP地址"
        /// <summary>
        /// 获取用户IP地址
        /// </summary>
        /// <returns></returns>
        public static string IpAddress
        {
            get
            {
                string result = String.Empty;

                result = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (!string.IsNullOrEmpty(result))
                {
                    //可能有代理 
                    if (result.IndexOf(".") == -1)    //没有“.”肯定是非IPv4格式 
                        result = null;
                    else
                    {
                        if (result.IndexOf(",") != -1)
                        {
                            //有“,”，估计多个代理。取第一个不是内网的IP。 
                            result = result.Replace(" ", "").Replace("'", "");
                            string[] temparyip = result.Split(",;".ToCharArray());
                            for (int i = 0; i < temparyip.Length; i++)
                            {
                                if (IsIpAddress(temparyip[i])
                                    && temparyip[i].Substring(0, 3) != "10."
                                    && temparyip[i].Substring(0, 7) != "192.168"
                                    && temparyip[i].Substring(0, 7) != "172.16.")
                                {


                                    return temparyip[i];    //找到不是内网的地址 
                                }
                            }
                        }
                        else if (IsIpAddress(result)) //代理即是IP格式 
                            return result;
                        else
                            result = null;    //代理中的内容 非IP，取IP 
                    }

                }

                string IpAddress = (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null && System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != String.Empty) ? System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] : System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

                if (string.IsNullOrEmpty(result))
                    result = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

                if (string.IsNullOrEmpty(result))
                    result = System.Web.HttpContext.Current.Request.UserHostAddress;

                return result;
            }
        }

        private static bool IsIpAddress(string str1)
        {
            if (string.IsNullOrEmpty(str1) || str1.Length < 7 || str1.Length > 15) return false;
            string regformat = @"^\d{1,3}[\.]\d{1,3}[\.]\d{1,3}[\.]\d{1,3}$";


            var regex = new Regex(regformat, RegexOptions.IgnoreCase);
            return regex.IsMatch(str1);
        }
        #endregion

        #region 创建编号
        /// <summary>
        /// 获取订单编号，商品编号
        /// </summary>
        /// <param name="field">字段</param>
        /// <returns></returns>
        public static string GetCreateNumber(string field)
        {
            var parameters = new[]
            {
                new SqlParameter("@Field", SqlDbType.VarChar),
                new SqlParameter("@ReturnValue",SqlDbType.BigInt) 
            };

            parameters[0].Value = field;
            parameters[1].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteSqlCommand("Exec [usp_GetIdentity] @Field,@ReturnValue output", parameters);
            return parameters[1].Value.ToString();
        }
        #endregion

        #region 获取32位的GUID
        public static string GetGuid()
        {
            return Guid.NewGuid().ToString("N");
        }
        #endregion
    }
}
