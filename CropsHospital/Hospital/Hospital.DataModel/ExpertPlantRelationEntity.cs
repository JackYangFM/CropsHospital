using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("专家擅长植物关系表")]
    [Table("ExpertPlant_Relation")]
    public class ExpertPlantRelationEntity:EntityBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 专家编号
        /// </summary>
        public int ExpertId { get; set; }
        /// <summary>
        /// 植物编号
        /// </summary>
        public int PlantId { get; set; }
    }
}
