namespace GASSIGN_Bibliotekapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarerar objekt av klasser
            UserInterface userInterface = new UserInterface();

            //Kallar på metoden att köra igång Startmenyn
            userInterface.PrintStartMenu();
        }
    }
}
