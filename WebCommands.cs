using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace fastTrack
{
    public static class WebCommands
    {
        // define a delegate type to match the required method signature
        delegate void webCommandList();

        public static void INIT(string command)
        {
            List<webCommandList> webCommand = new List<webCommandList>();


            // --------- ADD METHODS ----------- //

            webCommand.Add(openMyWebsite); // 0
            webCommand.Add(openGoogle); // 1
            webCommand.Add(openYoutube); // 2
            webCommand.Add(openAmazon); // 3
            webCommand.Add(openGoogleSearch); // 4
            webCommand.Add(openMyWebsiteFiles); // 5
            webCommand.Add(openMyGmx); // 6
            webCommand.Add(WebToolsLogin); //7

            // ------------------------------- //

            // --------- CALL SORTING --------- // 
            int i = 0;
            i = sortingAlgorithm(command);
            webCommand[i]();
            // -------------------------------- //
        }


        // --------- My own Commandlist ----------- //
        public static void openMyWebsite()
        {
            createWebsiteHandler("https://www.luca-dev.com");  
            Console.WriteLine("- starting myWeb");
        }

        public static void openGoogle()
        {
            createWebsiteHandler("https://www.google.de");
        }

        public static void openYoutube()
        {
            createWebsiteHandler("https://www.youtube.com/?gl=DE.de");
        }

        public static void openAmazon()
        {
            websiteSearchHandler("https://www.amazon.de/s?k=");
            Console.WriteLine("- AmazonSearch");

        }

        public static void openGoogleSearch()
        {
            websiteSearchHandler("https://www.google.de/search?q=");
            Console.WriteLine("- Google Search");
        }
        
        public static void openMyWebsiteFiles()
        {
            createWebsiteHandler("https://nl-files.hostinger.com");
        }
        
        public static void openMyGmx()
        {
            createWebsiteHandler("https://www.gmx.net");
        }

        public static void WebToolsLogin()
        {
            runScript("WebToolLogin.py");
        }



        // ----------------------------------------- //



        //Definition
        public static void createWebsiteHandler(string website)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("start {0}", website);
            process.StandardInput.Close(); // CLOSES CONSOLE
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.Clear();
        }

        public static void websiteSearchHandler(string website)
        {
            string search = Console.ReadLine();
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("start {0}{1}", website, search);
            process.StandardInput.Close(); // CLOSES CONSOLE
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.Clear();
        }

        public static void runScript(string Name)
        {
            string scriptPath = "E:\\OneDrive\\Programmierung Privat\\03_CSharp\\fastTrack\\scripts\\";
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("cd E:");
            process.StandardInput.WriteLine("cd " + scriptPath);
            process.StandardInput.WriteLine("python " + Name);
            process.StandardInput.Close(); // CLOSES CONSOLE
            Console.Clear();
        }



        // SORTING ALG
        public static int sortingAlgorithm(string command)
        {
            string[] commandInput = { "myWeb", "google", "yt", "amazon", "googleS", "myWebF", 
            "myGmx", "py"};

            int i = 0;
            for (; commandInput[i] != command; i++)
            {

            }
            return i;
        }
    }
}
