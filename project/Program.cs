
using System;
using System.Xml.Linq;


namespace Cproject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();
            List<double> Degrees = new List<double>();

            while (true)
            {

                Console.WriteLine("Enter the student's name (or type '#' to finish):");
                string StuName = Console.ReadLine();
                if (StuName=="#")
                {
                    break;
                }
                Console.WriteLine($"Enter the grade for {StuName}: ");
                double StuDeg = double.Parse(Console.ReadLine());


                Names.Add(StuName);
                Degrees.Add(StuDeg);

            }
            Console.WriteLine("{0,-20} {1,8} {2,10}","Student Name","Mark", "Status");
            Console.WriteLine("----------------------------------------------");
            for (int i=0; i<Names.Count; i++)
            {
                string Status = Degrees[i]>=60 ? "Passed" : "Failed";
                Console.WriteLine("{0,-20}{1,8}{2,12}", Names[i], Degrees[i],Status);
               
                }
            }
        }
    }
