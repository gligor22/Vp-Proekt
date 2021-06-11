using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{

    public class MasaKlasa
    {
        public List<Reservation> r { get; set; }
        public List<Drinks> d { get; set; }
        public String tableNum { get; set; }

        public int Zafatena { get; set; }

        public double smetka()
        {
            double cena = 0.0;
            foreach(Drinks drink in d)
            {
                cena += drink.price;
            }
            return cena;
        }

        public MasaKlasa(String tableNum, List<Reservation> r ,List<Drinks> d,int z)
        {
            this.tableNum = tableNum;
            this.d = d;
            this.r = r;
            this.Zafatena = z;
        }

        public override string ToString()
        {
            String k = tableNum + "\n";
             foreach(Drinks drink in d)
            {
                k = k + "\t" + drink + "\n";
            }
            k += smetka();
            return k;
        }
    }
}
