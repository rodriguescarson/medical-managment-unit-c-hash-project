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
    public partial class create_acc : Form
    {
        public create_acc()
        {
            InitializeComponent();

        }

        public static string nne = "";
        public static string email1 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='H:\\sDetails.xlsx';Extended Properties=Excel 8.0;");
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\\Details.xlsx';Extended Properties=Excel 8.0;");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                String sql = "insert into [sheet1$](Name, Age, ContactNo, Sex,Username, Pass ,Email) values('" + name.Text + "','" + age.Text + "','" + contact.Text + "','" + sex.Text + "','" + Username.Text + "','" + Pass.Text + "','" + Email.Text + "')";
                nne = name.Text;
                email1 = Email.Text;
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("You have successfully created an account!!");
                this.Hide();
                var Form1 = new Form1();
                Form1.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void create_acc_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}