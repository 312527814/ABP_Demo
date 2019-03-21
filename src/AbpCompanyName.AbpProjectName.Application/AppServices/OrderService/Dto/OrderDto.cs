using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AbpCompanyName.AbpProjectName.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.AppServices.OrderService.Dto
{
    [AutoMapTo(typeof(Order),MemberList = AutoMapper.MemberList.None)]
    [AutoMapFrom(typeof(Order), MemberList = AutoMapper.MemberList.None)]
    public class OrderDto: EntityDto
    {
        public DateTime CreateTime { get; set; }

        public string Address { get; set; }

        public string UserName { get; set; }
        public List<OrderItemDto> Items { get; set; }
    }

    public class OrderItemDto
    {

        public int ProductId { get; set; }

        public int Num { get; set; }
       
    }
}
