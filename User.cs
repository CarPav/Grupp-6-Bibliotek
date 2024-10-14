using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GASSIGN_Bibliotekapp
{
    public class User
    {
        //Kopplar ihop User med UserInterface så vi kan kalla på metoder i Interface från våran User.
        public UserInterface UserInterface { get; set; }

        public void AddBook()
        {
            //Caroline lägger till sin kod här
        }

        public void RemoveBookByTitle()
        {
            //Felicia lägger till sin kod här
        }

        public void SearchBookByAuthor(List<Book> books, string author)
        {
            //Gör en lista av alla böcker som har samma författare som användare angav
            var foundBooks = books.Where(b => b.Author.ToUpper() == author.ToUpper()).ToList();

            //Om värdet är 0 så skriver den ut felmeddelande
            if (foundBooks.Count == 0)
            {
                Console.WriteLine($"Inga böcker av författaren {author} hittades.");
            }
            else // Annars så skriver den ut varje bok som författaren har
            {
                Console.WriteLine($"Våra böcker av {author}:");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine($"- {book.Title}");
                }
            }
        }

        public void ShowAllBooks()
        {
            //Andreas lägger till sin kod här
        }

        public void CheckoutAndReturnBook()
        {
            //Ayub lägger till sin kod här
        }
    }
}
