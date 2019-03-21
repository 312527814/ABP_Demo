using Abp.Dependency;
using Abp.Events.Bus.Handlers;
using AbpCompanyName.AbpProjectName.EventBus.EventDatas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.EventBus.EventHandlers
{
    class TestEventHandler : IEventHandler<TestEventData>, ITransientDependency
    {
        public void HandleEvent(TestEventData eventData)
        {
            //WriteActivity("A task is completed by id = " + eventData.TaskId);

            // Abp.Events.Bus.Entities.EntityCreatingEventData<Product>
        }
    }
}
