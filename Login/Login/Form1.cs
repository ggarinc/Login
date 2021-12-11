using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
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

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if ((tbusuario.Text != "") && (tbpassword.Text != ""))
            {
                if ((tbusuario.Text == "admin") && (tbpassword.Text == "1234"))
                    MessageBox.Show("Bienvenido");
                else
                    MessageBox.Show("Datos incorrectos");


            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
