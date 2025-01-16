using TexterLib.ContentImplementation;
using TexterLib.Content;

namespace UnitTests
{
    [TestClass]
    public class ContentTests
    {
        [TestMethod]
        public void PlainTextTest()
        {
            string text = "1111222233334444555566";
            int width = 4;
            string answer =
                "1111\r\n" +
                "2222\r\n" +
                "3333\r\n" +
                "4444\r\n" +
                "5555\r\n" +
                "66\r\n";
            AbstractContent test = new PlainText(width, text);
            Assert.AreEqual(answer, test.Render());
        }

        [TestMethod]
        public void CenterTest()
        {
            string text = "01234567891234";
            int width = 10;
            string answer = 
                "0123456789\r\n" +
                "   1234   \r\n";
            Center test = new Center(width);
            test.Add(new PlainText(width, text));
            Assert.AreEqual(answer, test.Render());
        }

        [TestMethod]
        public void HlineTest()
        {
            string pattern = "=-";
            int width = 10;
            string answer = "=-=-=-=-=-\r\n";
            AbstractContent test = new Hline(width, pattern);
            Assert.AreEqual(answer, test.Render());
        }

        [TestMethod]
        public void BrTest()
        {
            string answer = "\r\n";
            AbstractContent test = new Br();
            Assert.AreEqual(answer, test.Render());
        }

        [TestMethod]
        public void SimpleContainerTest()
        {
            int width = 4;
            string text = "111122223333";
            string pattern = "=-";
            string answer = 
                "1111\r\n" +
                "2222\r\n" +
                "3333\r\n" +
                "\r\n" +
                "=-=-\r\n" +
                "\r\n" +
                "1111\r\n" +
                "2222\r\n" +
                "3333\r\n";
            CompositeContent container = new CompositeContent(width);
            container.Add(new PlainText(width, text));
            container.Add(new Br());
            container.Add(new Hline(width, pattern));
            container.Add(new Br());
            container.Add(new PlainText(width, text));
            Assert.AreEqual(answer, container.Render());
        }

        [TestMethod]
        public void BoxTest()
        {
            int width = 10;
            string text = "111122223333";
            string pattern = "=-";
            string answer = 
                "╔════════╗\r\n" +
                "║11112222║\r\n" +
                "║3333    ║\r\n" +
                "║        ║\r\n" +
                "║=-=-=-=-║\r\n" +
                "║        ║\r\n" +
                "║11112222║\r\n" +
                "║3333    ║\r\n" +
                "╚════════╝\r\n";
            Box test = new Box(width, BoxStyle.DOUBLE);
            test.Add(new PlainText(width, text));
            test.Add(new Br());
            test.Add(new Hline(width, pattern));
            test.Add(new Br());
            test.Add(new PlainText(width, text));
            Assert.AreEqual(answer, test.Render());
        }
    }
}