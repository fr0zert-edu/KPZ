using Composite.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.Observer
{
    public class Click
    {
        public void ClickMethod(object sender, EventListenerHandler e)
        {
            if (sender is LightElementNode)
            {
                LightElementNode node = (sender as LightElementNode);
                Console.WriteLine($"Event for {node.TagName} was created.");
                Console.WriteLine(node.GetOuterHtml());
            }
        }
        public void ClickMethod2(object sender, EventListenerHandler e)
        {
            Console.WriteLine($"Hello, second event was created.");
        }
    }
}