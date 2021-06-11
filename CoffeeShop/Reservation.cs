using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Reservation
    {
        public String table { get; set; }
        public String Name { get; set; }

        public DateTime time { get; set; }

        public int Seats { get; set; }

        public Reservation() { }
        public Reservation (String table,String Name, DateTime time,int Seats)
        {
            this.table = table;
            this.Name = Name;
            this.time = time;
            this.Seats = Seats;
        }

        public override string ToString()
        {
            String timee = time.ToString().Split(':')[0] + ":" + time.ToString().Split(':')[1] + time.ToString().Split(' ')[2];
            return table+" - " + Name + " " + timee + " " + Seats;
        }
    }
}
