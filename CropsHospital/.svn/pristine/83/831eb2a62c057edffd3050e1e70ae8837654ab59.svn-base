using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Hospital.Base
{
    /// <summary>
    /// 数据单元操作接口
    /// </summary>
    public interface IUnitOfWorkContext : IUnitofWork, IDisposable
    {
        /// <summary>
        /// 为指定的类型返回System.Data.Entity.DbSet，这将允许对上下文中的定实体执行 CRUD 操作。
        /// </summary>
        /// <typeparam name="TEntity">应为其返回一个集实体类型</typeparam>
        /// <returns>给定实体类型的System.Data.EntityBase.DbSet 实例。</returns>
        DbSet<TEntity> Set<TEntity>() where TEntity : EntityBase;

        /// <summary>
        /// 注册一个新的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity">要注册的类型</typeparam>
        /// <param name="entity">要注册的对象</param>
        void RegisterNew<TEntity>(TEntity entity) where TEntity : EntityBase;

        /// <summary>
        /// 批量注册多个新的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity">要注册的类型</typeparam>
        /// <param name="entities">要注册的对象集合</param>
        void RegisterNew<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase;

        /// <summary>
        /// 注册一个更改的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity">要注册的类型 </typeparam>
        /// <param name="entity">要注册的对象 </param>
        void RegisterModified<TEntity>(TEntity entity) where TEntity : EntityBase;

        /// <summary>
        /// 注册一个删除的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        void RegisterDeleted<TEntity>(TEntity entity) where TEntity : EntityBase;

        /// <summary>
        /// 批量注册多个删除的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity">要注册的类型 </typeparam>
        /// <param name="entities">要注册的对象集合 </param>
        void RegisterDeleted<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase;

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        void ExecuteSqlCommand(string sql, params object[] parameters);
    }
}
