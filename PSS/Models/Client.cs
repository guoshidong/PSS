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
    
    public partial class Client
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string ABC { get; set; }
        public Nullable<int> KindID { get; set; }
        public string LinkmanName { get; set; }
        public string LinkmanTel { get; set; }
        public string BankName { get; set; }
        public string BankUserName { get; set; }
        public string BankCardNo { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}
