using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.Interfaz;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        Arbol solucionador = new Arbol();

        public Calculadora()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EscribirLaOperacion(object sender, EventArgs e)
        {
            if (operacion.Text == "(operacion)")
                operacion.Text = "";
            operacion.Text += ((Button)sender).Text;
        }

        private void IgualA_Click(object sender, EventArgs e)
        {
            resultado.Text = Convert.ToString(solucionador.Resolver(OP.Text));
        }
    }
}
