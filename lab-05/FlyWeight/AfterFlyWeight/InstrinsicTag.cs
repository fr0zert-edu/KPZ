using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.AfterFlyWeight
{
    public class InstrinsicTag
    {
        public string TagName { set; get; }
        public byte TagType { set; get; } 
        public byte TagCloseType { set; get; } 

        public InstrinsicTag(string TagName, byte TagType, byte TagTypeClose) 
        { 
            this.TagName = TagName;
            this.TagType = TagType;
            this.TagCloseType = TagTypeClose;
        }
    }
}
