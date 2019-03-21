using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.Repositorys
{
    public class EfCoreRepository<TDbContext, TEntity> : EfCoreRepositoryBase<TDbContext, TEntity>
        where TDbContext : DbContext
        where TEntity : class, IEntity<int>
    {
        public EfCoreRepository(IDbContextProvider<TDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
