using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace MMU
{
    public partial class viewtable : Form
    {
        public viewtable()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewtable_Load(object sender, EventArgs e)
        {
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='H:\\Details.xlsx';Extended Properties=Excel 8.0;");
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\\Details.xlsx';Extended Properties=Excel 8.0;");
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            DataTable read = new DataTable();
            String sql = "Select * from [sheet2$] where [Username] = '" + Form1.user + "'";

            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            ((OleDbDataAdapter)new OleDbDataAdapter(cmd)).Fill(read);
            dataGridView1.DataSource = read;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Menu();
            Menu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
