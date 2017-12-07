using System.ComponentModel.Composition;
using System.Linq;
using Hospital.DataModel;
using Hospital.IBLL;
using Hospital.IDAL;
using Hospital.Utility;
using Hospital.ViewModel;

namespace Hospital.BLL
{
    /// <summary>
    /// 会员表
    /// </summary>
    [Export(typeof(IMemberInfoContract))]
    public class MemberInfoContract : Base, IMemberInfoContract
    {
        [Import]
        public IMemberInfoRepository MemberInfoRepository { get; set; }



        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="entity">用户信息</param>
        /// <returns></returns>
        public OperationResult AddMemberInfo(MemberInfo entity)
        {
           var isExist = MemberInfoRepository.Entities.Any(m => m.Phone == entity.Phone);
            if (isExist)
            {
                return new OperationResult(OperationResultType.Error,"手机号码已经存在！");
            }

            var salt = Tool.CreateSalt(); //密钥
            var strEncrypt = Tool.Encrypt(entity.PassWord, salt); //加密密码

            var memberEntity = new MemberInfoEntity
            {
                NickName = entity.NickName,
                PassWord = strEncrypt,
                SecretKey = salt,
                Gender = entity.Gender,
                Head = entity.Head,
                Province = entity.Province,
                City = entity.City,
                Note = entity.Note,
                Status = entity.Status
            };

            var result = MemberInfoRepository.Insert(memberEntity) > 0;
            return result
                ? new OperationResult(OperationResultType.Success, "注册成功")
                : new OperationResult(OperationResultType.Error, "注册失败");
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="phone">手机编号</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        public OperationResult Login(string phone, string passWord)
        {
            var dmMember = MemberInfoRepository.Entities.FirstOrDefault(m => m.Phone == phone);
            if (dmMember!=null)
            {
                var pwd = Tool.Encrypt(passWord, dmMember.SecretKey);

                if (dmMember.PassWord ==pwd)
                {
                    var member = new MemberInfo
                    {
                        MemberId = dmMember.MemberId,
                        NickName = dmMember.NickName,
                        Phone = dmMember.Phone,
                        PassWord = dmMember.PassWord,
                        SecretKey = dmMember.SecretKey,
                        Gender = dmMember.Gender,
                        Head = dmMember.Head,
                        Province = dmMember.Province,
                        City = dmMember.City,
                        Note = dmMember.Note,
                        Status = dmMember.Status
                    };
                    return new OperationResult(OperationResultType.Success,"登录成功",member);
                }
                return new OperationResult(OperationResultType.Error,"用户密码错误!");
            }
            return new OperationResult(OperationResultType.Error,"登录失败!");
        }

    }
}
