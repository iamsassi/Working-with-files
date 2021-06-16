using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Working_with_files
{
    class createFolder
    {
        public string dirName;

        public createFolder(string dirName)
        {
            Console.Clear();
            if(Directory.Exists(dirName))
                {
                Console.WriteLine($"The folder '{dirName}' exists already");
                _ = new mainMenu(dirName);
            }
            else
            {
                dirName += "\\";
                Directory.CreateDirectory(dirName);
                Console.WriteLine($"The folder '{dirName}' has been created");
                _ = new mainMenu(dirName);
            }
        }
    }
}
