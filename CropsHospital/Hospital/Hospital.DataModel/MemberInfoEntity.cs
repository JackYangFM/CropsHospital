using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("会员信息")]
    [Table("Member_Info")]
    public class MemberInfoEntity:EntityBase
    {
        /// <summary>
        /// 会员编号
        /// </summary>
        [Key]
        public int MemberId { get; set; }
        /// <summary>
        /// 会员名称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 手机编号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 密钥
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// 性别（0：女 1：男 2：未知）
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Head { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 个人说明
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 状态（0：冻结 1：正常）
        /// </summary>
        public int Status { get; set; }
    }
}
