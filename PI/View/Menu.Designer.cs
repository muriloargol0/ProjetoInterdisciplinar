namespace PI.View
{
    partial class Menu
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
            this.btnCadastrarCircuito = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnProjeto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarCircuito
            // 
            this.btnCadastrarCircuito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCircuito.Location = new System.Drawing.Point(21, 42);
            this.btnCadastrarCircuito.Name = "btnCadastrarCircuito";
            this.btnCadastrarCircuito.Size = new System.Drawing.Size(237, 69);
            this.btnCadastrarCircuito.TabIndex = 0;
            this.btnCadastrarCircuito.Text = "CIRCUITO";
            this.btnCadastrarCircuito.UseVisualStyleBackColor = true;
            this.btnCadastrarCircuito.Click += new System.EventHandler(this.btnCadastrarCircuito_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Location = new System.Drawing.Point(548, 42);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(237, 69);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "USUÁRIO";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnProjeto
            // 
            this.btnProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjeto.Location = new System.Drawing.Point(286, 42);
            this.btnProjeto.Name = "btnProjeto";
            this.btnProjeto.Size = new System.Drawing.Size(237, 69);
            this.btnProjeto.TabIndex = 1;
            this.btnProjeto.Text = "PROJETO";
            this.btnProjeto.UseVisualStyleBackColor = true;
            this.btnProjeto.Click += new System.EventHandler(this.btnProjeto_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 145);
            this.ControlBox = false;
            this.Controls.Add(this.btnProjeto);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCadastrarCircuito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCircuito;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnProjeto;
    }
}