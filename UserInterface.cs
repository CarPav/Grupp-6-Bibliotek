﻿using System;
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

        public User User { get; set; } = new User();
        public void PrintStartMenu()
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

                        User.AddBook(books);

                        break;
                    case "2":
                        User.ShowAllBooks(books);
                        Console.WriteLine("Skriv in titeln på boken du vill ta bort");
                        string titleToRemove = Console.ReadLine()!;

                        User.RemoveBookByTitle(books, titleToRemove);
                        break;
                    case "3":
                        Console.Write("Ange författarens namn du vill söka efter: ");
                        string userAuthor = Console.ReadLine()!;

                        User.SearchBookByAuthor(books, userAuthor);
                        break;
                    case "4":
                        User.ShowAllBooks(books);
                        break;
                    case "5": 
                       User.CheckoutAndReturnBook(books);
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
