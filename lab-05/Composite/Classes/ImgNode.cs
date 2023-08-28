using Composite.Classes;
using Composite.Interfaces;
using Composite.Patterns.Observer;
using Composite.Patterns.Strategy.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Classes_Node
{
    public class ImgNode : LightNode
    {
        public string TagName { set; get; } = "img";
        public byte TagType { set; get; } = 0;
        public byte TagCloseType { set; get; } = 0;
        public string Src { set; get; }
        private ImageContext _context;
        public Style? Style { set; get; }
        public ImgNode(string Path)
        {
            this.Src = Path;
            this._context = new ImageContext();
            if (ImageChecker.IsLink(this.Src) == true)
            {
                this._context.SetStrategy(new WebStrategy(this.Src));
            }
            else if (ImageChecker.IsFilePath(this.Src) == true)
            {
                this._context.SetStrategy(new LocalStrategy(this.Src));
            }
            else
            {
                this._context.SetStrategy(new ErrorStrategy(this.Src));
            }
        }

        public override string GetOuterHtml()
        {
            this._context.UseStrategy();
            StringBuilder tag = new StringBuilder();
            tag.Append($"<{this.TagName} src=\"{this.Src}\" my_source=\"{this._context.Source}\" {this.Style?.ToString()}/>\n");
            return tag.ToString();
        }

        public override IClone Clone()
        {
            throw new NotImplementedException();
        }
    }
}