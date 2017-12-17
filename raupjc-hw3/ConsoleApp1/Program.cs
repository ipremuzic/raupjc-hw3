using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid inicijalniId= new Guid();
            Guid probniId = new Guid(inicijalniId.ToString());
            if (probniId.Equals(inicijalniId))
            {
                Console.WriteLine("TRUE!!");
            }
        }
    }
}
