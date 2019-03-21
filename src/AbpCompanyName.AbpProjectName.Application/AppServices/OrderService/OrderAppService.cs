using AbpCompanyName.AbpProjectName.AppServices.OrderService.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using AbpCompanyName.AbpProjectName.Entitys;
using AbpCompanyName.AbpProjectName.IRepositorys;
using Abp.Domain.Repositories;
using System.Linq;
using Abp.Events.Bus;
using AbpCompanyName.AbpProjectName.EventBus.EventDatas;

namespace AbpCompanyName.AbpProjectName.AppServices.OrderService
{
    public class OrderAppService : AppService, IOrderAppService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IEventBus _eventBus;
        public OrderAppService(IOrderRepository orderRepository, IProductRepository productRepository, IEventBus eventBus)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _eventBus = eventBus;
        }
        public void Create(OrderDto order)
        {
            var entity = Mapper.Map<Order>(order);
            var productIds = order.Items.Select(s => s.ProductId).ToList();

            var products = _productRepository.GetAllList(f => productIds.Contains(f.Id));

            foreach (var item in products)
            {
                var num = order.Items.Where(w => w.ProductId == item.Id).Select(s => s.Num).First();
                item.Name = "袜子";
                entity.AddItem(item, num);
            }

            _orderRepository.Insert(entity);
        }

        public void GetTest(int id)
        {
            var entity = _orderRepository.GetOrder(id);
            _eventBus.TriggerAsync(new TestEventData() { Id = 1, EventSource = "OrderAppService.GetTest" });
        }
    }
}
