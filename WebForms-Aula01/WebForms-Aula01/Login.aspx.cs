using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;



namespace WebForms_Aula01
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBll = new UsuarioBLL();


            if (usuarioBll.Logar(txtLogin.Text, txtPassword.Text))
            {
                Session[Util.Util.SessaoUsuarioLogado] = usuarioBll.UsuarioLogado;

                Response.Redirect("Principal.aspx");
            }
            else
                lblMensagem.Text = "Usuario ou senha Invalido ERRO ";
        }
    }
}