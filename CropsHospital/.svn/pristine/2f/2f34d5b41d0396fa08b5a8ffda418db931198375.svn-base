using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("病虫害库")]
    [Table("Pathogeny_Info")]
    public class PathogenyInfoEntity:EntityBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int ItemId { get; set; }

        public string ItemNumber { get; set; }

        /// <summary>
        /// 分类编号
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// 病虫害类型类型（0：病害 1：虫害 2：杂草）
        /// </summary>
        public int ItemType { get; set; }

        /// <summary>
        /// 病虫害名称
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 英文名
        /// </summary>
        public string ItemEnglishName { get; set; }
        /// <summary>
        /// 异名
        /// </summary>
        public string ItemNickName { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Brief { get; set; }
        /// <summary>
        /// 为害症状 （病虫害特点）
        /// </summary>
        public string Attribute1 { get; set; }
        /// <summary>
        /// 病原物（病虫害特点）
        /// </summary>
        public string Attribute2 { get; set; }
        /// <summary>
        /// 侵染循环（病虫害特点）
        /// </summary>
        public string Attribute3 { get; set; }
        /// <summary>
        /// 发生因素（病虫害特点）
        /// </summary>
        public string Attribute4 { get; set; }
        /// <summary>
        /// 防止方法（病虫害特点）
        /// </summary>
        public string Attribute5 { get; set; }
        /// <summary>
        /// 形态特征 （病虫害特点和杂草特点）
        /// </summary>
        public string Attribute6 { get; set; }
        /// <summary>
        /// 生活习性（病虫害特点）
        /// </summary>
        public string Attribute7 { get; set; }
        /// <summary>
        /// 发生特点（杂草特点）
        /// </summary>
        public string Attribute8 { get; set; }
        /// <summary>
        /// 地理分布（杂草特点）
        /// </summary>
        public string Attribute9 { get; set; }
        /// <summary>
        /// 危害情况（杂草特点）
        /// </summary>
        public string Attribute10 { get; set; }
        /// <summary>
        /// 用途（杂草特点）
        /// </summary>
        public string Attribute11 { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
