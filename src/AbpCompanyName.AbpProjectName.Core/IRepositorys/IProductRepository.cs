using Abp.Domain.Repositories;
using AbpCompanyName.AbpProjectName.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.IRepositorys
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetOrder(int id);
    }
}
