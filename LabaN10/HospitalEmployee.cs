using System;

namespace LabaN10
{
    public class HospitalEmployee
    {
        public string Name { get; set; }
        public string Post { get; set; } // Должность

        public HospitalEmployee(string name, string post)
        {
            Name = name;
            Post = post;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, должность: {Post}");
        }
    }
}
