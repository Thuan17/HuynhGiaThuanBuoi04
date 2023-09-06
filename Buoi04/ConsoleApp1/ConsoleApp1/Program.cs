using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ToaDo bai7 = new ToaDo( 5, 6);


            HinhTron hinhTron = new HinhTron();
            hinhTron.ToString();
            Console.ReadKey();
        }
    }
}
