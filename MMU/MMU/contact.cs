using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace MMU
{
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
        }

        private void contact_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            MailMessage mm = new MailMessage("drrajm804@gmail.com", textBox1.Text);
            mm.Subject = textBox2.Text;
            mm.Body = textBox3.Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("drrajm804@gmail.com", "drraj321");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mm);
            label4.Text = "Your mail has been successfully sent to " + textBox1.Text;
            //drraj321
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var contact = new Doctor();
            contact.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}