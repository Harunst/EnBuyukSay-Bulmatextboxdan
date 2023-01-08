using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBuyukSayıBulma
{
    public partial class txtSayi2 : Form
    {
        public txtSayi2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, enBuyuk, enKucuk;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txt2.Text);
            sayi3 = Convert.ToInt32(txtSayi3.Text);

            
            if (sayi1 > sayi2 && sayi1 > sayi3)
                enBuyuk = sayi1;
            else if (sayi2 > sayi3 && sayi2 > sayi1)
                enBuyuk = sayi2;
            else
                enBuyuk = sayi3;



            if (sayi1 < sayi2 && sayi1 < sayi3)
                enKucuk = sayi1;
            else if (sayi2 < sayi3 && sayi2 < sayi1)
                enKucuk = sayi2;
            else
                enKucuk = sayi3;


            txtEnBuyuk.Text = enBuyuk.ToString();
            txtEnKucuk.Text = enKucuk.ToString();
        }
    }
}
