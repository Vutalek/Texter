using TexterLib.Renderer;
using TexterLib.Content;
using TexterLib.ContentImplementation;
using TexterLib.ContentFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.Parser
{
    public class Parser
    {
        private AbstractRenderer _renderer;
        private IContentFactory _contentFactory;

        private int doc_width = 50;
        private int bracket_level = 0;
        private Stack<CompositeContent> container_stack = new Stack<CompositeContent>();

        public Parser(IContentFactory contentFactory, AbstractRenderer renderer)
        {
            _contentFactory = contentFactory;
            _renderer = renderer;
        }

        public void Parse(string line)
        {
            if (line.Trim()[0] == '!')
            {
                string[] splitted = line.Trim().Remove(0, 1).ToLower().Split(' ');
                if (splitted[0] == "docwidth")
                {
                    doc_width = Convert.ToInt32(splitted[1]);
                    return;
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
                    AbstractContent content = _contentFactory.MakeContent(tag, args);
                    if (container_stack.Count != 0)
                    {
                        CompositeContent top = container_stack.Peek();
                        top.Add(content);
                    }
                    if (content.GetType().IsSubclassOf(typeof(CompositeContent)) ||
                        content.GetType().IsInstanceOfType(typeof(CompositeContent))
                        )
                        container_stack.Push((CompositeContent) content);
                    else
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
                AbstractContent content = _contentFactory.MakeContent("text", new List<string> { doc_width.ToString(), line.Trim() });
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
