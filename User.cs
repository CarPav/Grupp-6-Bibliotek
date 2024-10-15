using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GASSIGN_Bibliotekapp
{
    public class User
    {
        public void AddBook()
        {
            //Caroline lägger till sin kod här
        }

        public void RemoveBookByTitle(List<Book> books, string title)
        {
            //Sök igenom listan för att matcha titeln som användaren valt
            var bookToRemove = books.FirstOrDefault(book => book.Title.ToUpper() == title.ToUpper());

            if (bookToRemove != null) //Om boken hittas ta bort den från listan
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Boken {bookToRemove.Title} har tagits bort från listan.");
            }
            else //Om boken inte hittas skrivs ett felmeddelande ut
            {
                Console.WriteLine($"Ingen bok med titeln {title} hittades.");
            }

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
