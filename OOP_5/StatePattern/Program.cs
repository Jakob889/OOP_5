using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFile = new File("myFile.txt");
            var Finanzen = new File("Fianzen.xls");

            myFile.getState();
            Finanzen.getState();

            Console.WriteLine();
            myFile.close();
            myFile.delete();
            myFile.open();
            myFile.getState();

            Console.WriteLine();
            Finanzen.open();
            Finanzen.open();
            Finanzen.close();
            Finanzen.open();
            Finanzen.delete();
            Finanzen.getState();

            Console.Read();
        }
    }
}
