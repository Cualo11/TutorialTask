using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialTask
{
    public partial class Form1 : Form
    {
        private string EsPrimo(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    return string.Format("{0} no es primo", num);
                }
            }
            return string.Format("{0} es primo", num);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnEsPrimo_Click(object sender, EventArgs e)
        {
            var resultado =await Task.Run( () => EsPrimo(int.Parse(txtNumero.Text)));
            lstResultado.Items.Add(resultado);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            txtNumero.Text = int.MaxValue.ToString();
        }
    }
}
