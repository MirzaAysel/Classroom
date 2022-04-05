using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._04.Exseption
{


    class FindAllBooksByNameException : Exception
    {

        public FindAllBooksByNameException() { }
        
           FindAllBooksByNameException(string message)
                : base(String.Format("The oath you entered is incorrect. Please make the right choice.", message))
             

        {
        }

         


    }
}

    


