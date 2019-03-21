using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName
{
    [AutoMapFrom(typeof(Book))]
    public class BookDto : EntityDto
    {
        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public decimal Price { get; set; }
    }
}
