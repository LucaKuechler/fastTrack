using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace fastTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // DEF VARIABELS
                string inputUserTotal;
                string enviorment;
                string parameter;
                string command;
                //string commandInput;

                // USER Input
                Console.Write("L--> ");
                inputUserTotal = Console.ReadLine();

                // STORE INPUT AND SPLIT IN SINGLE WORDS
                string[] words = inputUserTotal.Split(' ');
                Array.Resize(ref words, 100);

                try
                {
                    enviorment = words[0].ToUpper();
                }
                catch
                {
                    Console.WriteLine("Fehler du Mumpets");
;                    continue;
                }


                enviorment = words[0].ToUpper();

                if(words[1] == null)
                {
                    command = " ";
                }
                else
                {
                    command = words[1];
                }


                //CHECK IF IT IS "WEB COMMAND" OR "DESKTOP COMMAND"
                try
                {
                    if (enviorment == "WEB")
                    {
                        WebCommands.INIT(command);
                    }
                    else if (enviorment == "DESK")
                    {
                        DesktopCommands.INIT(command);
                    }
                    else if (enviorment == "CLS")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Fehler du Mongo!");
                    }
                }
                catch
                {
                    continue;
                }
            }
        }  
    }
}
