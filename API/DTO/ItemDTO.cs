using Entity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class ItemDTO
    {
        public String Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public double? Price { get; set; }
        public DateTime? Date { get; set; }
        public bool? isAvailable { get; set; }
        public bool? isApproved { get; set; }
        public bool? isDeleted { get; set; }
        public int? fk_userId { get; set; }
        public  int? fk_categoryId { get; set; }
    }
}