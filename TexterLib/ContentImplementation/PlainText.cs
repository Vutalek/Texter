using TexterLib.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.ContentImplementation
{
    public class PlainText : AbstractContent
    {
        private string _text;

        public PlainText(int width, string text)
        {
            _text = text;
            Width = width;
        }

        public override string Render()
        {
            List<string> chunks = _text
                .Chunk(Width)
                .Select(x => new string(x))
                .ToList();
            StringBuilder sb = new StringBuilder();
            foreach (string chunk in chunks)
                sb.AppendLine(chunk);
            return sb.ToString();
        }
    }
}
