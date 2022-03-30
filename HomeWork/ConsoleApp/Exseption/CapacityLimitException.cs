using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Exseption
{
    class CapacityLimitException : Exception
    {
        
    public CapacityLimitException() { }

        CapacityLimitException(string message)
            : base(String.Format("There is no place for a new employee.: {51}", message))
        {

        }
    }
}

