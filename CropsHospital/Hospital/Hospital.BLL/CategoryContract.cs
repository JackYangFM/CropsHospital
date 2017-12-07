using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Hospital.DataModel;
using Hospital.IBLL;
using Hospital.IDAL;
using Hospital.ViewModel;

namespace Hospital.BLL
{
    /// <summary>
    /// 分类表
    /// </summary>
    [Export(typeof(ICategoryContract))]
    public class CategoryContract : Base, ICategoryContract
    {
        [Import]
        public ICategoryRepository CategoryRepository { get; set; }
        
        /// <summary>
        /// 获取所有分类信息
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategoryList()
        {
            return CategoryRepository.Entities.OrderBy(m=>m.Id).Select(m => new Category
            {
                Id = m.Id,
                CategoryName = m.CategoryName,
                Pid = m.Pid,
                Grade = m.Grade
            }).ToList();
        }

        /// <summary>
        /// 新增分类
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool AddCategory(Category entity)
        {
            var info = new CategoryEntity
            {
                CategoryName = entity.CategoryName,
                Pid = entity.Pid,
                Grade = entity.Grade
            };
            return CategoryRepository.Insert(info, true)>0;
        }

        /// <summary>
        /// 获取分类列表
        /// </summary>
        /// <param name="pid">父级编号</param>
        /// <param name="grade">等级</param>
        /// <returns></returns>
        public List<Category> GetCategoryList(int pid, int grade)
        {
            return CategoryRepository.Entities.Where(m => m.Pid == pid && m.Grade == grade).Select(m => new Category
            {
                Id = m.Id,
                CategoryName = m.CategoryName,
                Pid = m.Pid,
                Grade = m.Grade
            }).ToList();
        }


        /// <summary>
        /// 通过分类ID获取 分类及父分类
        /// </summary>
        /// <param name="cid">分类ID</param>
        /// <returns></returns>
        public List<Category> MeCategoryList(int cid)
        {
            var list = CategoryRepository.MeCategoryList(cid);
            if (list != null)
            {
                return list.Select(m => new Category
                {
                    Id = m.Id,
                    CategoryName = m.CategoryName,
                    Grade = m.Grade,
                    Pid = m.Pid
                }).ToList();
            }
            return null;
        }

    }
}
