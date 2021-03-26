using System;
using System.IO;
using Figgle;

namespace FileManager
{
    class Class1
    {
        

        public static void Startup()
        {
            Console.WriteLine(FiggleFonts.Standard.Render("File Viewer"));
            Console.WriteLine("C# File Manager Version 0.0.1 " + "by github.com/jeb495");
            Console.WriteLine("Enter the command LIST to see a list of commands, all commands are all uppercase");

            string input = Console.ReadLine();

            if (input == "LIST")
            {
                ListCommands();
            }
            else if (input == "URI")
            {
                URI();
            }
        }

        #region LIST COMMAND
        public static void ListCommands()
        {
            Console.WriteLine("");
            Console.WriteLine("LIST --> List all current available commands");
            Console.WriteLine("URI --> Manually input the path to a desired directory");
            Console.WriteLine("RETURN --> Return to the beginning of the program");

            string listInput = Console.ReadLine();
            if (listInput == "RETURN")
            {
                Console.Clear();
                Startup();
            }
            else if (listInput == "URI")
            {
                URI();
            }
            else if (listInput == "LIST")
            {
                Console.Clear();
                ListCommands();
            }
            else if (listInput == "test")
            {
                Console.WriteLine("test success");
            }
            else
            {
                Console.WriteLine("Invalid Command");
            }

        }
        #endregion

        #region URI COMMAND
        public static void URI()
        {
            Console.WriteLine("Enter the path to the desired directory");
            DirectoryInfo URIPath = new DirectoryInfo(Console.ReadLine());
            Console.WriteLine("Valid Commands: INFO");


            string uricommand = Console.ReadLine();

            if (uricommand == "INFO")
            {
                Console.WriteLine("Directory Name: " + URIPath.FullName);
                Console.WriteLine(Convert.ToString("Creation Time: " + URIPath.CreationTime));
                Console.WriteLine("Parent Directory: " + URIPath.Parent);
                Console.WriteLine(Convert.ToString(Convert.ToString("Last Access Time: " + URIPath.LastAccessTime)));
                Console.WriteLine(Convert.ToString("Last Write Time:" + URIPath.LastWriteTime));

                string listinput = Console.ReadLine();
                if (listinput == "RETURN")
                {
                    Console.Clear();
                    Startup();
                }
                else if (listinput == "URI")
                {
                    URI();
                }
                else if (listinput == "LIST")
                {
                    Console.Clear();
                    ListCommands();
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                    Console.ReadKey();
                }

            }
            
            
            
        }
        #endregion

    }
}