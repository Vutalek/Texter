using TexterLib.Content;
using System.Text;

namespace TexterLib.ContentImplementation
{
    public enum BoxStyle
    {
        LIGHT,
        HEAVY,
        DOUBLE
    }

    public class Box : CompositeContent
    {
        private static string[] _styles = ["─│┌┐└┘", "━┃┏┓┗┛", "═║╔╗╚╝"];
        private BoxStyle _boxStyle;

        public Box(int width, BoxStyle style) : base(width)
        {
            _boxStyle = style;
        }

        public override string Render()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(
                _styles[(int)_boxStyle][2] + 
                new string(_styles[(int)_boxStyle][0], Width - 2) + 
                _styles[(int)_boxStyle][3]
                );
            foreach (Content.Content content in _content)
                content.Width = this.Width - 2;
            string raw = base.Render();
            string[] inner_content = raw.Substring(0, raw.LastIndexOf("\r\n")).Split("\r\n");
            foreach (string line in inner_content)
            {
                sb.AppendLine(
                    _styles[(int)_boxStyle][1] +
                    line + new string(' ', Width - 2 - line.Length) +
                    _styles[(int)_boxStyle][1]
                    );
            }
            sb.AppendLine(
                _styles[(int)_boxStyle][4] +
                new string(_styles[(int)_boxStyle][0], Width - 2) +
                _styles[(int)_boxStyle][5]
                );
            return sb.ToString();
        }
    }
}
