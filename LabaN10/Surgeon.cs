using System;

namespace LabaN10
{
    public class Surgeon : HospitalEmployee
    {
        public int Age { get; set; }

        public DateOnly DateOfAdmission { get; set; } // Дата приема на работу

        public Surgeon(string name, int age, string post, DateOnly date) : base(name, post)
        {
            Age = age;
            DateOfAdmission = date;

        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, должность: {this.GetType()}, возраст: {Age}, " +
                              $"стаж: {DateTime.Now.Year - DateOfAdmission.Year} лет.");
        }
        //public new void PrintInfo()
        //{
        //    Console.WriteLine($"Имя: {Name}, должность: {this.GetType()}, возраст: {Age}, " +
        //                      $"стаж: {DateTime.Now.Year - DateOfAdmission.Year} лет.");
        //}

        //public override void PrintInfo()
        //{
        //    base.PrintInfo();
        //    Console.SetCursorPosition(35, 1);
        //    Console.WriteLine($"возраст {Age}, стаж: {DateTime.Now.Year - DateOfAdmission.Year} лет.");
        //}
    }
}
