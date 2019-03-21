using AbpCompanyName.AbpProjectName.AppServers.OrderServer;
using AbpCompanyName.AbpProjectName.AppServices.OrderService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AbpCompanyName.AbpProjectName.AppServices.OrderService.Dto;

namespace AbpCompanyName.AbpProjectName.Web.Controllers
{
    public class HomeController : AbpProjectNameControllerBase
    {
        private readonly IBookAppService _bookAppService;
        private readonly IBlogAppService _blogAppService;
        private readonly IOrderAppService _orderAppService;
        public HomeController(IBookAppService bookAppService, IBlogAppService blogAppService, IOrderAppService orderAppService)
        {
            _bookAppService = bookAppService;
            _blogAppService = blogAppService;
            _orderAppService = orderAppService;
        }
        public ActionResult Index()
        {
            //_bookAppService.Create(new BookDto
            //{
            //    Name = "张三1",
            //    Price = 200,
            //    PublishDate = DateTime.Now
            //});
            // _bookAppService.GetTedtList();
            //_blogAppService.GetList();
            //_blogAppService.Create(new AppServers.BlogServer.Dto.BlogDto {
            //    CreateTime = DateTime.Now,
            //    Url = "http://"
            //});
            _orderAppService.Create(
                new OrderDto
                {
                    Address = "北京",
                    CreateTime = DateTime.Now,
                    UserName = "张三",
                    Items = new List<OrderItemDto> {
                            new OrderItemDto{
                                 Num=2,
                                 ProductId=6,
                            }
                        }
                }
                );

            _orderAppService.GetTest(15);

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}