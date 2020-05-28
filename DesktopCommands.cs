using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace fastTrack
{
    class DesktopCommands
    {
        // define a delegate type to match the required method signature
        delegate void desktopCommandList();

        public static void INIT(string command)
        {
            List<desktopCommandList> desktopCommand = new List<desktopCommandList>();


            // --------- ADD METHODS ----------- //

            desktopCommand.Add(writeMyLove); // 0

            // ------------------------------- //


            // --------- CALL SORTING --------- // 
            int i = 0;
            i = sortingAlgorithm(command);
            desktopCommand[i]();
            // -------------------------------- //
        }


        // --------- My own Commandlist ----------- //
        public static void writeMyLove()
        {
            Console.WriteLine("Jenny <3");
        }

        // ----------------------------------------- //



        // SORTING ALG
        public static int sortingAlgorithm(string command)
        {
            string[] commandInput = { "myLove" };

            int i = 0;
            for (; commandInput[i] != command; i++)
            {

            }
            return i;
        }
    }   
}
