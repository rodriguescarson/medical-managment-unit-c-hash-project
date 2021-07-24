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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Carson's code: To view table
            this.Hide();
            var readings = new readings();
            readings.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Carson's code to view earlier readings
            this.Hide();
            var viewtable = new viewtable();
            viewtable.Show();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Reev's code to view graph
            this.Hide();
            var graph = new graph();
            graph.Show();
         
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            welcome.Text = "Welcome  " + Form1.user + "!";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
        }
    }
}
