using Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MontadoraBLL
    {
        public void Salvar (MontadoraModel model)
        {
            if (model.Id == 0)
            {
                Adicionar(model);
                return;
            }
            Alterar(model);
        }
        public void Adicionar(MontadoraModel model)
        {

        }
        public void Alterar(MontadoraModel model)
        {

        }
        
    }
}