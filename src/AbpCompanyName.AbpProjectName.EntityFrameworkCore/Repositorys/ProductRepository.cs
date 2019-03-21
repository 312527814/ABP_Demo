using Abp.EntityFrameworkCore;
using AbpCompanyName.AbpProjectName.EntityFrameworkCore;
using AbpCompanyName.AbpProjectName.Entitys;
using AbpCompanyName.AbpProjectName.IRepositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.Repositorys
{
    public class ProductRepository : EfCoreRepository<AbpProjectNameDbContext, Product>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<AbpProjectNameDbContext> dbContextProvider)
            : base(dbContextProvider)
        { }
    }
}
