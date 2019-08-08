namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtQtdDias = new System.Windows.Forms.TextBox();
            this.txtQtdMeses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtdDias = new System.Windows.Forms.Label();
            this.lblQtdMeses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(182, 27);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(174, 20);
            this.txtData.TabIndex = 2;
            // 
            // txtQtdDias
            // 
            this.txtQtdDias.Location = new System.Drawing.Point(182, 71);
            this.txtQtdDias.Name = "txtQtdDias";
            this.txtQtdDias.Size = new System.Drawing.Size(174, 20);
            this.txtQtdDias.TabIndex = 3;
            // 
            // txtQtdMeses
            // 
            this.txtQtdMeses.Location = new System.Drawing.Point(182, 111);
            this.txtQtdMeses.Name = "txtQtdMeses";
            this.txtQtdMeses.Size = new System.Drawing.Size(174, 20);
            this.txtQtdMeses.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informe uma Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade de Dias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade de Meses:";
            // 
            // lblQtdDias
            // 
            this.lblQtdDias.AutoSize = true;
            this.lblQtdDias.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblQtdDias.Location = new System.Drawing.Point(388, 77);
            this.lblQtdDias.Name = "lblQtdDias";
            this.lblQtdDias.Size = new System.Drawing.Size(0, 13);
            this.lblQtdDias.TabIndex = 8;
            // 
            // lblQtdMeses
            // 
            this.lblQtdMeses.AutoSize = true;
            this.lblQtdMeses.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblQtdMeses.Location = new System.Drawing.Point(391, 117);
            this.lblQtdMeses.Name = "lblQtdMeses";
            this.lblQtdMeses.Size = new System.Drawing.Size(0, 13);
            this.lblQtdMeses.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1050, 306);
            this.Controls.Add(this.lblQtdMeses);
            this.Controls.Add(this.lblQtdDias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdMeses);
            this.Controls.Add(this.txtQtdDias);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtQtdDias;
        private System.Windows.Forms.TextBox txtQtdMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQtdDias;
        private System.Windows.Forms.Label lblQtdMeses;
    }
}

