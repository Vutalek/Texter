namespace TexterLib.ContentImplementation
{
    public class Hline : Content.Content
    {
        string _pattern;
        
        public Hline(int width, string pattern)
        {
            _pattern = pattern;
            Width = width;
        }

        public override string Render()
        {
            string line = string.Concat(Enumerable.Repeat(_pattern, Width));
            return line.Substring(0, Width) + "\r\n";
        }
    }
}
