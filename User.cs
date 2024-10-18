using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace GASSIGN_Bibliotekapp
{
    public class User
    {
        public void AddBook(List<Book> books)
        {
            Console.Write("Bokens titel: ");

            string addTitle = Console.ReadLine()!;

            Console.Write("Bokens författare: ");
            string addAuthor = Console.ReadLine()!;

            Console.Write("Bokens ISBN-nummer: ");
            int addIsbn = Convert.ToInt32(Console.ReadLine()!);

            Book bookToAdd = new Book(addTitle, addAuthor, addIsbn, false);
            books.Add(bookToAdd);

            Console.WriteLine($"Din bok med titeln {bookToAdd.Title} har lagts till i listan.");

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

        public void ShowAllBooks(List<Book> books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
            }
        }

        public void CheckoutAndReturnBook(List<Book> books)
        {
            // Visa alla böcker och deras utlåningsstatus
            Console.WriteLine("Tillgängliga böcker:");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title} - Utlånad: {book.IsCheckedOut}");
            }

            // Be användaren att skriva in titeln på boken de vill checka ut eller returnera
            Console.WriteLine("Skriv in titeln på boken du vill checka ut eller returnera:");
            string title = Console.ReadLine();

            // Hitta boken användaren angav
            Book selectedBook = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (selectedBook == null)
            {
                Console.WriteLine("Boken hittades inte.");
                return;
            }

            // Fråga om användaren vill checka ut eller returnera boken
            Console.WriteLine("Vill du 'checka ut' eller 'returnera' boken?");
            string action = Console.ReadLine().ToLower();

            // Enkel hantering av att checka ut eller returnera boken
            if (action == "checka ut")
            {
                if (selectedBook.IsCheckedOut)
                {
                    Console.WriteLine("Boken är redan utlånad.");
                }
                else
                {
                    selectedBook.IsCheckedOut = true;
                    Console.WriteLine($"Du har nu checkat ut boken: {selectedBook.Title}");
                }
            }
            else if (action == "returnera")
            {
                if (!selectedBook.IsCheckedOut)
                {
                    Console.WriteLine("Boken är inte utlånad.");
                }
                else
                {
                    selectedBook.IsCheckedOut = false;
                    Console.WriteLine($"Du har nu returnerat boken: {selectedBook.Title}");
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
            }
        }

    }
}
