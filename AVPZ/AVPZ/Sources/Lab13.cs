using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AVPZ.Sources
{
    [Serializable]
    class Lab13
    {
        public Lab13()
        {

        }

        public Lab13(string name, string country, float shipments, float price)
        {
            this.name = name;
            this.country = country;
            this.shipments = shipments;
            this.price = price;
        }

        public string name { get; set; }
        public string country{ get; set; }
        public float shipments { get; set; }
        public float price { get; set; }

        public string toString()
        {
            return
                "EX: "+
                "\nname=" + name +
                "\ncountry=" + country +
                "\nshipments=" + shipments +
                "\nprice=" + price;
        }
    }
}
