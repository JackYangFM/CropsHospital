using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("医院植物分类关系表")]
    [Table("HospitalPlant_Relation")]
    public class HospitalPlantRelationEntity:EntityBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 医院编号
        /// </summary>
        public int HospitalId { get; set; }
        /// <summary>
        /// 植物编号
        /// </summary>
        public int PlantId { get; set; }
    }
}
