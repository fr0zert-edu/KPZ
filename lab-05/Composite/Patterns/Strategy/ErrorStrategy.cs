using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.Strategy.Image
{
    public class ErrorStrategy : IStrategyImage
    {
        public string Path { get; set; }
        public string Source { get; set; } = "None";
        public ErrorStrategy(string path)
        {
            this.Path = path;
        }
        public void TakeImage()
        {
            Console.WriteLine("Image not found. Check if the path is correct!");
        }
    }
}