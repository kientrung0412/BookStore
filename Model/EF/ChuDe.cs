using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.EF
{
    [Table("ChuDe")]
    public class ChuDe
    {
        public int ChuDeID { get; set; }
        public String TenChuDe { get; set; }
    }
}