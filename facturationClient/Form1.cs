using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace facturationClient
{
    public partial class Form1 : MetroForm
    {
        public double T;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                double P = Convert.ToDouble(prix.Text);
                double Q = Convert.ToDouble(quantite.Text);
                double MHT = P * Q;
                ListViewItem it = new ListViewItem();
                it.Text = designation.Text;
                it.SubItems.Add(prix.Text);
                it.SubItems.Add(quantite.Text);
                it.SubItems.Add(Convert.ToString(MHT));

                if (radio1.Checked == true)
                {
                    T = 0.07;
                }
                else if (radio2.Checked == true)
                {
                    T = 0.2;
                    
                }
                else { throw new Exception(); }

                it.SubItems.Add(Convert.ToString((MHT*T)));
                it.SubItems.Add(Convert.ToString(MHT + T * MHT));
                it.SubItems.Add(reference.Text);
                listView1.Items.Add(it);

                double THTC = 0;
                double TTVA = 0;

                for (int i = 0; i < listView1.Items.Count; i++) {
                    
                    THTC += Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                    TTVA += Convert.ToDouble(listView1.Items[i].SubItems[4].Text);

                }
                textBox1.Text = THTC.ToString();
                textBox2.Text = TTVA.ToString();
                textBox3.Text = (THTC + TTVA).ToString();

            }
            catch (Exception ex) { MessageBox.Show("Verifiez les champs"); }
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0) {
                int i = listView1.SelectedIndices[0];
                designation.Text = listView1.Items[i].SubItems[0].Text;
                prix.Text = listView1.Items[i].SubItems[1].Text;
                quantite.Text = listView1.Items[i].SubItems[2].Text;
                reference.Text = listView1.Items[i].SubItems[6].Text;
                if (Convert.ToDouble(listView1.Items[i].SubItems[3].Text) == 20 * Convert.ToDouble(listView1.Items[i].SubItems[4].Text))
                {
                    radio1.Checked = true;
                }
                else{
                    radio2.Checked = true;
                }
                listView1.Items[i].Remove();

            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            designation.Text = "";
            reference.Text = "";
            prix.Text = "";
            quantite.Text = "";
            radio1.Checked = false;
            radio2.Checked = false;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 myForm2 = new Form2();
            myForm2.ShowDialog();
            this.Show();



        }
    }
}
