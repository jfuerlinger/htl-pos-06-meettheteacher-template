using MeetTheTeacher.Logic;
using System;
using System.IO;
using System.Text;

namespace MeetTheTeacher.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string pathToInputFiles = @".\Input";
            const string pathToOutputFiles = @"c:\temp";

            const string teachersFileName = "Teachers.csv";
            const string detailsFileName = "Details.csv";
            const string ignoredTeachersFileName = "IgnoredTeachers.csv";

            const string resultFileName = "Sprechstunden.html";

            Console.WriteLine("Meet the teacher");
            Console.WriteLine("================");

            string[] teacherLines = File.ReadAllLines(Path.Combine(pathToInputFiles, teachersFileName), Encoding.UTF8);
            string[] detailLines = File.ReadAllLines(Path.Combine(pathToInputFiles, detailsFileName), Encoding.UTF8);
            string[] ignoredNames = File.ReadAllLines(Path.Combine(pathToInputFiles, ignoredTeachersFileName), Encoding.UTF8);
            
        }
    }
}
