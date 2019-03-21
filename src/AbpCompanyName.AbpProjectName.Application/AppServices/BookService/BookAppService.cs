using Abp.Application.Services;
using Abp.Domain.Repositories;
using AbpCompanyName.AbpProjectName.IRepositorys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Abp.Domain.Uow;

namespace AbpCompanyName.AbpProjectName
{
    public class BookAppService : AppService, IBookAppService
    {
        private readonly IBookRepository _repositoryBook;
        private readonly IUnitOfWorkManager _unitOfWorkManager;
        public BookAppService(IBookRepository repositoryBook, IUnitOfWorkManager unitOfWorkManager)
        {
            this._repositoryBook = repositoryBook;
            _unitOfWorkManager = unitOfWorkManager;
        }
        public void Create(BookDto book)
        {
            var entity = AutoMapper.Mapper.Map<Book>(book);
            //_repositoryBook.Insert(entity);
            using (var unitOfWork = _unitOfWorkManager.Begin())
            {
                _repositoryBook.Insert(entity);

                unitOfWork.Complete();
            }

           // this.CurrentUnitOfWork.SaveChanges();

        }

        public List<BookDto> GetTedtList()
        {
            throw new Exception("dada");

            var list = _repositoryBook.Test().ToList();
            var list1 = Mapper.Map<List<BookDto>>(list);
            return list1;
        }
    }
}
