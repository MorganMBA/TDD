using System;
using System.Text;

namespace ConsoleAppTDD
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder rules = new StringBuilder();
            rules.Append("Les fonctionnalités sont:\n + <texte> Ajoute une tâche");
            rules.Append("\n- <numéro> Supprimer une tâche");
            rules.Append("\n- <numéro> Supprimer une tâchex <numéro> Passer la tâche correspondant au numéro en 'fait'");
            Console.WriteLine(rules);

            Console.WriteLine("\n entrer votre tâche");
            ConsoleApp consoleApp = new ConsoleApp();

            consoleApp.Run();

        }

        
    }
}
