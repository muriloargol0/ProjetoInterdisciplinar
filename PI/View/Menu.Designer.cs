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
            this.SuspendLayout();
            // 
            // btnCadastrarCircuito
            // 
            this.btnCadastrarCircuito.Location = new System.Drawing.Point(41, 33);
            this.btnCadastrarCircuito.Name = "btnCadastrarCircuito";
            this.btnCadastrarCircuito.Size = new System.Drawing.Size(237, 55);
            this.btnCadastrarCircuito.TabIndex = 0;
            this.btnCadastrarCircuito.Text = "CADASTRAR CIRCUITO";
            this.btnCadastrarCircuito.UseVisualStyleBackColor = true;
            this.btnCadastrarCircuito.Click += new System.EventHandler(this.btnCadastrarCircuito_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCadastrarCircuito);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCircuito;
    }
}