using abptodo.DTOs;
using abptodo.Entities;
using abptodo.Events;
using abptodo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Local;

namespace abptodo.Services
{
    public class TodoAppService : ApplicationService, ITodoAppService
    {
        private readonly IRepository<TodoItem, long> _todoItemRepository;
        private readonly ILocalEventBus _localEventBus;

        public TodoAppService(IRepository<TodoItem, long> todoItemRepository, ILocalEventBus localEventBus)
        {
            _todoItemRepository = todoItemRepository;
            _localEventBus = localEventBus;
        }

        public async Task<TodoItemDto> CreateAsync(string text)
        {
            var todoItem = await _todoItemRepository.InsertAsync(
               new TodoItem { Text = text }
           );

            //PUBLISH THE EVENT
            //await _localEventBus.PublishAsync(
            //    new TaskCreatedEvent
            //    {
            //        Task = text,
            //        CreatedOn = DateTime.UtcNow
            //    }
            //);

            return new TodoItemDto
                    {
                        Id = todoItem.Id,
                        Text = todoItem.Text
                    };
        }

        public async Task<TodoItemDto> UpdateAsync(long id, TodoItemDto item)
        { 
            var todoItem = await _todoItemRepository.GetAsync(id);

            todoItem.Text = item.Text;
            await _todoItemRepository.UpdateAsync(todoItem);

            return new TodoItemDto
            {
                Id = todoItem.Id,
                Text = todoItem.Text
            };
        }

        public  async Task DeleteAsync(long id)
        {
            await _todoItemRepository.DeleteAsync(id);
        }

        public async Task<List<TodoItemDto>> GetListAsync()
        {
            var items = await _todoItemRepository.GetListAsync();
            return items
                .Select(item => new TodoItemDto
                {
                    Id = item.Id,
                    Text = item.Text
                }).ToList();
        }

        // TODO: Implement the methods here...
    }
}
