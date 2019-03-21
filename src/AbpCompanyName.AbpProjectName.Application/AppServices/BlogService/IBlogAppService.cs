using Abp.Application.Services;
using AbpCompanyName.AbpProjectName.AppServers.BlogServer.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.AppServers.OrderServer
{
    public interface IBlogAppService: IApplicationService
    {
        List<BlogDto> GetList();
        void Create(BlogDto book);
    }
}
