using System;
using System.Collections.Generic;
using System.Text;

namespace Working_with_files
{
    public class mainMenu
    {
        public string dirName;
        public mainMenu(string dirName)
        {
            var menu = new string[] { "1. Create folder", "2. Create a file", "3. Delete folder", "4. Exit program" };

            for (var i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
            Console.WriteLine("");
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Console.Write("What is the name of the folder you want to create? ");
                    dirName = Console.ReadLine();
                    _ = new createFolder(dirName);
                    break;

                case "2":
                    _ = new createFile(dirName);
                    break;

                case "3":
                    Console.Clear();
                    Console.Write("What is the name of the folder you want to delete? ");
                    var fileName = Console.ReadLine();
                    _ = new deleteFolder(fileName);
                    break;

                case "4":
                    Console.WriteLine("The program will now exit");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please select between 1-4");
                    break;
            }
        }

    }
}
