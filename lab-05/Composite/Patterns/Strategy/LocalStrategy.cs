using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.Strategy.Image
{
    public class LocalStrategy : IStrategyImage
    {
        public string Path { get; set; }
        public string Source { get; set; } = "Local foler";
        public LocalStrategy(string path) {
            this.Path = path;
        }
        public void TakeImage()
        {
            Console.WriteLine("Image source is local storage///");
        }
    }
}