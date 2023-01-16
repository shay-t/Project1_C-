using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Globalization;

namespace facturationClient
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\facturationClient2\facturationClient\Database1.mdf;Integrated Security=True");


        private void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Devis]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, con);
            dataadp.Fill(dta);
            devisMetroGrid.DataSource = dta;
            con.Close();
        }
        private void display_data_produit(int i)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Produit] where DevisN ='"+i+"'";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, con);
            dataadp.Fill(dta);
            produitMetroGrid.DataSource = dta;
            con.Close();
        }
        public Form3()
        {
            InitializeComponent();
            display_data();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet8.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.database1DataSet8.Produit);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet8.Devis'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.devisTableAdapter.Fill(this.database1DataSet8.Devis);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet8.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.database1DataSet8.Client);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet8.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.database1DataSet8.Client);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet8.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.database1DataSet8.Client);

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet8);

        }

        private void clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet8);

        }

        private void clientBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet8);

        }

        private void clientMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //idTextBox.Text = row.Cells["ClientId"].Value.ToString();
        }

        private void iFFTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Devis]  values ('" + Convert.ToDouble(devis.Text) + "','" + 0 + "','" +0+ "','" + date.Value.ToShortDateString()+ "','" + statut.Text + "','" + Convert.ToDouble(devis.Text) + "','"+Convert.ToDouble(clientMetroComboBox.Text) +"')";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();

            MessageBox.Show("done");

        }


        private void devisMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void devisMetroGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRow = 0;
            SelectedRow = e.RowIndex;
            if (SelectedRow != -1)
            {
                DataGridViewRow row = devisMetroGrid.Rows[SelectedRow];
                devis.Text = row.Cells["DevisN"].Value.ToString();
                //quantite.Text = row.Cells["QT"].Value.ToString();
                //prix.Text = row.Cells["total"].Value.ToString();
                //date.Value = DateTime.ParseExact(row.Cells["dater"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                statut.Text = row.Cells["Status"].Value.ToString();
                //reference.Text = row.Cells["References"].Value.ToString();  
                clientMetroComboBox.Text = row.Cells["ClientId"].Value.ToString();
                display_data_produit(Convert.ToInt32(row.Cells["DevisN"].Value));
                compteur.Text = row.Cells["Qt"].Value.ToString();
           
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Devis where DevisN = '" + Convert.ToDouble(devis.Text) + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
        }

        private void devisMetroGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Devis] set Status = 'Confirme' where DevisN = '" + Convert.ToDouble(devis.Text) + "'";
            metroButtonprint.Visible = true;
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
        }

        private void metroButtonprint_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void ajouterp_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Produit]  values ('" + Convert.ToDouble(reference.Text) + "','" + designation.Text + "','" + Convert.ToDouble(quantite.Text) + "','" + Convert.ToDouble(prix.Text) + "','" + Convert.ToDouble(devis.Text) + "')";
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select Qt,total from [Devis] where DevisN = '" + Convert.ToDouble(devis.Text) + "'";
            //cmd2.ExecuteNonQuery();
            SqlDataReader sqlDataReader = cmd2.ExecuteReader();
            if (sqlDataReader.Read())
            {
                int qt = Convert.ToInt32(sqlDataReader["Qt"]);
                double tot= Convert.ToInt32(sqlDataReader["total"]);
                sqlDataReader.Close();
                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "update [Devis] set Qt = '" + (qt+ Convert.ToDouble(quantite.Text))+"',total = '"+(tot+ Convert.ToDouble(quantite.Text)* Convert.ToDouble(prix.Text)) +"'where DevisN = '" + Convert.ToDouble(devis.Text) + "'";
                cmd4.ExecuteNonQuery();
            }

            con.Close();
            display_data();
        }

        private void produitMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void produitMetroGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRow = 0;
            SelectedRow = e.RowIndex;
            if (SelectedRow != -1)
            {
                DataGridViewRow row = produitMetroGrid.Rows[SelectedRow];
                quantite.Text = row.Cells["qtp"].Value.ToString();
                prix.Text = row.Cells["price"].Value.ToString();
                //date.Value = DateTime.ParseExact(row.Cells["dater"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                reference.Text = row.Cells["refe"].Value.ToString();
                designation.Text = row.Cells["desi"].Value.ToString();
                //display_data_produit(Convert.ToInt32(row.Cells["DevisN"].Value));
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Produit where reference = '" + Convert.ToDouble(reference.Text) + "'";
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select Qt,total from [Devis] where DevisN = '" + Convert.ToDouble(devis.Text) + "'";
            //cmd2.ExecuteNonQuery();
            SqlDataReader sqlDataReader = cmd2.ExecuteReader();
            if (sqlDataReader.Read())
            {
                int qt = Convert.ToInt32(sqlDataReader["Qt"]);
                double tot = Convert.ToInt32(sqlDataReader["total"]);
                sqlDataReader.Close();
                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "update [Devis] set Qt = '" + (qt - Convert.ToDouble(quantite.Text)) + "',total = '" + (tot - Convert.ToDouble(quantite.Text) * Convert.ToDouble(prix.Text)) + "'where DevisN = '" + Convert.ToDouble(devis.Text) + "'";
                cmd4.ExecuteNonQuery();
            }

            con.Close();
            display_data();
            display_data_produit(Convert.ToInt32(devis.Text));
        }

        private void stat_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (statut.Text == "En attente")
            {
                cmd.CommandText = "update [Devis] set Status = 'Confirme' where DevisN = '" + Convert.ToDouble(devis.Text) + "'";
                metroButtonprint.Visible = true;
            }
            else {
                cmd.CommandText = "update [Devis] set Status = 'En attente' where DevisN = '" + Convert.ToDouble(devis.Text) + "'";
                metroButtonprint.Visible = false;
            }
            
            
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
        }
    }
}
