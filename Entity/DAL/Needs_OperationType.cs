//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Needs_OperationType
    {
        public int id { get; set; }
        public Nullable<int> fk_itemId { get; set; }
        public Nullable<int> fk_operationId { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Operation Operation { get; set; }
    }
}
