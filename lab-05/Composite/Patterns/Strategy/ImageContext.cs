using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.Strategy.Image
{
    public class ImageContext
    {
        public string Source { get; set; }

        private IStrategyImage _startegy;
        public ImageContext() 
        {
        }
        public void SetStrategy(IStrategyImage strategy)
        { 
            this._startegy = strategy;
            this.Source = this._startegy.Source;
        }
        public void UseStrategy() 
        {
            if(this._startegy != null)
                this._startegy.TakeImage();
        }
    }   
}