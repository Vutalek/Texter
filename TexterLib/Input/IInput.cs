using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.Input
{
    public interface IInput
    {
        void Open();
        string ReadLine();
        void Close();
    }
}
