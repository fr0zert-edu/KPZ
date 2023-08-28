using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.Strategy.Image
{
    public interface IStrategyImage
    {
        public string Path { get; set; }
        public string Source { get; set; }
        public void TakeImage();
    }
}