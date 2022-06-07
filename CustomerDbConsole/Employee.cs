using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDbConsole
{
    public  class Employee
    {
        public static string sqlConnectionStr = @"Data Source=DESKTOP-2PKBUH0\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True";
        public string InsertEmployee()
        {
            Console.Write("Enter Employee Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Employee Mobile: ");
            Double mobile = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Employee address : ");
            string address = Console.ReadLine();

            //insert Employee data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Employee values(" + id + ",'" + name + "','" + email + "'," + mobile + ",'" + address + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close
            return "Inserted";
        }

        public string UpdateEmployee()
        {
            return "";
        }

        public string DeleteEmployee()
        {
            return "";
        }

        public string SelectEmployee()
        {
            return "";
        }

        public string SelectEmployeeById()
        {
            return "";
        }
    }


}

   
