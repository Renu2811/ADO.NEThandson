using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDbConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* CustomerData customer = new CustomerData();
             string result = customer.InsertCustomer();
             Console.WriteLine(result);
             Console.ReadLine(); */

            /* Employee emp = new Employee();
             string result1 = emp.InsertEmployee();
             Console.WriteLine(result1);
             Console.ReadLine(); */


            Account acc = new Account();
            string result2 = acc.InsertAccount();
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
