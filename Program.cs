using System;

namespace StudentApp
{
    public class Program
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("Student Application Management System");
            Student s1 = new Student();
            s1.rollno = Student.incrementId();
            s1.sname = "Ajay";
            s1.gender = 'M';
            //Console.WriteLine("roll no " + s1.rollno);
            //Console.WriteLine("name " + s1.sname);
            //Console.WriteLine("Gender " + s1.genders
            //s1.displayDetails(rollno: rollno, sname: sname,gender:gender);
            Student s2 = new Student();
            s2.rollno = Student.incrementId();
            s2.sname = "prachi";
            //s2.gender = 'F';
            //Console.WriteLine("roll no " + s2.rollno);
            //Console.WriteLine("name " + s2.sname);
            //Console.WriteLine("Gender " + s2.gender);
            Console.ReadKey();
        }
    }
}