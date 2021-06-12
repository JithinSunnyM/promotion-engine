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

            foreach (UnitPrice unitPrice in unitItems)
            {
                if (unitPrice.skuId == "A" || unitPrice.skuId == "a")
                {
                    checkoutsA = checkoutsA + 1;
                }
                if (unitPrice.skuId == "B" || unitPrice.skuId == "b")
                {
                    checkoutsB = checkoutsB + 1;
                }
                if (unitPrice.skuId == "C" || unitPrice.skuId == "c")
                {
                    checkoutsC = checkoutsC + 1;
                }
                if (unitPrice.skuId == "D" || unitPrice.skuId == "d")
                {
                    checkoutsD = checkoutsD + 1;
                }
            }

            // Applying the 2 active promotions
            int totalUnitPriceA = (checkoutsA / 3) * 130 + (checkoutsA % 3 * unitPriceA);
            int totalUnitPriceB = (checkoutsB / 2) * 45 + (checkoutsB % 2 * unitPriceB);

            int totalUnitPriceC = (checkoutsC * unitPriceC);
            int totalUnitPriceD = (checkoutsD * unitPriceD);

            // Total
            return totalUnitPriceA + totalUnitPriceB + totalUnitPriceC + totalUnitPriceD;
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
