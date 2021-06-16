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
            if(Directory.Exists(dirName))
                {
                Console.WriteLine($"The folder '{dirName}' exists already");
            }
            else
            {
                Directory.CreateDirectory(dirName);
                Console.WriteLine($"The folder '{dirName}' has been created");
            }
        }
    }
}
