using TexterLib.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.ContentImplementation
{
    public class Br : AbstractContent
    {
        public Br(int width = 10) 
        {
            Width = width;
        }

        public override string Render()
        {
            return "\r\n";
        }
    }
}
