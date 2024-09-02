using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Handling
{
    class File_ExistorRead
    {
        static void Main(string[] args)
        {
            string path = @"D:\New.txt";
            FileStream df = new FileStream(path,FileMode.OpenOrCreate ,FileAccess.Write);
            df.WriteByte(89);
            Console.WriteLine("Created...");
            df.Close();
            Console.ReadLine();
            //string path = @"D:\New.txt";
            //if (File.Exists(path))                      //To check file exist or not
            //{
            //    Console.WriteLine("File Exist");
            //    string read = File.ReadAllText(path);   //To Read content of a file
            //    Console.WriteLine(read);
            //    //string path2 =@"D:\Read.txt";
            //    //File.Copy(path, path2 );              //To copy path file content to path2 file.
            //    string path2 = @"D:\Folder\Read.txt";
            //    File.Copy(path, path2);                 //To copy path file content to path2 file.
            //}
            //else
            //{
            //    Console.WriteLine("No file exist.");
            //}
            //Console.ReadLine();
            //string path = @"D:\folder\Shivam";
            //string path2 =@"D:\Shivam";
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("Exist");
            //    //string file = File.ReadAllText(path);
            //    Console.WriteLine(path);
            //}
            //else
            //{
            //    Console.WriteLine("Not exist");
            //}
            //DirectoryInfo dirInfo = new DirectoryInfo(path);
            //dirInfo.CreateSubdirectory("folder1".Replace("folder1", "folder2"));
            //dirInfo.MoveTo(@"D:\folder\Folder\Folder4\New.txt");
            //if (dirInfo.Exists) 
            //{
            //    Console.WriteLine("Exist");
            //}
            //else
            //{
            //    Console.WriteLine("Created");
            //}
            //Console.ReadLine();
        }
    }
}
