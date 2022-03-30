using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Models;

namespace ConsoleApp.Interface
{
    public interface IPerson
    {
         string Name { get; set; }
         int Age { get; set; }

         string ShowInfo();
       
        
    }
}
