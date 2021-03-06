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
    
    public partial class Product
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string ProductName { get; set; }
        public string ProductFormat { get; set; }
        public string ProductModel { get; set; }
        public string ProductUnit { get; set; }
        public string ABC { get; set; }
        public Nullable<int> KindID { get; set; }
        public Nullable<decimal> InPrice { get; set; }
        public Nullable<decimal> OutPrice { get; set; }
        public Nullable<int> Warning { get; set; }
        public Nullable<double> OrderIndex { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}
