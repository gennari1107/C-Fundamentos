using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Aula01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCanvelar_Click(object sender, EventArgs e)
        {
            TextNome.Text = string.Empty;
            TextSobrenome.Text = string.Empty;
            lblNomeCompleto.Text = string.Empty;

        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario() == false)
            {
          lblNomeCompleto.Text = "Preencher todos os campos do Formulário";

            return;
            }
            lblNomeCompleto.Text = ExibirNomeCompleto(TextNome.Text, TextSobrenome.Text);

            LimparCampos();
        }
        private void LimparCampos()
        {
            TextNome.Text = string.Empty;
            TextSobrenome.Text = string.Empty;
        }

        private string ExibirNomeCompleto(string nome, string sobrenome)
        {
            string nomeCompleto = $"{nome} {sobrenome}";

            return nomeCompleto;
        }
        
        private bool ValidarFormulario()
        {
            bool valido = true;
            if (TextNome.Text == string.Empty)
            {
                valido = false;

            }
            if (TextSobrenome.Text == string.Empty)
            {
                valido = false;
            }
            return valido;
        }
    }
}