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
    
    public partial class InDepot
    {
        public string InNo { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> DepotID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> BusinessID { get; set; }
        public Nullable<int> OperationID { get; set; }
        public Nullable<decimal> Money { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> AuditID { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
        public string AuditError { get; set; }
        public string Remark { get; set; }
    }
}
