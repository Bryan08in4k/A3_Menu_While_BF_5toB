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
    public partial class Par_Impar : Form
    {
        public Par_Impar()
        {
            InitializeComponent();
        }

        private void Repetir_textp_Load(object sender, EventArgs e)
        {

        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();        // limpiar la lista
            int i = 1;

            while (i <= 20)
            {
                if(i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                i = i + 1;
            }
        }

        private void btnimpares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();        // limpiar la lista
            int i = 1;

            while (i <= 20)
            {
                if (i % 2 == 1)
                {
                    listBox1.Items.Add(i);
                }
                i = i + 1;
            }
        }
    }
}
