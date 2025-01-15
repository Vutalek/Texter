using TexterLib.Content;
using TexterLib.ContentFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.ContentImplementation
{
    public class ContentFactoryImplementation : IContentFactory
    {
        public AbstractContent MakeContent(string tag, List<string> args)
        {
            //args: 1 element is a text
            if (tag == "text")
                return new PlainText(Convert.ToInt32(args[0]), args[1]);
            else if (tag == "container")
                return new CompositeContent(Convert.ToInt32(args[0]));
            //args: 1 element is a pattern
            else if (tag == "hline")
                return new Hline(Convert.ToInt32(args[0]), args[1]);
            //args: 1 element is a text
            else if (tag == "center")
                return new Center(Convert.ToInt32(args[0]));
            else if (tag == "br")
                return new Br();
            //args: 1 element is a style of a box
            else if (tag == "box")
                return new Box(Convert.ToInt32(args[0]), (BoxStyle)Convert.ToInt32(args[1]));
            else
                return new Br();
        }
    }
}
