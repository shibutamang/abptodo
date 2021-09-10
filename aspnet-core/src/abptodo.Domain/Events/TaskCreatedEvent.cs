using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abptodo.Events
{
    public class TaskCreatedEvent
    {
        public string Task { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
