using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data;
using System.Data.SqlClient;
using Hospital.DAL.DBContext;
using Hospital.DataModel;
using Hospital.DBHelper;
using Hospital.IDAL;
using Hospital.Utility;

namespace Hospital.DAL
{
    [Export(typeof(ICategoryRepository))]
    public class CategoryRepository : Base<CategoryEntity>, ICategoryRepository
    {
        /// <summary>
        /// 通过分类ID获取 分类及父分类
        /// </summary>
        /// <param name="cid">分类ID</param>
        /// <returns></returns>
        public List<CategoryEntity> MeCategoryList(int cid)
        {
            string sql =
                string.Format(
                    @"SELECT * FROM dbo.Category WHERE (Id={0}) OR id = (SELECT Pid FROM dbo.Category WHERE id={0})
                                    OR id = (SELECT pid FROM dbo.Category WHERE id=(SELECT Pid FROM dbo.Category WHERE id={0}))",
                    cid);
            var param = new SqlParameter[] { };
            DataTable dt = SqlHelper.GetDataTable(sql, CommandType.Text, param);
            return DataTableToList<CategoryEntity>.ConvertToList(dt);
        }
    }
}
