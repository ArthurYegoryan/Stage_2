using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stage_2.Lesson_8
{
    internal class FileStreamClass
    {
        static void Main()
        {
            string path = @"C:\Users\arthu\OneDrive\Desktop\Arthur\C#\Lessons\Stage_2\Stage_2\Stage_2\Lesson_8\Files\file5.txt";

            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);   // Creates a new file on that path

            StreamWriter streamWriter = new StreamWriter(fileStream);     // Creates StreamWriter using fileStream

            string text = "Hello World!";

            streamWriter.Write(text);          // Writes text

            streamWriter.Close();              // Closes streamWriter
            fileStream.Close();                // Closes fileStream
        }
    }
}
