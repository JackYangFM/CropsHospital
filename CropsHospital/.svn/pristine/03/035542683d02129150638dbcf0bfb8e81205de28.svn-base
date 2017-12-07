using System.Collections.Generic;
using Hospital.Base;
using Hospital.DataModel;

namespace Hospital.IDAL
{
    public interface ICategoryRepository:IRepository<CategoryEntity>
    {
        /// <summary>
        /// 通过分类ID获取 分类及父分类
        /// </summary>
        /// <param name="cid">分类ID</param>
        /// <returns></returns>
        List<CategoryEntity> MeCategoryList(int cid);
    }
}
