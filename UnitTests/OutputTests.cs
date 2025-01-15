using TexterLib.Input;
using TexterLib.InputImplementation;
using TexterLib.Output;
using TexterLib.OutputImplementation;

namespace UnitTests
{
    [TestClass]
    public class OutputTests
    {
        [TestMethod]
        public void FileOutputTest()
        {
            IOutput output = new FileOutput("../../../TestFiles/TextFile2.txt");
            output.Open();
            string s = "1234    \r\n";
            output.Write(s);
            output.Close();

            IInput input = new FileInput("../../../TestFiles/TextFile2.txt");
            input.Open();
            s = null;
            List<string> lines = new List<string>();
            while ((s = input.ReadLine()) != null)
                lines.Add(s);
            input.Close();

            Assert.AreEqual(lines.Count, 1);
            Assert.AreEqual(lines[0], "1234    ");
        }
    }
}
