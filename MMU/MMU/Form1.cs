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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string user = "";
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var create_acc = new create_acc();
            create_acc.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='H:\\sDetails.xlsx';Extended Properties=Excel 8.0;");
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\\Details.xlsx';Extended Properties=Excel 8.0;");
            con.Open();
            OleDbCommand cmd = new OleDbCommand();


            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT COUNT(*) FROM [Sheet1$] WHERE [Username] = '" + Username.Text + "' AND [Pass] = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {

                if (Username.Text == "drraj")
                {
                    this.Hide();
                    var Doctor = new Doctor();
                    //Doctor.Closed += (s, args) => this.Close();
                    Doctor.Show();
                }
                else
                {
                    user = Username.Text;
                    //MessageBox.Show("Working");
                    this.Hide();
                    var Menu = new Menu();
                    Menu.Closed += (s, args) => this.Close();
                    Menu.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please Retry!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
