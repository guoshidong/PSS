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
    
    public partial class Menu
    {
        public int ID { get; set; }
        public string MenuName { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public Nullable<double> OrderIndex { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}
