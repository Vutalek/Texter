using System.Text;

namespace TexterLib.ContentImplementation
{
    public class PlainText : Content.Content
    {
        private string _text;

        public PlainText(int width, string text)
        {
            _text = text;
            base.Align(width);
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
