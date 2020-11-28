using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace _2.soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            UstHesap yeni = new UstHesap();
            yeni.get_set = Convert.ToInt32(textBox1.Text);
            yeni.Hesap();
            textBox2.Text = yeni.get_set.ToString();
          
        }
    }
}
