using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GASSIGN_Bibliotekapp
{
    public class UserInterface
    {
        public List<Book> books = new List<Book>()
            {
                //                  Title                            Author      Isbn  isCheckedOut
                new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 123, false),
                new Book("The Hobbit", "J.R.R. Tolkien", 456, false),
                new Book("1984", "George Orwell", 789, false)
            };
        public void PrintStartMenu(User user)
        {
            Console.WriteLine("--- Bibliotekhanteringssytem ---");
            while (true)
            {
                Console.WriteLine("\n1. Lägg till en ny bok");
                Console.WriteLine("2. Ta bort en bok enligt titel");
                Console.WriteLine("3. Sök efter en bok enligt författare");
                Console.WriteLine("4. Visa alla böcker i samlingen");
                Console.WriteLine("5. Checka ut / Returnera boken");
                Console.WriteLine("6. Avsluta programmet");
                Console.Write("Ange ditt val: ");
                string userOption = Console.ReadLine()!;

                switch (userOption)
                {
                    case "1":
                        //AddBook();
                        break;
                    case "2":
                        foreach(Book book in books)
                        {
                            Console.WriteLine($"Titel: {book.Title} Författare: {book.Author}");
                        }
                        Console.WriteLine("Skriv in titeln på boken du vill ta bort");
                        string titleToRemove = Console.ReadLine()!;

                        user.RemoveBookByTitle(books, titleToRemove);
                        break;
                    case "3":
                        Console.Write("Ange författarens namn du vill söka efter: ");
                        string userAuthor = Console.ReadLine()!;

                        user.SearchBookByAuthor(books, userAuthor);
                        break;
                    case "4":
                        //ShowAllBooks();
                        break;
                    case "5":
                        // Checka ut eller returnera en bok
                        Console.WriteLine("Tillgängliga böcker:");
                        foreach (Book book in books)
                        {
                            Console.WriteLine($"{book.Title} - Utlånad: {book.IsCheckedOut}");
                        }

                        Console.WriteLine("Skriv in titeln på boken du vill checka ut eller returnera:");
                        string title = Console.ReadLine();

                        Book selectedBook = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

                        if (selectedBook == null)
                        {
                            Console.WriteLine("Boken hittades inte.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Gå tilbaka till huvudmenyn.");
                            return;
                        }
                        Console.WriteLine("Vill du 'checka ut' eller 'returnera' boken?");
                        string action = Console.ReadLine().ToLower();

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
                        break;
                    case "6":
                        Console.WriteLine("Tack för du använde Bibliotekhanteringssytemet");
                        return;
                    default:
                        Console.WriteLine("Ogiltligt val, försök igen");
                        break;
                }
            }
        }
    }
}
