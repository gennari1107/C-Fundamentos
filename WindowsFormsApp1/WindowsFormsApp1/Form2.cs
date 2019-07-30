﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

            bool valido = true;
            if (txtNome.Text ==string.Empty)
            {
                MessageBox.Show("preencher o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                valido = false;
            }

            if (txtSobrenome.Text ==string.Empty)

            {
                MessageBox.Show("preencher o sobrenome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                valido = false;

            }
            if (txtDtNascimento.Text ==string.Empty)
            {
                MessageBox.Show("preencher a Data de Nascimento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                valido = false;

            }
            //Se o codigo estiver invalido
            //sai fora do metodo

            if (valido == false)
            {
                return;
            }
            string nome, sobrenome;
            DateTime dataNascimento;
            nome = txtNome.Text; // pegando o conteudo de dentro do txtbox
            sobrenome = txtSobrenome.Text;
            dataNascimento = Convert.ToDateTime(txtDtNascimento.Text);

        






            MessageBox.Show($@"Nome: {nome} sobrenome: {sobrenome} DataNascimento: {dataNascimento}");// interpolação
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
