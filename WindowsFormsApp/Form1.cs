using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hesap;
            hesap = Convert.ToInt16(misir.Text) * 8 + Convert.ToInt16(su.Text) * 2 + Convert.ToInt16(cay.Text) * 3 +
                    Convert.ToInt16(bilet.Text) * 15;

            kasa.Text = Convert.ToString(hesap);
            toplam.Text = Convert.ToString(Convert.ToInt16(toplam.Text) + Convert.ToInt16(kasa.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            misir.Text = "0";
            su.Text = "0";
            cay.Text = "0";
            bilet.Text = "0";
        }
    }
}
