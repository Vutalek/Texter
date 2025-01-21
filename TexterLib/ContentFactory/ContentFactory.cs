using TexterLib.Content;
using TexterLib.ContentImplementation;

namespace TexterLib.ContentFactory
{
    public class ContentFactory
    {
        private int _docwidth = 50;

        private Dictionary<string, List<string>> _auto = new Dictionary<string, List<string>>
        {
            {"text", new List<string> {"50", "auto"} },
            {"container", new List<string> {"50"} },
            {"hline", new List<string> {"50", "-"} },
            {"center", new List<string> {"50"} },
            {"br", new List<string> {"50"} },
            {"box", new List<string> {"50", "0"} }
        };
        public void UpdateAuto(string tag, int arg, string value)
        {
            try
            {
                _auto[tag][arg] = value;
            }
            catch
            {
                return;
            }
        }

        public List<string> ApplyAuto(string tag, List<string> args)
        {
            List<string> auto = _auto[tag];
            List<string> result = args;
            for (int i = 0; i < auto.Count; i++)
            {
                if (args.Count <= i)
                    result.Add(auto[i]);
                else if (result[i] == "auto")
                    result[i] = auto[i];
            }
            try
            {
                if (Convert.ToInt32(result[0]) > Convert.ToInt32(auto[0]))
                    result[0] = auto[0];
            }
            catch
            {
                result[0] = auto[0];
            }
            return result;
        }

        public void SetDocWidth(int docwidth)
        {
            _docwidth = docwidth;
            foreach (string item in _auto.Keys)
                _auto[item][0] = docwidth.ToString();
        }

        // args: 0 element is always a width
        public Content.Content MakeContent(string tag, List<string> args)
        {
            List<string> actual_args = ApplyAuto(tag, args);

            //args: 1 element is a text
            if (tag == "text")
                return new PlainText(Convert.ToInt32(actual_args[0]), actual_args[1]);
            else if (tag == "container")
                return new CompositeContent(Convert.ToInt32(actual_args[0]));
            //args: 1 element is a pattern
            else if (tag == "hline")
                return new Hline(Convert.ToInt32(actual_args[0]), actual_args[1]);
            //args: 1 element is a text
            else if (tag == "center")
                return new Center(Convert.ToInt32(actual_args[0]));
            else if (tag == "br")
                return new Br();
            //args: 1 element is a style of a box
            else if (tag == "box")
                return new Box(Convert.ToInt32(actual_args[0]), (BoxStyle)Convert.ToInt32(actual_args[1]));
            else
                return new Br();
        }
    }
}
