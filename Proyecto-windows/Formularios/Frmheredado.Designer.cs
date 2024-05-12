namespace Proyecto_windows.Formularios
{
    partial class Frmheredado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSaludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaludo
            // 
            this.buttonSaludo.Location = new System.Drawing.Point(532, 213);
            this.buttonSaludo.Name = "buttonSaludo";
            this.buttonSaludo.Size = new System.Drawing.Size(100, 79);
            this.buttonSaludo.TabIndex = 2;
            this.buttonSaludo.Text = "Saludo";
            this.buttonSaludo.UseVisualStyleBackColor = true;
            this.buttonSaludo.Click += new System.EventHandler(this.buttonSaludo_Click);
            // 
            // Frmheredado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaludo);
            this.Name = "Frmheredado";
            this.Load += new System.EventHandler(this.Frmheredado_Load);
            this.Controls.SetChildIndex(this.buttonSaludo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaludo;
    }
}
