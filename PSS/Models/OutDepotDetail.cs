//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OutDepotDetail
    {
        public int ID { get; set; }
        public string OutNo { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string FullName { get; set; }
        public string ProductUnit { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<decimal> InPrice { get; set; }
        public Nullable<decimal> InMoney { get; set; }
        public Nullable<decimal> OutPrice { get; set; }
        public Nullable<decimal> OutMoney { get; set; }
        public string Remark { get; set; }
    }
}
