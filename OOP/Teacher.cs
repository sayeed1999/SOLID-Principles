using System;

namespace OOP
{
    public class Teacher : Person, ITeacher
    {
        public readonly string ID;
        public TeacherDesignationEnum Designation { get; private set; }
        public DepartmentEnum Department { get; private set; }

        public void lala()
        {
            // ID = "asd"; // cannot be assigned. it is read-only
        }
        public Teacher()
        {
        }

        public override void ComeToSchool()
        {
            Console.WriteLine("Teacher comes to school");
        }

        public override string ToString()
        {
            // return base.ToString();
            return $"Teacher {Name} is a {Designation} in {Department}.";
        }

        public void TakeClass()
        {
            // own implementation..
        }

        public void ExamPaperAccess()
        {
            // own implementation..
        }
    }
}