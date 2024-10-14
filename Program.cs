namespace GASSIGN_Bibliotekapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarerar objekt av klasser
            User user = new User();
            UserInterface ui = new UserInterface(user);

            //Kallar på metoden att köra igång Startmenyn
            ui.PrintStartMenu();
        }
    }
}
