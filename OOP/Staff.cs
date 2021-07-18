using System;

namespace OOP
{
    public class Staff : Person, IStaff
    {
        public readonly string ID;
        public override void ComeToSchool()
        {
            Console.WriteLine("Staff comes to school");
        }

        public void DoesWork()
        {
            // own implementation ...
        }
    }
}