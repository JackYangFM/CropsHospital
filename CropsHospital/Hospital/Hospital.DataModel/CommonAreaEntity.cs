using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Base;

namespace Hospital.DataModel
{
    [Description("区县")]
    [Table("Common_Area")]
    public class CommonAreaEntity : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Ccode { get; set; }
        public string Acode { get; set; }

        public string Aname { get; set; }
    }
}
