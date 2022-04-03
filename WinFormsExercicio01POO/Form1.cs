using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsExercicio01POO
{
    public partial class Form1 : Form
      
    {
        int codigo;
        int horas = 0;
        double valor = 0;
        decimal operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo = int.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            horas = int.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            valor = double.Parse(textBox3.Text, CultureInfo.InvariantCulture);
            label6.Text = Convert.ToString(codigo);
            label5.Text = Convert.ToString(horas * valor);

        }
    }
}
