using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	internal class Database
	{
		private static string connectionString = "Server=DESKTOP-AJHCE58\\SQLEXPRESS01;DataBase=SchoolManagement;Trusted_Connection=True;";
		public static SqlConnection connection = new SqlConnection(connectionString);
		public static void OpenConnection()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
			}
		}

		public static void CloseConnection()
		{
			connection.Close();
		}
		public static void SetConnectionString(string connString)
		{
			connectionString = connString;
		}
	}
}
