//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataService
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        public CUSTOMER()
        {
            this.COMMENT = new HashSet<COMMENT>();
            this.COURSE = new HashSet<COURSE>();
            this.ATTEND = new HashSet<ATTEND>();
            this.NOTE = new HashSet<NOTE>();
            this.COURSE1 = new HashSet<COURSE>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string PASSWORD { get; set; }
        public decimal BALANCE { get; set; }
        public string EMAIL { get; set; }
        public string DEGREE { get; set; }
        public double LEARN_RATE { get; set; }
        public double TEACH_RATE { get; set; }
        public System.DateTime BIRTHDAY { get; set; }
        public bool ALLOW { get; set; }
    
        public virtual ICollection<COMMENT> COMMENT { get; set; }
        public virtual ICollection<COURSE> COURSE { get; set; }
        public virtual ICollection<ATTEND> ATTEND { get; set; }
        public virtual ICollection<NOTE> NOTE { get; set; }
        public virtual ICollection<COURSE> COURSE1 { get; set; }
    }
}
