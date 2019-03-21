using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.Entitys
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
