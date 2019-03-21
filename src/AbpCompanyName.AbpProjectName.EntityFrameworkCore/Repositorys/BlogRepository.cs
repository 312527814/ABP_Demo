using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using AbpCompanyName.AbpProjectName.EntityFrameworkCore;
using AbpCompanyName.AbpProjectName.Entitys;
using AbpCompanyName.AbpProjectName.IRepositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.Repositorys
{
    public class BlogRepository : EfCoreRepository<AbpProjectNameDbContext, Blog>, IBlogRepository
    {
        public BlogRepository(IDbContextProvider<AbpProjectNameDbContext> dbContextProvider) 
            : base(dbContextProvider)
        { }
    }
}
