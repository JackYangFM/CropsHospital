using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DM = Hospital.DataModel;

namespace Hospital.DAL.DBContext
{
    public class DbContextBase:DbContext
    {
        #region 构造函数
        /// <summary>
        /// 初始化一个 使用指定数据连接名称或者连接字符串 的数据访问上下文类 的新实例
        /// </summary>
        /// <param name="nameOrConnectString"></param>
        public DbContextBase(string nameOrConnectString)
            : base(nameOrConnectString)
        {
            //阻止 EF 去数据中打探 [dbo].[EdmMetadata]
            Database.SetInitializer<DbContextBase>(null);
        }

        #endregion

        #region 属性

    
        public DbSet<DM.CategoryEntity> Category { get; set; }
        public DbSet<DM.PathogenyInfoEntity> PathogenyInfo { get; set; }
        public DbSet<DM.PathogenyImageEntity> PathogenyImage { get; set; }
        public DbSet<DM.CommonProvinceEntity> CommonProvince { get; set; }
        public DbSet<DM.CommonAreaEntity> CommonArea { get; set; }
        public DbSet<DM.CommonCityEntity> CommonCity { get; set; }
        public DbSet<DM.PlantInfoEntity> PlantInfo { get; set; }
        public DbSet<DM.HospitalInfoEntity> HospitalInfo { get; set; }
        public DbSet<DM.HospitalPlantRelationEntity> HospitalPlantRelation { get; set; }
        public DbSet<DM.AskTypeEntity> AskType { get; set; }
        public DbSet<DM.AskInfoEntity> AskInfo { get; set; }
        public DbSet<DM.ExpertInfoEntity> ExpertInfo { get; set; }
        public DbSet<DM.ExpertPlantRelationEntity> ExpertPlantRelation { get; set; }
        public DbSet<DM.ReplyExpertEntity> ReplyExpert { get; set; }
        public DbSet<DM.MemberInfoEntity> MemberInfo { get; set; }
        public DbSet<DM.QuestionInfoEntity> QuestionInfo { get; set; }
        public DbSet<DM.QuestionImageEntity> QuestionImage { get; set; }
        public DbSet<DM.ReplyMemberEntity> ReplyMember { get; set; }



        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //移除自动建表时自动加上s的复数形式
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //移除一对多的级联删除约定，想要级联删除可以在 EntityTypeConfiguration<TEntity>的实现类中进行控制
            modelBuilder.Conventions.Remove<OneToOneConstraintIntroductionConvention>();
            //多对多启用级联删除约定，不想级联删除可以在删除前判断关联的数据进行拦截
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

    }
}
