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
    public partial class CoffeShop : Form
    {
        public MasaKlasa[] masi = new MasaKlasa[13];
        
        public CoffeShop()
        {
            InitializeComponent();
            this.ActiveControl = tbUsername;
            Create();
        }
        public void fillSprat1()
        {
            btnTable1.Visible = true;
            BtnTable2.Visible = true;
            btnTable3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            btnTb8.Visible = false;
            btnTb9.Visible = false;
            btnTb10.Visible = false;
            btnTb11.Visible = false;
            btnTb12.Visible = false;
            btnTb13.Visible = false;
        }

        public void fillSprat2()
        {
            btnTable1.Visible = false;
            BtnTable2.Visible = false;
            btnTable3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            btnTb8.Visible = true;
            btnTb9.Visible = true;
            btnTb10.Visible = true;
            btnTb11.Visible = true;
            btnTb12.Visible = true;
            btnTb13.Visible = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text != "" && tbPassword.Text!= "")
            {
                if(tbUsername.Text == "Coffee123" && tbPassword.Text == "admin123")
                {
                    lbCred.Visible = false;
                    gbLogin.Visible = false;
                    fillSprat1();
                    gbInfo.Visible = true;
                    comboBox1.Visible = true;
                    comboBox1.SelectedIndex = 0;
                    
                }
                else
                {
                    lblError.Visible = true;
                    tbPassword.Text = "";
                    tbUsername.Select(0, tbUsername.Text.Length);
                }
            }
        }

        private void tbUsername_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPassword.Focus();
            }
        }
        private void CoffeShop_Load(object sender, EventArgs e)
        {
            
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin.PerformClick();
                }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                fillSprat1();
            }
            else
            {
                fillSprat2();
            }
        }

        public void activeTables()
        {
            int count = 0;
            foreach(MasaKlasa m in masi)
            {
                if (m!=null && m.Zafatena == 1)
                    count++;
            }
            tbActiveTables.Text = count.ToString();
        }

        public void promet()
        {
            double count = 0;
            foreach (MasaKlasa m in masi)
            {
                if(m!=null)
                    count += m.smetka();
            }
            tbProfit.Text = count.ToString();
        }

        public void fillRezz()
        {
            lbRezervations.Items.Clear();
            foreach (MasaKlasa m in masi)
            {
                if(m!=null)
                {
                    foreach(Reservation r in m.r)
                    {
                        lbRezervations.Items.Add(r);
                    }
                }
            }
        }

        private void btnTb8_Click(object sender, EventArgs e)
        {
            Masa masa7= new Masa(masi[7]);
            DialogResult d = masa7.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa(masi[2]);
            DialogResult d = masa.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa(masi[3]);
            DialogResult d = masa.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void btnTb9_Click(object sender, EventArgs e)
        {
            Masa masa8 = new Masa(masi[8]);
            DialogResult d = masa8.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void btnTb10_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa(masi[9]);
            DialogResult d = masa.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void btnTb11_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa(masi[10]);
            DialogResult d = masa.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void btnTb12_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa(masi[11]);
            DialogResult d = masa.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void btnTb13_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa(masi[12]);
            DialogResult d = masa.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa(masi[1]);
            DialogResult d = masa.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa(masi[4]);
            DialogResult d = masa.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa(masi[5]);
            DialogResult d = masa.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa(masi[6]);
            DialogResult d = masa.ShowDialog();
            activeTables();
            promet();
            fillRezz();
        }

        public void Create()
        {
            for(int i=1;i<13;i++)
            {
                List<Reservation> r = new List<Reservation>();
                List<Drinks> drinks = new List<Drinks>();
                String k = "Table " + i;
                masi[i] = new MasaKlasa(k, r, drinks, 0);
            }
            
        }
        public void removeRez()
        {
            foreach(MasaKlasa m in masi)
            {
                if(m!=null)
                {
                    foreach(Reservation r in m.r)
                    {
                        if(r==(Reservation)lbRezervations.SelectedItem)
                        {
                            m.r.Remove(r);
                            break;
                        }
                    }
                }
            }
            fillRezz();
        }
        private void lbRezervations_DoubleClick(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to remove this reservation?", "Remove Reservation", MessageBoxButtons.YesNo);
            if(d==DialogResult.Yes)
            {
                removeRez();
            }
        }
        
    }
}
