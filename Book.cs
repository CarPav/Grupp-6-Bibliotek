using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GASSIGN_Bibliotekapp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }
        public bool IsCheckedOut { get; set; }


        //En konstruktör som tvingar oss att när vi lägger till en bok måste dessa värden fyllas i.
        public Book(string title, string author, int iSBN, bool isCheckedOut)
        {
            Title = title;
            Author = author;
            Isbn = iSBN;
            IsCheckedOut = isCheckedOut;
        }


        //En string som skrivs om för varje bok, så printar man detta så skriver den ut rätt Författare och Titel.
        public override string ToString()
        {
            return $"{Title} av {Author}";
        }
    }
}
