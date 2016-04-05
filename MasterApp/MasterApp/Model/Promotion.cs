using System;
using System.Collections.Generic;

namespace MasterApp
{
    public class Promotion
    {
        public int ID
        {
            get;
            set;
        }

        public string ProductName
        {
            get;
            set;
        }

        public string Image
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public string BarCode
        {
            get;
            set;
        }

        public DateTime Validity { get; set; }

        public Promotion()
        {
			
        }

        public static List<Promotion> GetPromotions()
        {
            List<Promotion> list = new List<Promotion>()
            {
                new Promotion{ ID = 1, ProductName = "Shampoo Garnier Fructis 500 ml", Image = "<preecher>", Validity = DateTime.Now },

            };
            return list;
        }

    }
}
