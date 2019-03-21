using Abp.AutoMapper;
using AbpCompanyName.AbpProjectName.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.AppServers.BlogServer.Dto
{
    [AutoMapTo(typeof(Blog),MemberList = AutoMapper.MemberList.None)]
    public class BlogDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
