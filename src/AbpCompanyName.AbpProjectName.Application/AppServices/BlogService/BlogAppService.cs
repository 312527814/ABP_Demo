using Abp.Application.Services;
using AbpCompanyName.AbpProjectName.AppServers.BlogServer.Dto;
using AbpCompanyName.AbpProjectName.IRepositorys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using AbpCompanyName.AbpProjectName.Entitys;

namespace AbpCompanyName.AbpProjectName.AppServers.OrderServer
{
    public class BlogAppService : ApplicationService, IBlogAppService
    {
        private IBlogRepository _blogRepository;
        public BlogAppService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public List<BlogDto> GetList() {
            var list = _blogRepository.GetAllIncluding(e => e.Posts).ToList();
            return Mapper.Map<List<BlogDto>>(list);
            return null;

        }

        public void Create(BlogDto book)
        {
            var entity = AutoMapper.Mapper.Map<Blog>(book);
            _blogRepository.Insert(entity);

        }
    }
}
