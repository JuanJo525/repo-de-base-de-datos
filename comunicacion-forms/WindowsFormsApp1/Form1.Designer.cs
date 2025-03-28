namespace WindowsFormsApp1
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
            this.lbl_usu = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_usu = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_usu
            // 
            this.lbl_usu.AutoSize = true;
            this.lbl_usu.Location = new System.Drawing.Point(74, 112);
            this.lbl_usu.Name = "lbl_usu";
            this.lbl_usu.Size = new System.Drawing.Size(43, 13);
            this.lbl_usu.TabIndex = 0;
            this.lbl_usu.Text = "Usuario";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(64, 179);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Password";
            // 
            // txt_usu
            // 
            this.txt_usu.Location = new System.Drawing.Point(151, 109);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(211, 20);
            this.txt_usu.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(151, 172);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(211, 20);
            this.txt_pass.TabIndex = 3;
            // 
            // btn_continuar
            // 
            this.btn_continuar.Location = new System.Drawing.Point(282, 299);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(129, 32);
            this.btn_continuar.TabIndex = 4;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(67, 299);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 32);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancel";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_usu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usu;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_usu;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}

