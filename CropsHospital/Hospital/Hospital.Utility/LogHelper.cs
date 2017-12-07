using NLog;

namespace Hospital.Utility
{
    /// <summary>
    /// 日志操作
    /// </summary>
    public static class LogHelper
    {
        /// <summary>
        /// 异常日志记录工具
        /// </summary>
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    }
}
