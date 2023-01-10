using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Book[] _Books { get; set; }

        public Library(int size = 50)
        {
            _Books = new Book[size];                                      
        }

        public Book this[int index]
        {
            get
            {
                return _Books[index];
            }
            


            set
            {
                _Books[index] = value;
            }
            
            
        }


    }
}
