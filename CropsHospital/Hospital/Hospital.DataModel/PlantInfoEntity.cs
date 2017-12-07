using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("植物信息表")]
    [Table("Plant_Info")]
    public class PlantInfoEntity:EntityBase
    {
        /// <summary>
        /// 植物编号
        /// </summary>
        [Key]
        public int PlantId { get; set; }
        /// <summary>
        /// 植物名称
        /// </summary>
        public string PlantName { get; set; }
        /// <summary>
        /// 头字母
        /// </summary>
        public string First { get; set; }
    }
}
