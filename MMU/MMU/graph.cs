using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace MMU
{
    public partial class graph : Form
    {
        public graph()
        {
            InitializeComponent();
        }

        private void graph_Load(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nm1 = Form1.user;
                //string nm1 = create_acc.nne;
                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='H:\\sDetails.xlsx';Extended Properties=Excel 8.0;");
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\\Details.xlsx';Extended Properties=Excel 8.0;");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string sql = "select * from [Sheet2$] where [Username] = '" + nm1 + "'";
                cmd.CommandText = sql;
                OleDbDataReader reader = cmd.ExecuteReader();
                
                    while (reader.Read())
                    {

                        chart1.Series["Oxygen"].Points.AddXY(reader["Datez"].ToString(), reader["Oxygen"].ToString());
                        chart1.Series["Temperature"].Points.AddXY(reader["Datez"].ToString(), reader["Temperature"].ToString());
                       
                    }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Menu();
            Menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
