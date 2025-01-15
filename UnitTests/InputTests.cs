using TexterLib.Input;
using TexterLib.InputImplementation;

namespace UnitTests
{
    [TestClass]
    public class InputTests
    {
        [TestMethod]
        public void FileInputTest()
        {
            IInput input = new FileInput("../../../TestFiles/TextFile1.txt");
            input.Open();
            string s = null;
            List<string> lines = new List<string>();
            while ((s = input.ReadLine()) != null)
                lines.Add(s);
            input.Close();
            Assert.AreEqual(lines.Count, 2);
            Assert.AreEqual(lines[0], "This is a test of file input.");
            Assert.AreEqual(lines[1], "Good Luck!");
        }
    }
}
