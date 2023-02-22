using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeIgora
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=igora;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                //await connection.OpenAsync();   // открываем подключение

                SqlCommand command = new SqlCommand();
                // определяем выполняемую команду
                command.CommandText = "CREATE DATABASE adonetdb";
                // определяем используемое подключение
                command.Connection = connection;
                // выполняем команду
                
                Console.WriteLine("База данных создана");
            }
            Console.Read(); ;
   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }
    }
}
