using Abp.EntityFrameworkCore;
using AbpCompanyName.AbpProjectName.EntityFrameworkCore;
using AbpCompanyName.AbpProjectName.Entitys;
using AbpCompanyName.AbpProjectName.IRepositorys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AbpCompanyName.AbpProjectName.Repositorys
{
    public class OrderRepository : EfCoreRepository<AbpProjectNameDbContext, Order>, IOrderRepository
    {
        public OrderRepository(IDbContextProvider<AbpProjectNameDbContext> dbContextProvider)
            : base(dbContextProvider)
        { }

        public Order GetOrder(int id)
        {
            var order = Context.Order.FirstOrDefault(b => b.Id == id);
            return order;
        }
        public override void Delete(Order entity)
        {
            entity.Items.AsEnumerable();
            base.Delete(entity);
        }
    }
}
