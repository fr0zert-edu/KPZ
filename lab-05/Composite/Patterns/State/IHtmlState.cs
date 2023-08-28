using Composite.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.State
{
    public interface IHtmlState
    {
        public string GetOuterHtml(ref string result,LightNode node);
        public void Next();
    }
}