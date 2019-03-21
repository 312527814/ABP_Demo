using Abp.Dependency;
using Abp.Events.Bus.Entities;
using Abp.Events.Bus.Handlers;
using AbpCompanyName.AbpProjectName.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.EventBus.EventDatas
{
    public class ProductCreatedEventData : IEventHandler<EntityCreatedEventData<Order>>, ITransientDependency
    {

        public void HandleEvent(EntityCreatedEventData<Order> eventData)
        {
            // todo
        }
    }
}
