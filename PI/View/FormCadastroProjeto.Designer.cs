namespace PI.View
{
    partial class FormCadastroProjeto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricaoProjeto = new System.Windows.Forms.TextBox();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.txtEntradas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORRENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarCircuito = new System.Windows.Forms.Button();
            this.txtDescricaoCircuito = new System.Windows.Forms.TextBox();
            this.txtCodigoCircuito = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 56);
            this.panel1.TabIndex = 34;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnImprimir.Location = new System.Drawing.Point(628, 380);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(147, 53);
            this.btnImprimir.TabIndex = 35;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnFechar.Location = new System.Drawing.Point(257, 15);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 34;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnExcluir.Location = new System.Drawing.Point(176, 15);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.Location = new System.Drawing.Point(95, 15);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnNovo.Location = new System.Drawing.Point(14, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 77);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 33;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricaoProjeto
            // 
            this.txtDescricaoProjeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoProjeto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoProjeto.Location = new System.Drawing.Point(74, 75);
            this.txtDescricaoProjeto.Name = "txtDescricaoProjeto";
            this.txtDescricaoProjeto.Size = new System.Drawing.Size(487, 20);
            this.txtDescricaoProjeto.TabIndex = 0;
            this.txtDescricaoProjeto.Tag = "1";
            this.txtDescricaoProjeto.TextChanged += new System.EventHandler(this.txtDescricaoProjeto_TextChanged);
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(567, 77);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(49, 13);
            this.lblEntradas.TabIndex = 35;
            this.lblEntradas.Text = "Entradas";
            // 
            // txtEntradas
            // 
            this.txtEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntradas.Location = new System.Drawing.Point(628, 75);
            this.txtEntradas.Name = "txtEntradas";
            this.txtEntradas.Size = new System.Drawing.Size(151, 20);
            this.txtEntradas.TabIndex = 1;
            this.txtEntradas.Tag = "1";
            this.txtEntradas.TextChanged += new System.EventHandler(this.txtEntradas_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoverItem);
            this.groupBox1.Controls.Add(this.Lista);
            this.groupBox1.Controls.Add(this.btnAdicionarCircuito);
            this.groupBox1.Controls.Add(this.txtDescricaoCircuito);
            this.groupBox1.Controls.Add(this.txtCodigoCircuito);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(14, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 258);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Circuito";
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.BackColor = System.Drawing.Color.White;
            this.btnRemoverItem.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.ForeColor = System.Drawing.Color.Red;
            this.btnRemoverItem.Location = new System.Drawing.Point(707, 32);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(42, 23);
            this.btnRemoverItem.TabIndex = 43;
            this.btnRemoverItem.TabStop = false;
            this.btnRemoverItem.Text = "-";
            this.btnRemoverItem.UseVisualStyleBackColor = false;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // Lista
            // 
            this.Lista.AllowUserToAddRows = false;
            this.Lista.AllowUserToDeleteRows = false;
            this.Lista.AllowUserToResizeRows = false;
            this.Lista.BackgroundColor = System.Drawing.Color.White;
            this.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRICAO,
            this.CORRENTE,
            this.ENTRADA});
            this.Lista.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Lista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lista.GridColor = System.Drawing.Color.White;
            this.Lista.Location = new System.Drawing.Point(3, 75);
            this.Lista.MultiSelect = false;
            this.Lista.Name = "Lista";
            this.Lista.ReadOnly = true;
            this.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Lista.Size = new System.Drawing.Size(759, 180);
            this.Lista.TabIndex = 42;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 400;
            // 
            // CORRENTE
            // 
            this.CORRENTE.HeaderText = "CORRENTE";
            this.CORRENTE.Name = "CORRENTE";
            this.CORRENTE.ReadOnly = true;
            // 
            // ENTRADA
            // 
            this.ENTRADA.HeaderText = "ENTRADA";
            this.ENTRADA.Name = "ENTRADA";
            this.ENTRADA.ReadOnly = true;
            // 
            // btnAdicionarCircuito
            // 
            this.btnAdicionarCircuito.BackColor = System.Drawing.Color.White;
            this.btnAdicionarCircuito.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAdicionarCircuito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCircuito.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCircuito.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAdicionarCircuito.Location = new System.Drawing.Point(659, 32);
            this.btnAdicionarCircuito.Name = "btnAdicionarCircuito";
            this.btnAdicionarCircuito.Size = new System.Drawing.Size(42, 23);
            this.btnAdicionarCircuito.TabIndex = 35;
            this.btnAdicionarCircuito.TabStop = false;
            this.btnAdicionarCircuito.Text = "+";
            this.btnAdicionarCircuito.UseVisualStyleBackColor = false;
            this.btnAdicionarCircuito.Click += new System.EventHandler(this.btnAdicionarCircuito_Click);
            // 
            // txtDescricaoCircuito
            // 
            this.txtDescricaoCircuito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoCircuito.Location = new System.Drawing.Point(180, 33);
            this.txtDescricaoCircuito.Name = "txtDescricaoCircuito";
            this.txtDescricaoCircuito.ReadOnly = true;
            this.txtDescricaoCircuito.Size = new System.Drawing.Size(473, 20);
            this.txtDescricaoCircuito.TabIndex = 39;
            this.txtDescricaoCircuito.Tag = "1";
            // 
            // txtCodigoCircuito
            // 
            this.txtCodigoCircuito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCircuito.Location = new System.Drawing.Point(56, 33);
            this.txtCodigoCircuito.Name = "txtCodigoCircuito";
            this.txtCodigoCircuito.ReadOnly = true;
            this.txtCodigoCircuito.Size = new System.Drawing.Size(114, 20);
            this.txtCodigoCircuito.TabIndex = 3;
            this.txtCodigoCircuito.Tag = "1";
            this.txtCodigoCircuito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCircuito_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 37;
            this.lblCodigo.Text = "Código";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(870, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 20);
            this.txtID.TabIndex = 44;
            this.txtID.TabStop = false;
            this.txtID.Tag = "1";
            this.txtID.Visible = false;
            // 
            // FormCadastroProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 445);
            this.ControlBox = false;
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEntradas);
            this.Controls.Add(this.lblEntradas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricaoProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Projetos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroProjeto_FormClosing);
            this.Load += new System.EventHandler(this.FormCadastroProjeto_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricaoProjeto;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.TextBox txtEntradas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricaoCircuito;
        private System.Windows.Forms.TextBox txtCodigoCircuito;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAdicionarCircuito;
        private System.Windows.Forms.DataGridView Lista;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORRENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTRADA;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnImprimir;
    }
}