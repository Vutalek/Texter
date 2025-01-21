using TexterLib.Input;
using TexterLib.InputImplementation;
using TexterLib.Parser;
using TexterLib.Content;
using TexterLib.Renderer;
using TexterLib.ContentFactory;

namespace UnitTests
{
    public class MockRenderer : Renderer
    {
        public override void Render(Content content)
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
            Parser par = new Parser(new ContentFactory(), new MockRenderer());
            input.Open();
            string s = null;
            while ((s = input.ReadLine()) != null)
                par.Parse(s);
            input.Close();
        }
    }
}
