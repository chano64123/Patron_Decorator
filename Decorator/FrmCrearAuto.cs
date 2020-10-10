using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Negocios.Decoradores;

namespace Decorator
{
    public partial class FrmCrearAuto : Form
    {
        public FrmCrearAuto()
        {
            InitializeComponent();
           
        }
        InterfazAuto auto;
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string modelo = txtModelo.Text;
                string caracteristicas = txtCaracteristicas.Text;
                double costo = Convert.ToDouble(txtCosto.Text);
                auto = new Auto(modelo, caracteristicas, costo);
                MessageBox.Show(auto.ToString() + "\nCOSTO: " + auto.Costo());
                grpDecoraciones.Enabled = true;
                btnCrear.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Ingrese datos válidos");
            }
            
        }

        private void btnNitrogeno_Click(object sender, EventArgs e)
        {
            btnNitrogeno.Enabled = false;
            auto = new SistemaSonido(auto);
            MessageBox.Show("ESTADO: \n" + auto.Funciona() + "\n\nDESCRIPCIÓN: \n" + auto.ToString() + "\nNUEVO COSTO: \n" + auto.Costo());
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {
            btnSonido.Enabled = false;
            auto = new SistemaSonido(auto);
            MessageBox.Show("ESTADO: \n" + auto.Funciona()+ "\n\nDESCRIPCIÓN: \n" + auto.ToString()+ "\nNUEVO COSTO: \n"+auto.Costo());

        }

        private void btnSuspension_Click(object sender, EventArgs e)
        {
            btnSuspension.Enabled = false;
            auto = new Suspension(auto);
            MessageBox.Show("ESTADO: \n" + auto.Funciona() + "\n\nDESCRIPCIÓN: \n" + auto.ToString() + "\nNUEVOCOSTO: \n" + auto.Costo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
