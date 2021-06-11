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
    public partial class Masa : Form
    {
        public MasaKlasa ms;
        private int zafatena = 0;
        private List<Reservation> lokRez;
        private List<Drinks> lokDrinks;

    public Masa()
        { 
            InitializeComponent();
        }

        public Masa(MasaKlasa masaKlasa)
        { 
            this.ms = masaKlasa;
            InitializeComponent();
            if(ms.Zafatena==0)
            {
                gbDrinks.Enabled = false;
            }
            labelName.Text = ms.tableNum;
            FillLists();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            String s = dateTimePicker1.Value.ToString().Split(':')[0];
            int cas2 = Int32.Parse(s.Split(' ')[1]);
            String cas22 = s.Split(' ')[0];
            String g = dateTimePicker1.Value.ToString().Split(' ')[2];
            
            foreach (Reservation rez in ms.r)
            {
                String k = rez.time.ToString().Split(':')[0];
                int cas = Int32.Parse(k.Split(' ')[1]);
                String cass = k.Split(' ')[0];
                String kk = rez.time.ToString().Split(' ')[2];
                if (k==s || (cas22==cass && Math.Abs(cas-cas2)<3) && g == kk)
                {
                    MessageBox.Show("This table is already booked.\nPlease try other table.");
                    return;
                }
                
            }

            if(tbRezName.Text=="")
            {
                MessageBox.Show("Please enter Reservation Name");
                return;
            }
            String tableNum = ms.tableNum.Split(' ')[1];
            Reservation rr = new Reservation(tableNum,tbRezName.Text, dateTimePicker1.Value, 4);
            ms.r.Add(rr);
            String p = rr.time.ToString().Split(':')[0] + ":" + rr.ToString().Split(':')[1];
            tbRezName.Text = "";
            MessageBox.Show("Reserved at " + p + " Name: " + rr.Name);
          
        }

        private void Masa_Load(object sender, EventArgs e)
        { 
            tbMoney.Text = ms.smetka().ToString();
        }
        public void FillLists()
        {
            Drinks[] drinks = new Drinks[15];
            drinks[0] = new Drinks("Coca-Cola", "330ml", 1.40);
            drinks[1] = new Drinks("Fanta", "330ml", 1.40);
            drinks[2] = new Drinks("Sprite", "330ml", 1.40);
            drinks[3] = new Drinks("Schweppes", "330ml", 1.40);
            drinks[4] = new Drinks("Tonic", "330ml", 1.40);
            drinks[5] = new Drinks("Espresso", "9g", 1.20);
            drinks[6] = new Drinks("Machiatto", "9g", 1.40);
            drinks[7] = new Drinks("Late", "9g", 1.30);
            drinks[8] = new Drinks("Fredo", "9g", 1.60);
            drinks[9] = new Drinks("Nescafe", "12g", 1.60);
            drinks[10] = new Drinks("Mojito", "300ml", 2.50);
            drinks[11] = new Drinks("Mai Tai", "300ml", 3.00);
            drinks[12] = new Drinks("Godfather saur", "250ml", 2.80);
            drinks[13] = new Drinks("Zulu", "300ml", 2.50);
            drinks[14] = new Drinks("Cosmopolitan", "250ml", 3.00);
            for(int i=0;i<5;i++)
            {
                lbCaffee.Items.Add(drinks[i + 5]);
                lbCoctails.Items.Add(drinks[i + 10]);
                lbSaur.Items.Add(drinks[i]);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gbDrinks.Enabled = true;
            if (ms.Zafatena == 1)
                MessageBox.Show("Can`t complite this action");
            ms.Zafatena = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                lbCoctails.Enabled = true;
                lbCaffee.Enabled = false;
                lbSaur.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                lbCoctails.Enabled = false;
                lbCaffee.Enabled = false;
                lbSaur.Enabled = true;
            }
            else
            {
                lbCoctails.Enabled = false;
                lbCaffee.Enabled = true;
                lbSaur.Enabled = false;
            }
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)  
            {  
                if(lbCoctails.SelectedItems.Count > 0)
                {
                    ms.d.Add((Drinks)lbCoctails.SelectedItem);
                }
                else
                    MessageBox.Show("Please select your Coctail from the list");
            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (lbSaur.SelectedItems.Count > 0)
                {
                    ms.d.Add((Drinks)lbSaur.SelectedItem);
                }
                else
                    MessageBox.Show("Please select your Saur from the list");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                if(lbCaffee.SelectedItems.Count > 0)
                {
                    ms.d.Add((Drinks)lbCaffee.SelectedItem);
                }
                 else
                    MessageBox.Show("Please select your Caffee from the list");
            }
            tbMoney.Text = ms.smetka().ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Smetka s = new Smetka(ms.d);
            DialogResult d = s.ShowDialog();
            if(d==DialogResult.OK)
            {
                ms.Zafatena = 0;
                ms.d.Clear();
                tbMoney.Text = "";
                gbDrinks.Enabled = false;
                comboBox1.SelectedIndex = -1;
                lbSaur.ClearSelected();
                lbCoctails.ClearSelected();
                lbCaffee.ClearSelected();
            }
        }

        private void Masa_FormClosing(object sender, FormClosingEventArgs e)
        {    
                DialogResult = DialogResult.OK;
        }

        private void Masa_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
