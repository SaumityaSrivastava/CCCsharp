using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionEx1
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Company Name");
            string cname = Console.ReadLine();
            Console.WriteLine("Enter the Employee Name");
            string ename = Console.ReadLine();
            Console.WriteLine("Enter the Project Name");
            string pname = Console.ReadLine();
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            entireMessage(cname, ename, pname, year);

        }
        public static void headerMeaasge(string companyname)
        {
            Console.WriteLine(companyname + " Employee Information");
        }
        public static void footerMessage(int year)
        {
            Console.WriteLine("Copyright " + year);
            Console.WriteLine("All Rights Reserved.");
        }
        public static void entireMessage(string cname, string ename, string pname, int year)
        {
            headerMeaasge(cname);
            Console.WriteLine(ename);
            Console.WriteLine(pname);
            footerMessage(year);

        }

    }

}