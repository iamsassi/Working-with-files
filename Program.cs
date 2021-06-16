using System;

namespace Working_with_files
{
    class Program
    {
        static void Main(string[] args)
        {
            // In this program the user gets to work with folders and files

            Console.WriteLine("In this program you get to work with folders and files");
            Console.WriteLine("");
            Console.WriteLine("Do you want to proceed? ");
            var answer = Console.ReadLine();

            switch(answer.ToLower())
            {
                case "yes":
                case "y":
                    Console.Clear();
                    Console.Write("What is the name of the folder you want to create? ");
                    var dirName = Console.ReadLine();
                    createFolder newFolder = new createFolder(dirName);
                    break;

                case "no":
                case "n":
                    Environment.Exit(0);
                    break;

            }

        }
    }
}
