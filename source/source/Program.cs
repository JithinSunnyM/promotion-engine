using System;
using System.Collections.Generic;

namespace source
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        // To get total order value
        private static int GetTotalOrderValue(List<UnitPrice> unitItems)
        {
            int checkoutsA = 0;
            int unitPriceA = 50;

            int checkoutsB = 0;
            int unitPriceB = 30;

            int checkoutsC = 0;
            int unitPriceC = 20;

            int checkoutsD = 0;
            int unitPriceD = 15;


            return 0;
        }

        // Unit price for SKU IDs 
        public class UnitPrice
        {
            public string skuId { get; set; }
            public decimal price { get; set; }

            public UnitPrice(string id)
            {
                this.skuId = id;
                switch (id)
                {
                    case "A": 
                        this.price = 50;
                        break;
                    case "B":
                        this.price = 30;
                        break;
                    case "C":
                        this.price = 20;
                        break;
                    case "D":
                        this.price = 15;
                        break;
                }
            }
        }

    }
}
