using System;
using System.Configuration;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
            ConfigurationManager.ConnectionStrings["ProjetoEstante"].
            ConnectionString;



            Console.ReadKey();
        }
    }
}
