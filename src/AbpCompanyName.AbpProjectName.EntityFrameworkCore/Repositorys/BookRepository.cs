using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using AbpCompanyName.AbpProjectName.EntityFrameworkCore;
using AbpCompanyName.AbpProjectName.IRepositorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AbpCompanyName.AbpProjectName.Repositorys
{
    public class BookRepository : EfCoreRepository<AbpProjectNameDbContext, Book>, IBookRepository
    {
        public BookRepository(IDbContextProvider<AbpProjectNameDbContext> dbContextProvider) : base(dbContextProvider) { }

        public IQueryable<Book> Test()
        {
           return this.Context.Book.Where(w => w.Id == 1);
        }
    }
}
