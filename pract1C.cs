/*Create an application that receives the (Student Id, Student
Name, Course Name, Date of Birth) information from a set of
students. The application should also display the information
of all the students once the data entered.*/



using System;
namespace ArrayOfStructs
{
    class Program
    {
        struct Student
        {
            public string studid, name, cname;
            public int day, month, year;
        }
        static void Main(string[] args)
        {
            Student[] s = new Student[5];
            int i;
            for (i = 0; i < 2; i++)
            {
                Console.Write("Enter Student Id:");
                s[i].studid = Console.ReadLine();
                Console.Write("Enter Student name : ");
                s[i].name = Console.ReadLine();
                Console.Write("Enter Course name : ");
                s[i].cname = Console.ReadLine();
                Console.Write("Enter date of birth\n Enter day(1-31):");
                s[i].day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter month(1-12):");
                s[i].month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter year:");
                s[i].year = Convert.ToInt32(Console.ReadLine());
            }

   
            Console.WriteLine("\n\nStudent's List\n");
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("\nStudent ID : " + s[i].studid);
                Console.WriteLine("\nStudent name : " + s[i].name);
                Console.WriteLine("\nCourse name : " + s[i].cname);
                Console.WriteLine("\nDate of birth(dd-mm-yy) : " + s[i].day + "-" +
                s[i].month +
                "-" + s[i].year);
            }

            s[i].studid = Console.ReadLine();

        }
    }
}
