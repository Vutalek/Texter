using TexterLib.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.ContentFactory
{
    public interface IContentFactory
    {
        // args: 0 element is always a width
        AbstractContent MakeContent(string tag, List<string> args);
    }
}
