using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMetricaAndina
{
    public class MoneyParts
    {

        public List<List<Decimal>> build(Decimal monto)
        {
            var denomination = new Decimal[] { 0.05M, 0.1M, 0.2M, 0.5M, 1, 2, 5, 10, 20, 50, 100, 200 };
            var result = new List<List<Decimal>>();

            foreach (var item in denomination)
            {
                var arrayDecimal = new List<Decimal>();
                if (monto >= item)
                {
                    if (monto % item == 0) {
                        var ciclo = monto/item;
                        for (int i = 0; i < ciclo; i++)
                        {
                            arrayDecimal.Add(item);                                          
                        }
                    }
                    result.Add(arrayDecimal);
                } 



            }
            


            return result;
        }

        public static int factorial(int numero)
        {
            int fact = numero;
            int x = fact - 1;

            while (x != 1)
            {
                fact = fact * x;
                x = x - 1;
            }

            return fact;
        }


        public void GetCombinations() { 
        
        
        
        
        
        
        }



    


    }
}
