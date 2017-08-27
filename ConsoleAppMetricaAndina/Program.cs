using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMetricaAndina
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyParts = new MoneyParts();
            var resultMetodo = moneyParts.build(1);
            //resultMetodo.ForEach(x => Console.WriteLine(string.Join(",", x.ToArray())));
            Console.ReadLine();
        }



       

    }
}
