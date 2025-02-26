using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student
    {

        public int rollno { get; set; }
        public string sname { get; set; }

        public char gender { get; set; }

        public static int id = 0;

        public static int incrementId()
        {
            return ++id;
        }

        public void displayDetails(int rollno=0, string sname="",char gender=' ')
        {
            if(rollno > 0)
            {

                Console.WriteLine("Roll no: " + rollno);
            }
            if (sname!= "")
            {

                Console.WriteLine("Roll no: " + rollno);
            }
            if (rollno > 0)
            {

                Console.WriteLine("name of the student : " + sname);
            }

            if(gender != ' ')
            {
                Console.WriteLine("gender : " + gender);
            }

        }
    }
}
