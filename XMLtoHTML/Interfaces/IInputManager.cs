using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLtoHTML.Services
{
    interface IInputManager
    {
        string GetPath(string prompt);
        string GetParameters(string prompt);
    }
}
