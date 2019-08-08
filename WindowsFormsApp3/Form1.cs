using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(txtData.Text);
            int qtdDias = Convert.ToInt32(txtQtdDias.Text);
            data = data.AddDays(qtdDias);

            // 06-08-2019
            //dd-mm-yyyy
            //dd-MM-YY
            //dd-MMM-yy
            //dd-MMMM-yy
            // Para subtrair a qtd de dias é so colocar o sinal "negativo"

            lblQtdDias.Text = data.ToString("dd-MMMM-yyyy");
            //lblQtdMeses.Text =
            //   Convert.ToDateTime(txtData.Text)
            //   .AddMonths(Convert.ToInt32(txtQtdMeses.Text))
            //   .ToString("dd/MM/yyyy");

            var dataMes = Convert.ToDateTime(txtData.Text);
            int qtdMeses = Convert.ToInt32(txtQtdMeses.Text);
            dataMes = dataMes.AddMonths(qtdMeses);
            lblQtdMeses.Text = data.ToString("dd/MM/yyyy");


        }
    }
}
