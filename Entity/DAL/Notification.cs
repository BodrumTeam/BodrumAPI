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
    
    public partial class Notification
    {
        public int id { get; set; }
        public string msg { get; set; }
        public Nullable<bool> isSeen { get; set; }
        public Nullable<int> from_userId { get; set; }
        public Nullable<int> to_userId { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<int> fk_userCommentOnItem { get; set; }
    
        public virtual UserCommentOnItem UserCommentOnItem { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}