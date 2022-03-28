using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Lesson_6
{
    internal class Task_Collections
    {
        Dictionary<int, string> IDName = new Dictionary<int, string>()
        {
            {1, "Arthur" },
            {2, "Armen" },
            {3, "Karen" },
            {4, "Artak" },
            {5, "Artyom" }
        };        

        Dictionary<int, int> IDAge = new Dictionary<int, int>()
        {
            {1, 24 },
            {2, 24 },
            {3, 22 },
            {4, 23 },
            {5, 24 },
        };

        Dictionary<int, int> IDSalary = new Dictionary<int, int>()
        {
            {1, 1000000 },
            {2, 1500000 },
            {3, 1200000 },
            {4, 1000000 },
            {5, 1100000 },
        };

        Dictionary<int, bool> IDisMaried = new Dictionary<int, bool>()
        {
            {1, false },
            {2, true },
            {3, true },
            {4, false },
            {5, false }
        };
    }
}
