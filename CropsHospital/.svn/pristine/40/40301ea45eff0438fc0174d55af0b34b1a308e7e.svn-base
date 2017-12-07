using System.Net;
using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;

namespace Hospital.Utility
{
    /// <summary>
    /// 阿里云缓存初始化
    /// </summary>
    public class MemCached
    {
        private static MemcachedClient _memClient;
        private static readonly object Padlock = new object();
        //线程安全的单例模式
        public static MemcachedClient GetInstance()
        {
            if (_memClient == null)
            {
                lock (Padlock)
                {
                    if (_memClient == null)
                    {
                        MemClientInit();
                    }
                }
            }
            return _memClient;
        }

        public static void MemClientInit()
        {
            //初始化缓存
            var memConfig = new MemcachedClientConfiguration();
            IPAddress newaddress = IPAddress.Parse(Dns.GetHostEntry("c47b3b2c7e9811e4.m.cnqdalicm9pub001.ocs.aliyuncs.com").AddressList[0].ToString()); //your_instanceid替换为你的OCS实例的ID
            var ipEndPoint = new IPEndPoint(newaddress, 11211);

            // 配置文件 - ip
            memConfig.Servers.Add(ipEndPoint);
            // 配置文件 - 协议
            memConfig.Protocol = MemcachedProtocol.Binary;
            // 配置文件-权限
            memConfig.Authentication.Type = typeof(PlainTextAuthenticator);
            memConfig.Authentication.Parameters["zone"] = "青岛可用区B";
            memConfig.Authentication.Parameters["userName"] = "c47b3b2c7e9811e4";
            memConfig.Authentication.Parameters["password"] = "Yf566399";
            //下面请根据实例的最大连接数进行设置
            memConfig.SocketPool.MinPoolSize = 5;
            memConfig.SocketPool.MaxPoolSize = 200;
            _memClient = new MemcachedClient(memConfig);
        }
    }
}
