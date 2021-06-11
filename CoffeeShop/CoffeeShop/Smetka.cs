using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Smetka : Form
    {
        public List<Drinks> d = new List<Drinks>();
        public Smetka(List<Drinks> drinks)
        {
            this.d = drinks;
            InitializeComponent();

            Fill();
        }

        public void Fill()
        {
            foreach(Drinks drink in d)
            {
                listBox1.Items.Add(drink);
            }
            tbMoney.Text = smetka().ToString();
        }

      
        public double smetka()
        {
            double cena = 0.0;
            foreach (Drinks drink in d)
            {
                cena += drink.price;
            }
            return cena;
        }
        private void Smetka_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
