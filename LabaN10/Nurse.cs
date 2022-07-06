using System;

namespace LabaN10
{
    public class Nurse : HospitalEmployee
    {
        public int Age { get; set; }

        public Nurse(string name,int age, string post) : base (name, post)
        {

            Age = age;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, должность: {this.GetType()}, возраст: {Age}.");
        }

        //public new void PrintInfo()
        //{
        //    Console.WriteLine($"Имя: {Name}, должность: {this.GetType()}, возраст: {Age}.");
        //}

        //public override void PrintInfo()
        //{
        //    base.PrintInfo();
        //    Console.SetCursorPosition(35, 1);
        //    Console.WriteLine($"возраст {Age}");
        //}
    }
}
