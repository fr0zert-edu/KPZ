using Composite.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.State
{
    public class OuterHTMLContext
    {
        protected IHtmlState _state;
        public OuterHTMLContext(IHtmlState state) {  _state = state; }
        public string GetOuterHtml(ref string result, LightNode node)
        {
            return this._state.GetOuterHtml(ref result, node);
        }

        public void Next()
        {
            this._state.Next();
        }

        public void SetState(IHtmlState state) 
        {
            this._state = state;
        }
    }
}