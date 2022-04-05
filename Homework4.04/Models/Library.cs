using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4._04.Exseption;

namespace Homework4._04.Models
{
    internal class Library
    {
        private object i;
        public List<Book> Books { get; set; }

      
        public void FindAllBooksByName(string  name)
        {
          
            Books.Find(x => x.Name == name);
            if (name == null)
            {
                throw new FindAllBooksByNameException();
            }
            else if(name!=null)
            {
                Console.WriteLine(Books);
            }
                       
        }
        public void RemoveAllBooksByName(string authorname)
        {
          if(authorname==null)
            {
                throw new RemoveAllBooksByNameException();
            }
          else if (authorname!=null)
            {
                Books.RemoveAll(x => x.AuthorName == authorname);
            }
        }    
        
        public  List<Book> SearchBooks(string name)
        {

            Books.Find(x => x.Name == name);
            return Books;
        }
        public void FindAllBooksByPageCountRange(int minpagecount, int maxpagecount)
        {
            if (minpagecount>50)
            {
                if (maxpagecount<500)
                {
                  Console.WriteLine(Books);
                }
            }
        }
        public void RemoveBookByCode(string value)
        {
            Books.RemoveAll(x => x.Code.Contains(value));
            
        }


    }
}
