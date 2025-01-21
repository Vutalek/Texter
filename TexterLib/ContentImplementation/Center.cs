using System.Text;
using TexterLib.Content;

namespace TexterLib.ContentImplementation
{
    public class Center : CompositeContent
    {
        public Center(int width) : base(width) { }

        public override string Render()
        {
            string raw = base.Render();
            string[] inner_content = raw.Substring(0, raw.LastIndexOf("\r\n")).Split("\r\n");
            StringBuilder sb = new StringBuilder();
            foreach (string line in inner_content)
            {
                if (line.Length == Width)
                    sb.AppendLine(line);
                else
                {
                    string centered_line = "";
                    int right = (Width - line.Length) / 2;
                    int left = Width - line.Length - right;
                    centered_line += new String(' ', left);
                    centered_line += line;
                    centered_line += new String(' ', right);
                    sb.AppendLine(centered_line);
                }
            }
            return sb.ToString();
        }
    }
}
