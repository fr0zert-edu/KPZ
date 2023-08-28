using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.Observer
{
    public class EventListenerHandler: EventArgs
    {
        public string Name { get; set; }
        public EventListenerHandler(string name)
        {
            this.Name = name;
        }
    }
}