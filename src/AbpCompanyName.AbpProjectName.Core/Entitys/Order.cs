using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;

namespace AbpCompanyName.AbpProjectName.Entitys
{
    public class Order : Entity, ISoftDelete
    {
        public DateTime CreateTime { get; set; }

        public string Address { get; set; }

        public string UserName { get; set; }

        //public List<OrderItem> Items { get; }

        public virtual ICollection<OrderItem> Items { get; }= new Collection<OrderItem>();
        public bool IsDeleted { get; set; }

        public void AddItem(Product product, int num) {
            var item = new OrderItem()
            {
                CreateTime = DateTime.Now,
                Num = num,
                Order = this,
                OrderId = this.Id,
                PId = product.Id,
                Price = product.Price,
                ProductName = product.Name
            };
            this.Items.Add(item);
        }

        public void RemoveItem(int productId)
        {
            var item = this.Items.First(w => w.PId == productId);
            Items.Remove(item);
        }

    }
}
