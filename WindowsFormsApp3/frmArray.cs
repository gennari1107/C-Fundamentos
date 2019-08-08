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
    public partial class frmArray : Form
    {
        string[] alunos = new string[8];
        public frmArray()
        {
            InitializeComponent();




            lblTamanhoArray.Text = "";

            alunos[0] = "Rossi";
            alunos[1] = "Patrick";
            alunos[2] = "Vivian";
            alunos[3] = "Erik";
            alunos[4] = "Rogerio";
            alunos[5] = "Vitor";
            alunos[6] = "Fabio";
            alunos[7] = "Gennari";

        }


        private void BtnOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] == null)
                {
                    alunos[i] = txtNome.Text;
                    lblTamanhoArray.Text += $"{txtNome.Text} \r\n";
                    txtNome.Text = string.Empty;
                    break;
                }
            }
            txtNome.Text = string.Empty;



            //   alunos[0] = "Rossi";
            //   alunos[1] = "Patrick";
            //   alunos[2] = "Vivian";
            //   alunos[3] = "Erik";
            //   alunos[4] = "Rogerio";
            //   alunos[5] = "Gennari";
            //   alunos[6] = "Vitor";
            //   alunos[7] = "Fabio";
            //
            //   lblTamanhoArray.Text = alunos.Length.ToString();


        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            #region Nome Letra R
            lblNomeLetraR.Text = string.Empty;
            foreach (var aluno in alunos)
            {
                if (aluno.StartsWith("R"))
                {
                    lblNomeLetraR.Text += $"{aluno}, ";
                }
                {

                }
            }
            #endregion
        }
        #region Desafio 1
        //Criar uma array com os alunos
        //Cujo o nome começa com a letra R


        #endregion

        private void LblPrimeiroItem_Click(object sender, EventArgs e)
        {
            #region Primeiro Item   
            if (alunos.Length >= 1)
            {

                lblPrimeiroItem.Text = alunos[0];
            }
            #endregion

        }
        private void LblNomeLetraR_Click(object sender, EventArgs e)
        {
          
        }



    }
 }

