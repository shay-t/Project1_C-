using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace facturationClient
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\facturationClient2\facturationClient\Database1.mdf;Integrated Security=True");


        private void display_data() {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Client]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, con);
            dataadp.Fill(dta);
            metroGrid1.DataSource = dta;
            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {
                metroGrid1.Rows[i].Cells["Total"].Value = '5';
            }
            con.Close();


        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet8.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter3.Fill(this.database1DataSet8.Client);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex pattern = new Regex("^[0-9]{1,8}$");
            Regex pattern2 = new Regex("^[0-9]{1,5}$");
            Regex pattern3 = new Regex("^[0-9]{15}$");
            if (!pattern.IsMatch(ifTextBox.Text))
            {
                MessageBox.Show("Veuillez verifier le champs ICE");

            }


            if (!pattern2.IsMatch(rcTextBox.Text))
            {
                MessageBox.Show("Veuillez verifier le champs RC");
            }

            if (!pattern3.IsMatch(iceTextBox.Text))
            {
                MessageBox.Show("Veuillez verifier le champs IF");
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Client] values ('"+Convert.ToDouble(idTextBox.Text)+"','"+Convert.ToDouble(iceTextBox.Text)+"','"+Convert.ToDouble(ifTextBox.Text)+"','"+Convert.ToDouble(rcTextBox.Text)+"','"+Convert.ToDouble(patenteTextBox.Text)+"','"+societeTextBox.Text+"')";
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into [InfosClient] values ('" + Convert.ToDouble(idTextBox.Text) + "','" + nomTextBox.Text + "','" + prenomTextBox.Text + "','" + emailTextBox.Text + "','" + telTextBox.Text + "','" + paysTextBox.Text + "' , '" + villeTextBox.Text + "')";
            con.Close();
            display_data();
            
            MessageBox.Show("done");

            idTextBox.Text = "";
            ifTextBox.Text = "";
            iceTextBox.Text = "";
            rcTextBox.Text = "";
            patenteTextBox.Text = "";
            societeTextBox.Text = "";
            nomTextBox.Text = "";
            prenomTextBox.Text = "";
            emailTextBox.Text = "";
            telTextBox.Text = "";
            villeTextBox.Text = "";
            paysTextBox.Text = "";

        }

        private void ifTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void iceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void rcTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void telTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        

        private void metroButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Client] where ICE = '"+Convert.ToDouble(metroTextBox1.Text)+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            int SelectedIndex = metroGrid1.SelectedRows[0].Index;
            int rowID = int.Parse(metroGrid1.Rows[SelectedIndex].Cells["ClientId"].Value.ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Client] set ICE = '" + Convert.ToDouble(iceTextBox.Text) + "' , IFF = '"+Convert.ToDouble(ifTextBox.Text)+"', RC = '" + Convert.ToDouble(rcTextBox.Text) + "' , Patente = '" + Convert.ToDouble(patenteTextBox.Text) + "' , TypeSociete = '" + societeTextBox.Text + "' where ClientId = '"+rowID+"' ";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
        }

        private void metroGrid1_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRow = 0;
            SelectedRow = e.RowIndex;
            if (SelectedRow != -1)
            {
                DataGridViewRow row = metroGrid1.Rows[SelectedRow];
                idTextBox.Text = row.Cells["ClientId"].Value.ToString();
                iceTextBox.Text = row.Cells["ICE"].Value.ToString();
                ifTextBox.Text = row.Cells["IF"].Value.ToString();
                rcTextBox.Text = row.Cells["RC"].Value.ToString();
                patenteTextBox.Text = row.Cells["Patente"].Value.ToString();
                societeTextBox.Text = row.Cells["TypeSociete"].Value.ToString();
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 myForm3 = new Form3();
            myForm3.ShowDialog();
            this.Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
