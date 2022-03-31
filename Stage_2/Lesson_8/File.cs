using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stage_2.Lesson_8
{
    internal class File
    {
        static void Main()
        {
            string path = @"C:\\Users\arthu\\OneDrive\\Desktop\\Arthur\\C#\\Lessons\\Stage_2\\Stage_2\\Stage_2\\Lesson_8\\Files\\file1.txt";

            FileInfo file = new FileInfo(path);

            file.Create();
                        
        }

        public static void FileMethod()
        {
            string text = "Barlus Hayer!";

            string path = @"C:\\Users\arthu\\OneDrive\\Desktop\\Arthur\\C#\\Lessons\\Stage_2\\Stage_2\\Stage_2\\Lesson_8\\Files\\file1.txt";

            
        }
    }
}
