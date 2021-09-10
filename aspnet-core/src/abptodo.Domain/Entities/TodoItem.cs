using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace abptodo.Entities
{
    public class TodoItem: BasicAggregateRoot<long>
    {
        public string Text { get; set; }
    }
}
