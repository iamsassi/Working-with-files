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
            Console.WriteLine("Do you want to create a file? ");
            var answer = Console.ReadLine();

            switch(answer.ToLower())
            {
                case "y":
                case "yes":
                    Console.WriteLine("What is the of the file you want to create, please include the extension of the file ");
                    var fileName = Console.ReadLine();
                    if (File.Exists(fileName))
                    {
                        Console.WriteLine($"The file name '{fileName}' exists already");
                    }
                    else
                    {
                        var path = dirName + "\\" + fileName;
                        File.WriteAllText(path, "");
                        var fileInformation = new FileInfo(path);
                        var fName = Path.GetFileNameWithoutExtension(fileInformation.FullName);
                        var fExtension = fileInformation.Extension;
                        var fSize = fileInformation.Length;

                        Console.WriteLine($"The file '{fName}' has been created and the size is {fSize} bytes");
                    }
                    break;

                case "n":
                case "no":
                    Environment.Exit(0);
                    break;
            }
        }

    }
}
