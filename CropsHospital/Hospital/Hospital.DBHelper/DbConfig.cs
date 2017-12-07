using System.Configuration;

namespace Hospital.DBHelper
{
    public class DbConfig
    {
        private static string _conn = string.Empty;
        /// <summary>
        /// 网站数据库链接
        /// </summary>
        public static string Conn
        {
            get
            {
                if (_conn == string.Empty)
                {
                    _conn = ConfigurationManager.ConnectionStrings["MsSql"].ToString();
                }
                return _conn;
            }
        }

    }
}
