using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_Menu_While_BF_5toB
{
    public partial class Repetir_texto2 : Form
    {
        public Repetir_texto2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string es un tipo de dato para almacenar texto
            string texto = txttexto.Text;
            int i = 0;
            listBox1.Items.Clear();

            while( i <= 10)
            {
                listBox1.Items.Add(texto);
                i++;
            }
           

        }
    }
}
