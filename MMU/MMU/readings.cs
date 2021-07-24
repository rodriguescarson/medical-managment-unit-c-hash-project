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
    public partial class readings : Form
    {
        public readings()
        {
            InitializeComponent();
        }

        private void readings_Load(object sender, EventArgs e)
        {
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='H:\\sDetails.xlsx';Extended Properties=Excel 8.0;");
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\\Details.xlsx';Extended Properties=Excel 8.0;");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                DateTime Datez = DateTime.Today;
                String Temp = templevel.Value.ToString();
                String O2 = o2level.Value.ToString();
                String name = Form1.user ;
                String sql = "INSERT INTO [sheet2$](Username,Datez,Oxygen,Temperature) values('"+name+"','" + Datez.ToString("d") + "','" + O2 + "','" + Temp + "')";
                //String sql = "INSERT INTO [sheet2$](Oxygen,Temperature) values('" + o2level.Text + "','" + templevel.Text + "')";
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Menu();
            Menu.Show();
        }

        private void o2level_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
