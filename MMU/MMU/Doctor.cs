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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            button2.Hide();
            button4.Hide();
        }

        public static String patientemail = "";

        private void Doctor_Load(object sender, EventArgs e)
        {
//            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='H:\\Details.xlsx';Extended Properties=Excel 8.0;");
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\\Details.xlsx';Extended Properties=Excel 8.0;");
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            DataTable rand = new DataTable();
            String sql = "Select * from [sheet2$]";
            
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            ((OleDbDataAdapter)new OleDbDataAdapter(cmd)).Fill(rand);
            datagrid.DataSource = rand;
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            button4.Hide();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\\Details.xlsx';Extended Properties=Excel 8.0;");
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='H:\\sDetails.xlsx';Extended Properties=Excel 8.0;");
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            DataTable rand = new DataTable();
            String sql = "Select * from [sheet2$] where [Username] = '" + searchname.Text + "'";
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            ((OleDbDataAdapter)new OleDbDataAdapter(cmd)).Fill(rand);
            datagrid.DataSource = rand;
            button2.Show();
        }

            private void button2_Click(object sender, EventArgs e)
        {
                
            //var create_acc = new create_acc();
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\\Details.xlsx';Extended Properties=Excel 8.0;");
          //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='H:\\sDetails.xlsx';Extended Properties=Excel 8.0;");
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            DataTable rand = new DataTable();
            String sql = "Select Name,Age,ContactNo,Sex,Username,Email from [sheet1$] where [Username] = '" + searchname.Text + "'";
            patientemail = create_acc.email1;
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            ((OleDbDataAdapter)new OleDbDataAdapter(cmd)).Fill(rand);
            datagrid.DataSource = rand;
            label5.Hide();
            label4.Hide();
            label3.Hide();
            label2.Hide();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            button4.Show();
        }

            private void button3_Click(object sender, EventArgs e)
            {
                this.Hide();
                var Form1 = new Form1();
                Form1.Show();
            }

            private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void button4_Click(object sender, EventArgs e)
            {
                this.Hide();
                var contact = new contact();
                contact.Show();
            }
        }

        

       
    }

