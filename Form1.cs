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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnOP1_Click(object sender, EventArgs e)
        {
            Par_Impar repetir_Textp = new Par_Impar(); //Crear Un objeto con el formulario "repetir texto"
            repetir_Textp.Show();                              //Mostrar el formulario "repetir_texto"

            this.Hide();

        }

        private void btnOP2_Click(object sender, EventArgs e)
        {
            Repetir_texto2 repetir_Texto2 = new Repetir_texto2(); //Crear un objeto con el formulario "repetir texto"
            repetir_Texto2.Show();                                //Mostrar el formulario "Repetir_texto2"

            this.Hide();

        }

        private void btnOP3_Click(object sender, EventArgs e)
        {
            Repetir_texto3 repetir_Texto3 = new Repetir_texto3(); //crear un objeto con el formulario "repetir texto"
            repetir_Texto3.Show();                                //Mostrar el formulario "repetir_texto3"

            this.Hide();

        }
    }
}
