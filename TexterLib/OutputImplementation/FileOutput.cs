using TexterLib.Output;

namespace TexterLib.OutputImplementation
{
    public class FileOutput : IOutput
    {
        private string _path;
        private StreamWriter _stream;

        public FileOutput(string path)
        {
            _path = path;
        }

        public void Open()
        {
            _stream = File.CreateText(_path);
        }

        public void Write(string str)
        {
            _stream.Write(str);
        }

        public void Close()
        {
            _stream.Close();
        }
    }
}
