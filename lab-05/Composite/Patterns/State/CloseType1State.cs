using Composite.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite.Patterns.State
{
    public class CloseType1State : IHtmlState
    {
        protected OuterHTMLContext Context;
        public string GetOuterHtml(ref string result,LightNode ode)
        {
            LightElementNode node = (LightElementNode)ode;
            StringBuilder tag = new StringBuilder();

            if (node.TagCloseType == 1)
            {
                tag.Append($"<{node.TagName}{node.Style?.ToString()}>\n");
                if (node.Nodes != null)
                {
                    foreach (var nod in node.Nodes)
                    {
                        if (nod is LightTextNode)
                            tag.Append(nod.GetContent());
                        else
                            tag.Append(nod.GetOuterHtml());
                    }
                }
                tag.Append($"</{node.TagName}>\n");
            }
            return result = tag.ToString();
        }

        public void Next()
        {
            if (Context != null)
            {
                this.Context.SetState(new CloseType0State());
            }
        }

        public void SetContext(OuterHTMLContext context) {
            this.Context = context;
        }
    }
}