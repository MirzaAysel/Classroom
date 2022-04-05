using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._04.Models
{
    internal class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public Book()
        {

        }
        public Book(string name, string authorname)
        {
            Name = name;
            AuthorName = authorname;

        }
        public Book(string name, string authorname, int pagecount, string code):this(name,authorname)
        {
            PageCount = pagecount;
            Code = code;
        }
    }
}
