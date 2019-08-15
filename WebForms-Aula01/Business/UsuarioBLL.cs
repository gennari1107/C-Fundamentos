using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Model;

namespace Business
{
    public class UsuarioBLL
    {
        public UsuarioModel UsuarioLogado
        {
            get
            {
                UsuarioModel usr = new UsuarioModel();
                usr.Login = "admin";
                usr.Nome = "administrador";

                return usr;
            }
        }
        public bool Logar(string Login, string Senha)
        {
            if (Login == "admin" && Senha == "admin")
            {
                return true;
            }
            return false;
        }       
                   
    }
}
