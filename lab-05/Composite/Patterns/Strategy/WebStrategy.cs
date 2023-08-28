using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.Strategy.Image
{
    public class WebStrategy : IStrategyImage
    {
        public string Path { get; set; }
        public string Source { get; set; } = "Web";
        public WebStrategy(string path) {
            this.Path = path;
        }
        public void TakeImage()
        {
            Console.WriteLine("Image was downloaded from web///");
        }
    }
}