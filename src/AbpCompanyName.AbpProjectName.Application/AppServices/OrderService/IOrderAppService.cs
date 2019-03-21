using Abp.Application.Services;
using AbpCompanyName.AbpProjectName.AppServices.OrderService.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.AppServices.OrderService
{
    public interface IOrderAppService : IApplicationService
    {
        void Create(OrderDto order);
        void GetTest(int id);
    }
}
