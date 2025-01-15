using TexterLib.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.ContentImplementation
{
    public class CompositeContent : AbstractContent
    {
        protected List<AbstractContent> _content = new List<AbstractContent>();

        public CompositeContent(int width)
        {
            Width = width;
        }

        public void Add(AbstractContent content)
        {
            if (content.Width > Width)
                 content.Width = Width;
            _content.Add(content);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (AbstractContent cont in _content)
                sb.Append(cont.ToString());
            return sb.ToString();
        }
    }
}
