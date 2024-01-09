using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama2sayfaa124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int index = 0;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            isimler[index] = txtAdSoyad.Text;
            index++;
           
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                lbListe.Items.Add(isimler[i]);
            }
        }
    }
}
