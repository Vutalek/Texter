using TexterLib.Content;

namespace TexterLib.Parser
{
    public class Parser
    {
        private Renderer.Renderer _renderer;
        private ContentFactory.ContentFactory _contentFactory;

        private int _docwidth = 50;
        private int bracket_level = 0;
        private Stack<CompositeContent> container_stack = new Stack<CompositeContent>();

        public Parser(ContentFactory.ContentFactory contentFactory, Renderer.Renderer renderer)
        {
            _contentFactory = contentFactory;
            _renderer = renderer;
        }

        public void Parse(string line)
        {
            if (string.IsNullOrEmpty(line.Trim()))
                return;

            if (line.Trim()[0] == '!')
            {
                string[] splitted = line.Trim().Remove(0, 1).ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (splitted[0] == "docwidth")
                {
                    _docwidth = Convert.ToInt32(splitted[1]);
                    _contentFactory.SetDocWidth(_docwidth);
                    return;
                }
                else if (splitted[0] == "auto")
                {
                    _contentFactory.UpdateAuto(splitted[1], Convert.ToInt32(splitted[2]) - 1, splitted[3]);
                }
                else if (splitted[0] == "end")
                {
                    _renderer.Kill();
                    return;
                }
                else
                {
                    List<string> args = splitted.ToList();
                    string tag = args[0];
                    args.RemoveAt(0);
                    Content.Content content = _contentFactory.MakeContent(tag, args);
                    if (container_stack.Count != 0)
                    {
                        CompositeContent top = container_stack.Peek();
                        top.Add(content);
                    }
                    if (content.GetType().IsSubclassOf(typeof(CompositeContent)) ||
                        content.GetType().IsInstanceOfType(typeof(CompositeContent))
                        )
                        container_stack.Push((CompositeContent) content);
                    else if (container_stack.Count == 0)
                        _renderer.Render(content);
                    return;
                }
            }
            else if (line.Trim()[0] == '[')
            {
                bracket_level++;
                return;
            }
            else if (line.Trim()[0] == ']')
            {
                bracket_level--;
                CompositeContent content = container_stack.Pop();
                if (bracket_level == 0)
                    _renderer.Render(content);
                return;
            }
            else
            {
                Content.Content content = _contentFactory.MakeContent("text", new List<string> { _docwidth.ToString(), line.Trim() });
                if (container_stack.Count != 0)
                {
                    CompositeContent top = container_stack.Peek();
                    top.Add(content);
                }
                else
                {
                    _renderer.Render(content);
                }
            }
        }
    }
}
