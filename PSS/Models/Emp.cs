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
    
    public partial class Emp
    {
        public int ID { get; set; }
        public string LoginName { get; set; }
        public string LoginPwd { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> RoleID { get; set; }
        public string Tel { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}
