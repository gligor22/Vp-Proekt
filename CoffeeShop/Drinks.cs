using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Drinks
    {
        public String Name { get; set; }

        public double price { get; set; }

        public String ML { get; set; }
        public int Kolicina { get; set; }

        public Drinks() { }
        public Drinks(String Name, String ML, double price)
        {
            this.Name = Name;
            this.ML = ML;
            this.price = price;
            Kolicina = 0;
        }

        public void zgolemi()
        {
            Kolicina++;
        }
        public override string ToString()
        {
            if(Kolicina==0)
                return Name + " " + ML + " " + price;
            else
                return Kolicina+"x"+ Name + " " + ML + " " + price;
        }
    }
}
