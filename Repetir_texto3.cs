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
    public partial class Repetir_texto3 : Form
    {
        public Repetir_texto3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int num))
            {
                int i = 0;
                int suma = 0;

                while (i <= num)
                {
                    suma = suma + 1;

                    i++;
                }
                MessageBox.Show($"sumatoria: {suma}");
            }
            else
            {
                MessageBox.Show("Ingrese un numero");
            }




        }   

    }            
}
