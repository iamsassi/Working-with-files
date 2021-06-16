using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Working_with_files
{
    class createFile
    {
        public string dirName;
        public createFile(string dirName)
        {

            Console.Clear();

            if(dirName == "")
            {
                Console.Write("there is no folder, please create a folder first");
                Console.WriteLine("");
                _ = new mainMenu(dirName);
            }
            else
            {
                Console.Write("What is the name of the file you want to create, please add the extension as well");
                Console.WriteLine("");

                var fName = Console.ReadLine();

                var path = dirName + fName;
                File.WriteAllText(path, "");
                var fileInformation = new FileInfo(path);

                var fileName = fileInformation.Name;
                var fileExtension = fileInformation.Extension;
                var fileSize = fileInformation.Length;

                Console.WriteLine($"The file '{fileName}' has been created in the folder '{dirName}' ");
                _ = new mainMenu(dirName);
            }

        }

    }
}
