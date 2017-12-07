
using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.IBLL
{
    /// <summary>
    /// 分类表
    /// </summary>
    public interface ICategoryContract
    {
        /// <summary>
        /// 获取所有分类信息
        /// </summary>
        /// <returns></returns>
        List<Category> GetCategoryList();

        /// <summary>
        /// 新增分类
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool AddCategory(Category entity);

        /// <summary>
        /// 获取分类列表
        /// </summary>
        /// <param name="pid">父级编号</param>
        /// <param name="grade">等级</param>
        /// <returns></returns>
        List<Category> GetCategoryList(int pid, int grade);

        /// <summary>
        /// 通过分类ID获取 分类及父分类
        /// </summary>
        /// <param name="cid">分类ID</param>
        /// <returns></returns>
        List<Category> MeCategoryList(int cid);
    }
}
