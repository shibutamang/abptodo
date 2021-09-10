using abptodo.Entities;
using abptodo.Events;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.EventBus;

namespace abptodo.Handlers
{
    public class TaskHandler : ILocalEventHandler<EntityCreatedEventData<TodoItem>>, ITransientDependency
    {
        private readonly ILogger<TaskHandler> _logger;
        public TaskHandler(ILogger<TaskHandler> logger)
        {
            _logger = logger;
        }

        public Task HandleEventAsync(EntityCreatedEventData<TodoItem> eventData)
        {
            _logger.LogInformation("EMAIL: sent for "+eventData.Entity.Text);
            //DO SMTG ON THE EVENT
            return Task.FromResult(0);
        } 
    }
}
