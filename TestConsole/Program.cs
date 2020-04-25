using System;
using Model.DAO;

namespace TestConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ChuDeDAO chuDeDao = new ChuDeDAO();
            var a = chuDeDao.List().Count;
            Console.WriteLine(a);
        }
    }
}