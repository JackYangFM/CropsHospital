using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("庄稼医院信息表")]
    [Table("Hospital_Info")]
    public class HospitalInfoEntity:EntityBase
    {
        /// <summary>
        /// 医院编号
        /// </summary>
        [Key]
        public int HospitalId { get; set; }
        /// <summary>
        /// 医院名称
        /// </summary>
        public string HospitalName { get; set; }
        /// <summary>
        /// 医院图标
        /// </summary>
        public string HospitalImage { get; set; }
        /// <summary>
        /// 专家数
        /// </summary>
        public int Specialists { get; set; }
        /// <summary>
        /// 医院简介
        /// </summary>
        public string Brief { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

    }
}
