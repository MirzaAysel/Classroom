using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._04.Exseption
{
     class RemoveAllBooksByNameException : Exception
    {
        public RemoveAllBooksByNameException() { }

        RemoveAllBooksByNameException(string message)
            :base(String.Format("Null olduğundan sizin istəyiniz yeriniə yetirilə bilməlidi.Zəhmət olmasa xətanı həll edin", message))

        {

        }
    }
}
