namespace GASSIGN_Bibliotekapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar listan för alla böcker och lägger även in 3 böcker från start.
            List<Book> books = new List<Book>()
            {
                //                  Title                            Author      Isbn  isCheckedOut
                new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 123, false),
                new Book("The Hobbit", "J.R.R. Tolkien", 456, false),
                new Book("1984", "George Orwell", 789, false)
            };

            //Kallar på metoden att köra igång Startmenyn
            UserInterface.PrintStartMenu();
        }
    }
}
