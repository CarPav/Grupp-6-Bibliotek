using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GASSIGN_Bibliotekapp
{
    public class Books
    {
        public string title { get; set; }
        public string author { get; set; }
        public int ISBN { get; set; }
        public bool isCheckedOut { get; set; }
    }
}
