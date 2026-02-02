using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Listbox_Gyakorlás
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<int> Számok = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                Számok.Add(rnd.Next(1000));
            }

            Számok.Sort();

            for (int i = 0; i < Számok.Count; i++)
            {
                listBox1.Items.Add(Számok[i]);
            }
            label2.Text ="Elemek száma: " + Convert.ToString(Számok.Count);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count==0)
            {
                MessageBox.Show("A Lista üres");
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i])%2==0)
                    {
                        listBox2.Items.Add(listBox1.Items[i]);
                    }
                }
                label3.Text = "Elemek száma: " + listBox2.Items.Count.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                if (!listBox1.Items.Contains(Convert.ToInt32(textBox1.Text)))
                {

                    if (Convert.ToInt32(textBox1.Text) % 2 == 0)
                    {
                        listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
                        listBox2.Items.Add(Convert.ToInt32(textBox1.Text));
                    }
                    else
                    {
                        listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Az elem már szerepel a listában");
                }
            }
            else
            {
                MessageBox.Show("Üres mező!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int keresett =Convert.ToInt32(textBox1.Text);
            if (listBox1.Items.Contains(keresett))
            {
                listBox1.SetSelected(listBox1.Items.IndexOf(keresett), true);
                if (listBox2.Items.Contains(keresett))
                {
                    listBox2.SetSelected(listBox2.Items.IndexOf(keresett), true);
                }
            }
            else
            {
                MessageBox.Show("Az elem nem szerepel a listában");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Balázs Dávid";
            Button gomb = new Button();
            gomb.Text = "Kilépés";
            gomb.Location=new Point(150, 150);
            gomb.BackColor = Color.Red;
            gomb.ForeColor = Color.White;
            this.Controls.Add(gomb);
            gomb.Click += Gomb_Click;
        }

        private void Gomb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = comboBox1.Items.Count.ToString();
            comboBox1.Items.Add("Balázs Dávid");
        }

        private void btnComboAdd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Interaction.InputBox("Új elem", "Hozzáadás","", 100, 100));
        }

        private void btnFullDelete_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string törlendő = Interaction.InputBox("Törlendő elem", "törlés", "", 10, 100);
            if (comboBox1.Items.Contains(törlendő))
            {
                comboBox1.Items.Remove(törlendő);
            }
            else
            {
                MessageBox.Show("Nincs benne az elem");
            }
        }
    }
}
