using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AbpCompanyName.AbpProjectName.Entitys
{
    public class OrderItem : Entity, ISoftDelete
    {
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public int PId { get; set; }
        public string ProductName { get; set; }

        ////[ForeignKey("PIdWW")]
        //public virtual Product Product { get; set; } 

        public int Num { get; set; }

        public decimal Price { get; set; }

        public DateTime CreateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
