using System.Text;

namespace TexterLib.Content
{
    public class CompositeContent : Content
    {
        protected List<Content> _content = new List<Content>();

        public CompositeContent(int width)
        {
            base.Align(width);
        }

        public void Add(Content content)
        {
            if (content.Width > Width)
                content.Align(Width);
            _content.Add(content);
        }

        public override void Align(int width)
        {
            base.Align(width);
            foreach (Content content in _content)
                content.Align(width);
        }

        public override string Render()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Content cont in _content)
                sb.Append(cont.Render());
            return sb.ToString();
        }
    }
}
