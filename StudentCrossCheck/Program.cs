using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Console = System.Console;

namespace StudentCrossCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Student Cross Check 1.0";
            Console.WriteLine("-");
            try
            {
                StreamReader sr = new StreamReader(File.Create("students.txt"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
