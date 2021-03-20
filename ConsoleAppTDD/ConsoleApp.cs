using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTDD
{
    public class ConsoleApp
    {
        public List<string> tasks;
        public ConsoleApp()
        {
            this.tasks = new List<string>();
        }

        public void Run()
        {
            var m = string.Empty;
            m = Console.ReadLine();

            tasks.Add(m);

            ReadList(tasks);


            //test console
            //Console.WriteLine("Line {0}", m);

        }

        public void ReadList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                foreach (string word in list)
                {
                    if (word[0].ToString() == "+")
                    {
                        list.Add(word);
                        Console.WriteLine("{0} [] {1}", i + 1, word);
                    } else
                        if (word[0].ToString() == "-")
                    {
                        list.Remove(word);
                        Console.WriteLine("{0} [Suppression de la task] {1}", i + 1, word);
                    }
                    else
                    {
                        Console.WriteLine("Entrer une bonne requete");
                    }
                }
            }
            
        }
    }
}
