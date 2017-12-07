using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Linq.Expressions;
using EntityFramework.Extensions;

namespace Hospital.Base
{
    /// <summary>
    /// EntityFramework仓储操作基类
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        #region 属性

        /// <summary>
        /// 获取 仓储上下文的实例
        /// </summary>
        [Import]
        public IUnitofWork UnitofWork { get; set; }

        /// <summary>
        /// 获取或者设置EntityFramework的数据仓储上下文
        /// </summary>
        protected IUnitOfWorkContext Context
        {
            get
            {
                if (UnitofWork is IUnitOfWorkContext)
                {
                    return UnitofWork as IUnitOfWorkContext;
                }
                //throw new DataException(string.Format("数据仓储上下文对象类型不正确，应为IUnitOfWorkContext，实际为{0}",
                //    UnitofWork.GetType().Name));
                return null;
            }
        }

        /// <summary>
        /// 获取 当前实体的查询数据集
        /// </summary>
        public virtual IQueryable<TEntity> Entities
        {
            get
            {
                return Context.Set<TEntity>().AsNoTracking();
            }
        }

        #endregion

        #region 公共方法

        /// <summary>
        /// 插入实体记录
        /// </summary>
        /// <param name="entity">实体对象 </param>
        /// <param name="isSave">是否执行保存 </param>
        /// <returns>操作影响的行数 </returns>
        public virtual int Insert(TEntity entity, bool isSave = true)
        {
            Context.RegisterNew(entity);
            return isSave ? Context.Commit() : 0;
        }

        /// <summary>
        /// 批量插入实体记录集合
        /// </summary>
        /// <param name="entities">实体记录集合</param>
        /// <param name="isSave">是否执行保存</param>
        /// <returns>操作影响的行数</returns>
        public virtual int Insert(IEnumerable<TEntity> entities, bool isSave = true)
        {
            Context.RegisterNew(entities);
            return isSave ? Context.Commit() : 0;
        }

        /// <summary>
        ///     删除指定编号的记录
        /// </summary>
        /// <param name="id"> 实体记录编号 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public virtual int Delete(object id, bool isSave = true)
        {
            TEntity entity = Context.Set<TEntity>().Find(id);
            return entity != null ? Delete(entity, isSave) : 0;
        }

        /// <summary>
        /// 删除实体记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="isSave">是否执行保存</param>
        /// <returns>返回影响行数</returns>
        public virtual int Delete(TEntity entity, bool isSave = true)
        {
            Context.RegisterDeleted(entity);
            return isSave ? Context.Commit() : 0;
        }

        /// <summary>
        /// 删除实体记录集合
        /// </summary>
        /// <param name="entities">实体记录集合 </param>
        /// <param name="isSave">是否执行保存 </param>
        /// <returns>操作影响的行数 </returns>
        public virtual int Delete(IEnumerable<TEntity> entities, bool isSave = true)
        {
            Context.RegisterDeleted(entities);
            return isSave ? Context.Commit() : 0;
        }

        /// <summary>
        /// 删除所有符合特定表达式的数据
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式 </param>
        /// <param name="isSave">是否执行保存 </param>
        /// <returns>操作影响的行数</returns>
        public virtual int Delete(Expression<Func<TEntity, bool>> predicate, bool isSave = true)
        {
            List<TEntity> entities = Context.Set<TEntity>().Where(predicate).ToList();
            return entities.Count > 0 ? Delete(entities, isSave) : 0;
        }

        /// <summary>
        /// 更新实体记录
        /// </summary>
        /// <param name="entity">实体对象 </param>
        /// <param name="isSave">是否执行保存 </param>
        /// <returns>操作影响的行数 </returns>
        public virtual int Update(TEntity entity, bool isSave = true)
        {
            Context.RegisterModified(entity);
            return isSave ? Context.Commit() : 0;
        }

        /// <summary>
        /// 批量修改实体记录（推荐：高效率，无需查询至内存中处理！)
        /// </summary>
        /// <param name="filterExpression">筛选符合目标条件的记录表达式</param>
        /// <param name="updateExpression">更新实体表达式</param>
        /// <returns></returns>
        public virtual int Update(Expression<Func<TEntity, bool>> filterExpression, Expression<Func<TEntity, TEntity>> updateExpression)
        {
            return Context.Set<TEntity>().Where(filterExpression).Update(updateExpression);
        }

        /// <summary>
        /// 查找指定主键的实体记录
        /// </summary>
        /// <param name="key">指定主键 </param>
        /// <returns>符合编号的记录，不存在返回null</returns>
        public virtual TEntity GetByKey(object key)
        {
            return Context.Set<TEntity>().Find(key);
        }

        /// <summary>
        /// 执行存储过程（非单元操作，不能使用EF事务提交）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        public virtual void ExecuteSqlCommand(string sql, params object[] parameters)
        {
            Context.ExecuteSqlCommand(sql, parameters);
        }

        /// <summary>
        /// 使用存储过程调查询所需实体集合
        /// </summary>
        /// <param name="procName">存储过程名称</param>
        /// <param name="parametersName">传递参数名称以@开头，多参数中间用逗号分隔</param>
        /// <param name="parameters">传递参数值</param>
        /// <returns></returns>
        public virtual List<TEntity> GetEntitiesByPro(string procName, string parametersName, params object[] parameters)
        {
            return Context.Set<TEntity>().SqlQuery(procName + " " + parametersName, parameters).AsNoTracking().ToList();
        }

        #endregion
    }
}
