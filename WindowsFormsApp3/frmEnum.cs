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
    public partial class btnOK : Form
    {
        public btnOK()
        {
            InitializeComponent();
        }
        enum TimeEnum
        {

            SaoPaulo,
            Corinthians,
            Palmeiras,
            Santos,
            Portuguesa
        }


        private void OK_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.ToLower();
            nome = nome.Trim();
            TimeEnum time;
            if (nome == "fabio" || nome == "kleber" || nome == "rossi" || nome == "vivian")
            {
                time = TimeEnum.Corinthians;
            }
            else if (nome == "patrick" || nome == "erik")
                time = TimeEnum.Palmeiras;

            else if (nome == "gennari" || nome == "vitor")
                time = TimeEnum.SaoPaulo;

            else if (nome == "rogerio")
                time = TimeEnum.Santos;

            else
            {
                time = TimeEnum.Portuguesa;
            }
            switch (time)
            {
                case TimeEnum.SaoPaulo:
                    txtNome.Text=($"{nome} seu time é tri-campeão do Mundo");
                    break;
                case TimeEnum.Corinthians:
                    txtNome.Text=($"{nome} seu time é ridiculo");
                    break;
                case TimeEnum.Palmeiras:
                    txtNome.Text=($"{nome}seu time não tem copinha nem mundial");
                    break;
                case TimeEnum.Santos:
                    txtNome.Text=($"{nome}era uma vez o pelé");
                    break;
                case TimeEnum.Portuguesa:
                    txtNome.Text=($"{nome} tambem não tem copinha, nem mundial");
                    break;
                default:
                    txtNome.Text=($"{nome} ahhhhh vai ver o show do Sandy & Junior");
                    break;
            }
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
        }
    }
}
