namespace Proyecto_windows.Formularios
{
    partial class FrmIngreso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.Sumar = new System.Windows.Forms.Button();
            this.comboBoxFacultades = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(340, 70);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumero1.TabIndex = 3;
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(340, 152);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumero2.TabIndex = 4;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(340, 240);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(100, 22);
            this.textBoxResultado.TabIndex = 5;
            // 
            // Sumar
            // 
            this.Sumar.Location = new System.Drawing.Point(326, 346);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(105, 43);
            this.Sumar.TabIndex = 6;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseVisualStyleBackColor = true;
            this.Sumar.Click += new System.EventHandler(this.Sumar_Click);
            // 
            // comboBoxFacultades
            // 
            this.comboBoxFacultades.FormattingEnabled = true;
            this.comboBoxFacultades.Location = new System.Drawing.Point(614, 64);
            this.comboBoxFacultades.Name = "comboBoxFacultades";
            this.comboBoxFacultades.Size = new System.Drawing.Size(230, 24);
            this.comboBoxFacultades.TabIndex = 7;
            this.comboBoxFacultades.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultades_SelectedIndexChanged);
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 601);
            this.Controls.Add(this.comboBoxFacultades);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIngreso";
            this.Text = "FrmIngreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button Sumar;
        private System.Windows.Forms.ComboBox comboBoxFacultades;
    }
}