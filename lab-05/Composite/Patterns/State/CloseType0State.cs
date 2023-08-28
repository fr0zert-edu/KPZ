using Composite.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.State
{
    public class CloseType0State : IHtmlState
    {
        public string GetOuterHtml(ref string result,LightNode ode)
        {
            LightElementNode node = (LightElementNode)ode;
            StringBuilder tag = new StringBuilder();
            if (node.TagCloseType == 0)
            {
                tag.Append($"<{node.TagName} {node.Style?.ToString()}/>\n");
            }
            result = tag.ToString();
            return tag.ToString();
        }

        public void Next()
        {
            //no-op
        }
    }
}