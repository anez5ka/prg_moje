using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Student
    {
        public string Name;
        public int Year;
        public int Id;
        public Dictionary<string, List<double>> Subjects;

        public Student(string name, int year)
        {
            Name = name;
            Year = year;
            Random rnd = new Random();
            Id = rnd.Next(1000,10000);
            Dictionary<string, List<double>> Subjects = new Dictionary<string, List<double>>();
        }
        public void AddSubject (string subject)
        {
            Subjects[subject] = new List<double>();
        }
        public void AddGrade (string subject, double grade)
        {
            Subjects[subject].Add(grade);
        }

    }
}
