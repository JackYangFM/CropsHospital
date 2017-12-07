using System;
using System.Web;
using Enyim.Caching;
using Enyim.Caching.Memcached;

namespace Hospital.Utility
{
    /// <summary>
    /// 缓存数据专用
    /// </summary>
    public class CacheHelper
    {
        #region Cache
        /// <summary>
        /// 设置缓存（到期时间）
        /// </summary>
        /// <param name="key">键值</param>
        /// <param name="value">缓存对象</param>
        /// <param name="minutes">缓存时间(单位：分钟)</param>
        public static void Set(string key, object value, int minutes)
        {
            HttpContext.Current.Cache.Insert(key, value, null, DateTime.Now.AddMinutes(minutes), TimeSpan.Zero);
        }
        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="key">键值</param>
        /// <param name="value">缓存对象</param>
        public static void Set(string key, object value)
        {
            HttpContext.Current.Cache.Insert(key, value);
        }
        /// <summary>
        /// 获取缓存对象
        /// </summary>
        /// <param name="key">键值</param>
        /// <returns></returns>
        public static object Get(string key)
        {
            return HttpContext.Current.Cache[key];
        }
        /// <summary>
        /// 清除缓存对象
        /// </summary>
        /// <param name="key">键值</param>
        public static void Delete(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

        #endregion

        #region Memcached

        private static readonly MemcachedClient MemClient = MemCached.GetInstance();

        /// <summary>
        /// OCS设置缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="obj">值</param>
        /// <param name="minutes">缓存时间：分钟</param>
        /// <returns></returns>
        public static bool OcsSet(string key, object obj, int minutes)
        {
            return MemClient.Store(StoreMode.Set, key, obj, DateTime.Now.AddMinutes(minutes));
        }

        /// <summary>
        /// OCS获取缓存对象
        /// </summary>
        /// <param name="key">键值</param>
        /// <returns></returns>
        public static object OcsGet(string key)
        {
            return MemClient.Get(key);
        }

        public static bool OcsAdd(string key, object obj, int minutes)
        {
            return MemClient.Store(StoreMode.Add, key, DateTime.Now.AddMinutes(minutes));
        }

        #endregion
    }
}
