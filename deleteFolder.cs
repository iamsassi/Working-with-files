using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Working_with_files
{

    
    class deleteFolder
    {
        public string dirName;


        public deleteFolder(string dirName)
        {
            Console.Clear();
            Console.WriteLine($"Do you want to the delete the folder '{dirName}'? ");
            var answer = Console.ReadLine();

            switch(answer.ToLower())
            {
                case "yes":
                case "y":
                    
                    if(Directory.Exists(dirName))
                    {
                        Directory.Delete(dirName + "\\");
                        Console.WriteLine($"The folder '{dirName}' and the files in the folder have been deleted ");
                        _ = new mainMenu(dirName);

                    }
                    else
                    {
                        Console.WriteLine($"The folder '{dirName}' does not exist");
                        _ = new mainMenu(dirName);
                    }
                    break;

                case "n":
                case "no":
                    _ = new mainMenu(dirName);
                    break;
            }
        }

    }
}
