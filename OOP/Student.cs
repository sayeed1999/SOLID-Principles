using System;

namespace OOP
{
    public class Student : Person, IStudent, IPerson
    {
        public int Roll { get; private set; }
        public ClassEnum Class { get; private set; }

        public void AttendClass()
        {
            // own implementation..
        }
        public override void ComeToSchool()
        {
            Console.WriteLine("Student comes to school");
        }

        public override string ToString()
        {
            // return base.ToString();
            return $"Student {Name} is in class {Class}. His/her roll is {Roll}";
        }
    }
}