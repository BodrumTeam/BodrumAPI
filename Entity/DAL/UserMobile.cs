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
    
    public partial class UserMobile
    {
        public int id { get; set; }
        public Nullable<int> mobile { get; set; }
        public Nullable<int> fk_userId { get; set; }
    
        public virtual User User { get; set; }
    }
}
