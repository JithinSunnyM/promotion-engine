using System;

namespace source
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
