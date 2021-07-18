using System;

namespace OOP
{
    public abstract class Person : IPerson
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Contact { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public GenderEnum Gender { get; private set; }

        public virtual void ComeToSchool()
        {
            Console.WriteLine("Person comes to school");
        }

        public void LeaveFromSchool()
        {
            // own implementation..
        }

        public override string ToString()
        {
            // return base.ToString();
            return $"Person {Name} lives in {Address}. His contact no. is {Contact}. His age is {DateTime.Now.Year - DateOfBirth.Year}";
        }
    }
}
