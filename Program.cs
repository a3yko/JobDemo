using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace JobDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Job[] jobs = new Job[3]; //Create an array of three Jobs. Don’t change this statement. 

            for (int i = 0; i < jobs.Count(); i++)
            {
                bool nt = false;
                int num = 0;
                while (!nt)
                {
                    Console.WriteLine("Please enter a Job Number: ");
                    num = int.Parse(Console.ReadLine());

                    if(i > 0) {
                        if (jobs[i - 1].JobNumber == num)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a Job Number: ");
                            num = int.Parse(Console.ReadLine());
                        }
                    }
                    if (i > 1)
                    {
                        if (jobs[i - 1].JobNumber == num || jobs[i - 2].JobNumber == num)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a Job Number: ");
                            num = int.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        nt = true;
                    }
                }
                Console.WriteLine("Please enter a customer Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter a description: ");
                string des = Console.ReadLine();
                Console.WriteLine("Please enter the est time: ");
                double time = Double.Parse(Console.ReadLine());
                Console.WriteLine("Is this a rush job y/n ?");

                if (Console.ReadLine() == "y")
                    jobs[i] = new RushJob(num, name, des, time);
                else
                    jobs[i] = new Job(num, name, des, time);
                Console.Clear();
            }

            for (int i = 0; i < jobs.Count(); i++)
            {
                Console.WriteLine(jobs[i].ToString());

            }

            Console.WriteLine("Total Cost is: " + (jobs[0].Price + jobs[1].Price + jobs[2].Price));
        }
    }
}