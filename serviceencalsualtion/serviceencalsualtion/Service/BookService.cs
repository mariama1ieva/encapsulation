using serviceencalsualtion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace serviceencalsualtion.Service
{
    internal class BookService
    {
        public Book[] GetALl()
        {
            Book book1 = new Book()
            {
                name = "Isgendername",
                author="Nizami",
                Id = 1,
                pagecount=1020

            };
            Book book2 = new Book()
            {
                name = "Be useful",
                author = "Arnold",
                Id = 2,
                pagecount = 234

            };
            Book book3 = new Book()
            {
                name = "Enough",
                author = "Cassidy",
                Id = 3,
                pagecount = 54

            };
            Book book4 = new Book()
            {
                name = "Spooky Pookie",
                author = "Sandra",
                Id = 4,
                pagecount = 140

            };
            Book[] books = { book1, book2, book3, book4 };  
            return books;

        }

        public Book[] GetBooksByAuthor(string author)
        {
            Book[] books = GetALl();
            Book[] FilteredBooks=books.Where(x=>x.author == author).ToArray();
            return FilteredBooks;
        }

        public Book GetBookById(int Id)
        {
            Book[] books = GetALl();
            Book book=books.FirstOrDefault(x=>x.Id==Id);
            return book;
        }

        public Book[] SearchByName(string name)
        {
            return GetALl().Where(x=>x.name.ToLower().Contains(name.ToLower())).ToArray();
        }

        

    }
}
