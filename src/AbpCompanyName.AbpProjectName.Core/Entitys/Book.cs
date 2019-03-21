using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AbpCompanyName.AbpProjectName
{
    [Table("Book")]
    public class Book : Entity
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }


        public DateTime PublishDate { get; set; }

        public decimal Price { get; set; }
    }
}
