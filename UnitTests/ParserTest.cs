using TexterLib.Input;
using TexterLib.InputImplementation;
using TexterLib.Parser;
using TexterLib.Content;
using TexterLib.ContentImplementation;
using TexterLib.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class MockRenderer : AbstractRenderer
    {
        public override void Render(AbstractContent content)
        {
            Console.Write(content.Render());
        }
    }

    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void ParseTest()
        {
            IInput input = new FileInput("../../../TestFiles/ParseTest.txt");
            Parser par = new Parser(new ContentFactoryImplementation(), new MockRenderer());
            input.Open();
            string s = null;
            while ((s = input.ReadLine()) != null)
                par.Parse(s);
            input.Close();
        }
    }
}
