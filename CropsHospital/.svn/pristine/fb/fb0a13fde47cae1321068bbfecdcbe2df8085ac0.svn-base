using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Hospital.Utility
{
    /// <summary>
    /// DataTable转换为list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataTableToList<T> where T : new()
    {
        /// <summary>   
        /// DataTable转换为list   
        /// </summary>   
        /// <param name="dt"></param>   
        /// <returns></returns>   
        public static List<T> ConvertToList(DataTable dt)
        {

            // 定义集合   
            var ts = new List<T>();

            //遍历DataTable中所有的数据行   
            foreach (DataRow dr in dt.Rows)
            {
                var t = new T();
                // 获得此模型的公共属性   
                PropertyInfo[] propertys = t.GetType().GetProperties();
                //遍历该对象的所有属性   
                foreach (PropertyInfo pi in propertys)
                {
                    string tempName = pi.Name;
                    //检查DataTable是否包含此列（列名==对象的属性名）     
                    if (dt.Columns.Contains(tempName))
                    {
                        // 判断此属性是否有Setter   
                        if (!pi.CanWrite) continue;//该属性不可写，直接跳出   
                        //取值   
                        object value = dr[tempName];
                        //如果非空，则赋给对象的属性   
                        if (value != DBNull.Value)
                            pi.SetValue(t, value, null);
                    }
                }
                //对象添加到泛型集合中   
                ts.Add(t);
            }
            return ts;
        }
    }
}
