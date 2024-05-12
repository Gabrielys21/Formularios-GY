namespace Proyecto_windows
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.Label();
            this.textBoxUsr = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(332, 46);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(41, 16);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Padre: Form1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_windows.Properties.Resources.downloads_download_arrow_6852__1__icon;
            this.pictureBox1.Location = new System.Drawing.Point(53, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.Location = new System.Drawing.Point(403, 291);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(75, 23);
            this.buttonIngreso.TabIndex = 3;
            this.buttonIngreso.Text = "Ingreso";
            this.buttonIngreso.UseVisualStyleBackColor = true;
            this.buttonIngreso.Click += new System.EventHandler(this.buttonIngreso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // Pwd
            // 
            this.Pwd.AutoSize = true;
            this.Pwd.Location = new System.Drawing.Point(328, 112);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(67, 16);
            this.Pwd.TabIndex = 5;
            this.Pwd.Text = "Password";
            // 
            // textBoxUsr
            // 
            this.textBoxUsr.Location = new System.Drawing.Point(403, 83);
            this.textBoxUsr.Name = "textBoxUsr";
            this.textBoxUsr.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsr.TabIndex = 6;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(403, 112);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = 'X';
            this.textBoxPwd.Size = new System.Drawing.Size(100, 22);
            this.textBoxPwd.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxUsr);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIngreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MY APP";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Pwd;
        private System.Windows.Forms.TextBox textBoxUsr;
        private System.Windows.Forms.TextBox textBoxPwd;
    }
}

