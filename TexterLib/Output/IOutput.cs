using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.Output
{
    public interface IOutput
    {
        void Open();
        void Write(string str);
        void Close();
    }
}
