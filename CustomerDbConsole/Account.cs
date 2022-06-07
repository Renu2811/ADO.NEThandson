using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDbConsole
{
    public class Account
    {
        public static string sqlConnectionStr = @"Data Source=DESKTOP-2PKBUH0\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True";
        public string InsertAccount()
        {
            Console.Write("Enter Account Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Number: ");
            Double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Account Balance: ");
            Double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Account Branch : ");
            string branch = Console.ReadLine();

            //insert Account data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Account values(" + id + "," + num + " ," + balance + ",'" + branch + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close
            return "Inserted";
        }

        public string UpdateAccount()
        {
            return "";
        }

        public string DeleteAccount()
        {
            return "";
        }

        public string SelectAccount()
        {
            return "";
        }

        public string SelectAccountById()
        {
            return "";
        }
    }


}
