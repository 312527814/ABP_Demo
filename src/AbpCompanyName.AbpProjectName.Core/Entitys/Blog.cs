using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AbpCompanyName.AbpProjectName.Entitys
{
    [Table("Blogs")]
    public class Blog : Entity
    {
        public Blog()
        {
            //Posts = new HashSet<Post>();
        }
        public string Url { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
