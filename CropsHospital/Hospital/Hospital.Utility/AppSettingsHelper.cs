using System.Configuration;

namespace Hospital.Utility
{
    public static class AppSettingsHelper
    {
        /// <summary>
        /// 获取自定义配置文件中的值
        /// </summary>
        /// <param name="settingName">节点名称</param>
        /// <returns>节点值</returns>
        private static string GetConfigValue(string settingName)
        {
            return ConfigurationManager.AppSettings[settingName];
        }


        #region 默认会员头像地址
        private static string _upUserHeadUrl = string.Empty;
        /// <summary>
        /// 默认会员头像地址
        /// </summary>
        public static string UseHeadUrl
        {
            get
            {
                if (_upUserHeadUrl == string.Empty)
                {
                    _upUserHeadUrl = GetConfigValue("UseHeadUrl");
                }
                return _upUserHeadUrl;
            }
        }
        #endregion

        

        

    }
}
