using TexterLib.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.InputImplementation
{
    public class FileInput : IInput
    {
        private string _path;
        private StreamReader _stream;

        public FileInput(string path)
        {
            _path = path;
        }

        public void Open()
        {
            _stream = File.OpenText(_path);
        }

        public string ReadLine()
        {
            return _stream.ReadLine();
        }

        public void Close()
        {
            _stream.Close();
        }
    }
}
