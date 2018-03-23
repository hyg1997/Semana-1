using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPC.Order.Business;
using UPC.Order.Entities;

namespace UPC.Order.View
{
    public partial class Form1 : Form
    {
        String[] productos = { "Mouse", "Teclado", "Impresora", "Monitor", "Parlantes" };
        VentaN venta = new VentaN();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (String producto in productos)
            {
                Producto pro = new Producto();
                pro.descripcion =

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToShortDateString();
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
