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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Exibindo uma mensagem na tela
            MessageBox.Show("SPFC MAIOR DA AMERICA");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int numeroInteiro;
            string tipoTexto;
            decimal numeroDecimal;
            double numeroDecimalMenor;
            short numeroInteiroMenor;
            byte numeroInteiromenor;
            DateTime dataHora;
            bool verdadeiroOuFalso;

           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string nome, sobrenome = "Gennari";
            nome = "Rafael";
            string nomeCompleto = $"{nome} {sobrenome}";//Interpolação - Boa prática
            MessageBox.Show(nomeCompleto);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
