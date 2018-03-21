using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myform
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!this.result.Text.Equals("0"))
            {
                this.result.Text += button0.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.result.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.result.Text += button2.Text;
        }
    }
}
