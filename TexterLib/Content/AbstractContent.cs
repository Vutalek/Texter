using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.Content
{
    public abstract class AbstractContent
    {
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public abstract string Render();
    }
}
