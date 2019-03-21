using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbpCompanyName.AbpProjectName.IRepositorys
{
    public interface IBookRepository : IRepository<Book>
    {
        IQueryable<Book> Test();
    }
}
