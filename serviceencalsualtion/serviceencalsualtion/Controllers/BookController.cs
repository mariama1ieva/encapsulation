using serviceencalsualtion.Models;
using serviceencalsualtion.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceencalsualtion.Controllers
{
    internal class BookController
    { 

        private BookService bookService;
        public BookController()
        {
            bookService = new BookService();
        }
        public void GetAllAuthor()
        {
            string authorName = "Nizami";


            Book[] result = bookService.GetBooksByAuthor(authorName);
            foreach( var item in result )
            {
                Console.WriteLine($"{item.name},{item.author}");
            }

        }
        public void GetbyId()
        {
            int Id = 3;

            
             var  result = bookService.GetBookById(Id);
            Console.WriteLine(result.name,result.author);
        }

        public void SearchName()
        {
            var result = bookService.SearchByName("o");
            foreach( var item in result )
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
