using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName
{
    public interface IBookAppService : IApplicationService
    {
        void Create(BookDto book);
        List<BookDto> GetTedtList();
    }
}
