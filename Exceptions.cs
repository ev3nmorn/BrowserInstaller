using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserInstaller
{
    class WrongFileException : Exception
    {
        public WrongFileException(string message)
        : base(message)
        { }
    }
}
