using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stage_2.Lesson_8
{
    internal class Files
    {
        static void Main()
        {
            FileCreate();
        }

        public static void FileCreate()
        {
            string path = @"C:\Users\arthu\OneDrive\Desktop\Arthur\C#\Lessons\Stage_2\Stage_2\Stage_2\Lesson_8\Files\file1.txt";
            string text = "Barlus Hayer!";

            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                Console.WriteLine($"File name: {fileInfo.Name}");
                Console.WriteLine($"File creation time: {fileInfo.CreationTime}");
                Console.WriteLine($"File length: {fileInfo.Length}");
            }

            string path1 = @"C:\Users\arthu\OneDrive\Desktop\Arthur\C#\Lessons\Stage_2\Stage_2\Stage_2\Lesson_8\Files\file2.txt";

            //File.Create(path1);        // Creates a new file with path1 direction

            if (File.Exists(path1))
            {
                File.WriteAllText(path1, text);      // Creates a new file and writes text in it
            }

            File.Encrypt(path1);         // Encrypts the file, is reachable only on windows
            File.Decrypt(path1);         // Decrypts the file, is reachable only on windows

            string path2 = @"C:\Users\arthu\OneDrive\Desktop\Arthur\C#\Lessons\Stage_2\Stage_2\Stage_2\Lesson_8\Files\file3.txt";
            File.CreateText(path2).Close();       // Creates a new file with path2 dictionary, then closes it            
            File.Delete(path2);                   // Deletes file with path2 dictionary

            string pathCopy = @"C:\Users\arthu\OneDrive\Desktop\Arthur\C#\Lessons\Stage_2\Stage_2\Stage_2\Lesson_8\Files\file1Copy.txt";
            //File.Copy(path, pathCopy);            // Creates file1 copy on pathCopy destination

            string path3 = @"C:\Users\arthu\OneDrive\Desktop\Arthur\C#\Lessons\Stage_2\Stage_2\Stage_2\Lesson_8\Files\file3.txt";
            string text1 = "Barlus Hayer!\nHello world";
            File.WriteAllText(path3, text1);

            bool isEqual = File.Equals(path1, path2);      // Returns yes if path1 is equal to path2, otherwise false
            Console.WriteLine(isEqual);

            bool isExist = File.Exists(path);           // Returns yes if on that path exists file, otherwise false
            Console.WriteLine(isExist);

            Console.WriteLine(File.GetAttributes(path));      // Returns file attributes that is on that path

            Console.WriteLine(File.GetCreationTime(path3));   // Returns file creation time  UTC+4

            Console.WriteLine(File.GetCreationTimeUtc(path3));  // Returns file creation time with coordinated universal time 

            Console.WriteLine(File.GetLastAccessTime(path));

            Console.WriteLine(File.GetLastAccessTimeUtc(path));

            Console.WriteLine(File.GetLastWriteTime(path3));     // Returns the last time, that is written on that path file

            Console.WriteLine(File.GetLastWriteTimeUtc(path3));  // Returns the last time, that is written on that path file in UTC

            string path4 = @"C:\Users\arthu\OneDrive\Desktop\Arthur\C#\Lessons\Stage_2\Stage_2\Stage_2\Lesson_8\Files\file4.txt";
            File.Create(path4).Close();
            string movePath = @"C:\Users\arthu\OneDrive\Desktop";
            File.Move(path4, movePath, true);                      // Error!!!

            File.ReadAllLines(path3);            // Open a file, reads all lines and then closes it

            string path5 = @"C:\Users\arthu\OneDrive\Desktop\Arthur\C#\Lessons\Stage_2\Stage_2\Stage_2\Lesson_8\Files\file10.txt";
            string? pathBackUp = @"C:\Users\arthu\OneDrive\Desktop\Arthur\C#\Lessons\Stage_2\Stage_2\Stage_2\Lesson_8\Files\file1Backup.txt";
            //File.Replace(path, path5, pathBackUp);
        }
    }
}
