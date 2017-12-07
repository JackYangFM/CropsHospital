using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;

namespace Hospital.Utility
{
    /// <summary>
    /// 针对Json和对象之间的转换操作
    /// </summary>
    public static class JsonHelper
    {
        #region json转换对象
        public static T GetObjByJson<T>(string strInput)
        {
            var jss = new JavaScriptSerializer();
            return jss.Deserialize<T>(strInput);
        }
        #endregion

        #region 对象转换成json
        public static string GetJsonByObj(object obj)
        {
            var jss = new JavaScriptSerializer();
            return jss.Serialize(obj);
        }
        #endregion

        #region DataTable转换成Json
        public static string ConvertDataTableToJson(DataTable dt)
        {
            var strJson = new StringBuilder();
            strJson.AppendLine("[");
            for (var rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
            {
                strJson.AppendLine("{");
                for (var colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                {
                    strJson.Append("'" + dt.Columns[colIndex].ToString() + "':'" + dt.Rows[rowIndex][colIndex].ToString() + "'");
                    if (colIndex != dt.Columns.Count - 1)
                    {
                        strJson.Append(",");
                    }
                }
                strJson.Append("}");
                if (rowIndex != dt.Rows.Count - 1)
                {
                    strJson.Append(",");
                }
            }
            strJson.AppendLine("]");
            return strJson.ToString();
        }
        #endregion

        #region Json 转换成 DataTable
        /// <summary>
        /// Json 字符串 转换为 DataTable数据集合
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static DataTable ConvertJsonToDataTable(this string json)
        {
            var dataTable = new DataTable();  //实例化
            DataTable result;
            try
            {
                var javaScriptSerializer = new JavaScriptSerializer();
                javaScriptSerializer.MaxJsonLength = Int32.MaxValue; //取得最大数值
                ArrayList arrayList = javaScriptSerializer.Deserialize<ArrayList>(json);
                if (arrayList.Count > 0)
                {
                    foreach (Dictionary<string, object> dictionary in arrayList)
                    {
                        if (!dictionary.Keys.Any())
                        {
                            result = dataTable;
                            return result;
                        }
                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (string current in dictionary.Keys)
                            {
                                dataTable.Columns.Add(current, dictionary[current].GetType());
                            }
                        }
                        DataRow dataRow = dataTable.NewRow();
                        foreach (string current in dictionary.Keys)
                        {
                            dataRow[current] = dictionary[current];
                        }

                        dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
                    }
                }
            }
            catch
            {
            }
            result = dataTable;
            return result;
        }
        #endregion

        //基础定义 Status: 0：成功 1：失败 2：以后扩展

        /// <summary>
        /// App返回错误状态信息 
        /// </summary>
        /// <returns></returns>
        public static HttpResponseMessage ReturnErrorStateJson(string rMsg)
        {
            return new HttpResponseMessage { Content = new StringContent("{\"Status\":1,\"Msg\":\"" + rMsg + "\"}", Encoding.GetEncoding("UTF-8"), "application/json") };
        }

        /// <summary>
        /// App返回正确状态信息
        /// </summary>
        /// <returns></returns>
        public static HttpResponseMessage ReturnSuccessStateJson(string rMsg)
        {
            return new HttpResponseMessage { Content = new StringContent("{\"Status\":0,\"Msg\":\"" + rMsg + "\"}", Encoding.GetEncoding("UTF-8"), "application/json") };
        }

        /// <summary>
        /// 序列化成json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static HttpResponseMessage ToJson(Object obj)
        {
            String str;
            if (obj is String || obj is Char)
            {
                str = obj.ToString();
            }
            else
            {
                var serializer = new JavaScriptSerializer();
                str = serializer.Serialize(obj);
            }
            var result = new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }

        /// <summary>
        /// 对象序列化成String
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToString(Object obj)
        {
            String str;
            if (obj is String || obj is Char)
            {
                str = obj.ToString();
            }
            else
            {
                var serializer = new JavaScriptSerializer();
                str = serializer.Serialize(obj);
            }
            return str;
        }
    }
}
