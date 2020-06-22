namespace PI.View
{
    partial class FormCadastroCircuito
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
            this.components = new System.ComponentModel.Container();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtPotenciaAparente = new System.Windows.Forms.MaskedTextBox();
            this.lblPotenciaAparente = new System.Windows.Forms.Label();
            this.lblDisjuntorDR = new System.Windows.Forms.Label();
            this.lblDRAmper = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblDisjuntor = new System.Windows.Forms.Label();
            this.txtBitolaCabo = new System.Windows.Forms.MaskedTextBox();
            this.lblBitolaCabo = new System.Windows.Forms.Label();
            this.lblCorrenteAlternada = new System.Windows.Forms.Label();
            this.lblFatorPotencia = new System.Windows.Forms.Label();
            this.lblPotenciaAtiva = new System.Windows.Forms.Label();
            this.lblTensao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblFases = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtCorrenteAlternada = new System.Windows.Forms.TextBox();
            this.ttDisjuntorDR = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtFatorPotencia = new System.Windows.Forms.TextBox();
            this.txtTensao = new System.Windows.Forms.TextBox();
            this.txtPotenciaAtiva = new System.Windows.Forms.TextBox();
            this.txtDRAmper = new System.Windows.Forms.TextBox();
            this.txtDisjuntor = new System.Windows.Forms.TextBox();
            this.txtFases = new System.Windows.Forms.TextBox();
            this.txtTipoInstalacao = new System.Windows.Forms.ComboBox();
            this.txtDisjuntorDR = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(121, 102);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(604, 20);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Tag = "1";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 109);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtPotenciaAparente
            // 
            this.txtPotenciaAparente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPotenciaAparente.Location = new System.Drawing.Point(121, 154);
            this.txtPotenciaAparente.Mask = "0000.0";
            this.txtPotenciaAparente.Name = "txtPotenciaAparente";
            this.txtPotenciaAparente.Size = new System.Drawing.Size(144, 20);
            this.txtPotenciaAparente.TabIndex = 5;
            this.txtPotenciaAparente.Tag = "1";
            this.txtPotenciaAparente.Enter += new System.EventHandler(this.txtPotenciaAparente_Enter);
            this.txtPotenciaAparente.Leave += new System.EventHandler(this.AtualizaCorrente);
            // 
            // lblPotenciaAparente
            // 
            this.lblPotenciaAparente.AutoSize = true;
            this.lblPotenciaAparente.Location = new System.Drawing.Point(13, 156);
            this.lblPotenciaAparente.Name = "lblPotenciaAparente";
            this.lblPotenciaAparente.Size = new System.Drawing.Size(95, 13);
            this.lblPotenciaAparente.TabIndex = 3;
            this.lblPotenciaAparente.Text = "Potencia Aparente";
            // 
            // lblDisjuntorDR
            // 
            this.lblDisjuntorDR.AutoSize = true;
            this.lblDisjuntorDR.Location = new System.Drawing.Point(13, 208);
            this.lblDisjuntorDR.Name = "lblDisjuntorDR";
            this.lblDisjuntorDR.Size = new System.Drawing.Size(67, 13);
            this.lblDisjuntorDR.TabIndex = 4;
            this.lblDisjuntorDR.Text = "Disjuntor DR";
            this.ttDisjuntorDR.SetToolTip(this.lblDisjuntorDR, "Disjuntor que possui proteção contra choque elétrico");
            // 
            // lblDRAmper
            // 
            this.lblDRAmper.AutoSize = true;
            this.lblDRAmper.Location = new System.Drawing.Point(280, 208);
            this.lblDRAmper.Name = "lblDRAmper";
            this.lblDRAmper.Size = new System.Drawing.Size(59, 13);
            this.lblDRAmper.TabIndex = 6;
            this.lblDRAmper.Text = "DR Amper.";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(15, 232);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 9;
            this.lblObservacao.Text = "Observação";
            // 
            // lblDisjuntor
            // 
            this.lblDisjuntor.AutoSize = true;
            this.lblDisjuntor.Location = new System.Drawing.Point(506, 156);
            this.lblDisjuntor.Name = "lblDisjuntor";
            this.lblDisjuntor.Size = new System.Drawing.Size(48, 13);
            this.lblDisjuntor.TabIndex = 12;
            this.lblDisjuntor.Text = "Disjuntor";
            this.ttDisjuntorDR.SetToolTip(this.lblDisjuntor, "Disjuntor contra curto e sobrecarga");
            // 
            // txtBitolaCabo
            // 
            this.txtBitolaCabo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBitolaCabo.Location = new System.Drawing.Point(583, 179);
            this.txtBitolaCabo.Mask = "0.00";
            this.txtBitolaCabo.Name = "txtBitolaCabo";
            this.txtBitolaCabo.ReadOnly = true;
            this.txtBitolaCabo.Size = new System.Drawing.Size(142, 20);
            this.txtBitolaCabo.TabIndex = 10;
            this.txtBitolaCabo.Tag = "1";
            this.ttDisjuntorDR.SetToolTip(this.txtBitolaCabo, "Proteção contra choque elétrico");
            // 
            // lblBitolaCabo
            // 
            this.lblBitolaCabo.AutoSize = true;
            this.lblBitolaCabo.Location = new System.Drawing.Point(506, 182);
            this.lblBitolaCabo.Name = "lblBitolaCabo";
            this.lblBitolaCabo.Size = new System.Drawing.Size(76, 13);
            this.lblBitolaCabo.TabIndex = 14;
            this.lblBitolaCabo.Text = "Bitola do Cabo";
            // 
            // lblCorrenteAlternada
            // 
            this.lblCorrenteAlternada.AutoSize = true;
            this.lblCorrenteAlternada.Location = new System.Drawing.Point(280, 156);
            this.lblCorrenteAlternada.Name = "lblCorrenteAlternada";
            this.lblCorrenteAlternada.Size = new System.Drawing.Size(65, 13);
            this.lblCorrenteAlternada.TabIndex = 16;
            this.lblCorrenteAlternada.Text = "Corrente Alt.";
            // 
            // lblFatorPotencia
            // 
            this.lblFatorPotencia.AutoSize = true;
            this.lblFatorPotencia.Location = new System.Drawing.Point(506, 133);
            this.lblFatorPotencia.Name = "lblFatorPotencia";
            this.lblFatorPotencia.Size = new System.Drawing.Size(76, 13);
            this.lblFatorPotencia.TabIndex = 18;
            this.lblFatorPotencia.Text = "Fator Potência";
            // 
            // lblPotenciaAtiva
            // 
            this.lblPotenciaAtiva.AutoSize = true;
            this.lblPotenciaAtiva.Location = new System.Drawing.Point(280, 132);
            this.lblPotenciaAtiva.Name = "lblPotenciaAtiva";
            this.lblPotenciaAtiva.Size = new System.Drawing.Size(76, 13);
            this.lblPotenciaAtiva.TabIndex = 19;
            this.lblPotenciaAtiva.Text = "Potência Ativa";
            // 
            // lblTensao
            // 
            this.lblTensao.AutoSize = true;
            this.lblTensao.Location = new System.Drawing.Point(13, 132);
            this.lblTensao.Name = "lblTensao";
            this.lblTensao.Size = new System.Drawing.Size(43, 13);
            this.lblTensao.TabIndex = 21;
            this.lblTensao.Text = "Tensao";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 83);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 24;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(121, 76);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(144, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Tag = "1";
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblFases
            // 
            this.lblFases.AutoSize = true;
            this.lblFases.Location = new System.Drawing.Point(13, 182);
            this.lblFases.Name = "lblFases";
            this.lblFases.Size = new System.Drawing.Size(35, 13);
            this.lblFases.TabIndex = 25;
            this.lblFases.Text = "Fases";
            this.lblFases.Click += new System.EventHandler(this.lblFases_Click);
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
            this.panel1.Size = new System.Drawing.Size(748, 56);
            this.panel1.TabIndex = 31;
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
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(796, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(144, 20);
            this.txtID.TabIndex = 32;
            this.txtID.Visible = false;
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Location = new System.Drawing.Point(121, 232);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(604, 120);
            this.txtObservacao.TabIndex = 13;
            this.txtObservacao.Tag = "1";
            // 
            // txtCorrenteAlternada
            // 
            this.txtCorrenteAlternada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorrenteAlternada.Location = new System.Drawing.Point(381, 154);
            this.txtCorrenteAlternada.Name = "txtCorrenteAlternada";
            this.txtCorrenteAlternada.ReadOnly = true;
            this.txtCorrenteAlternada.Size = new System.Drawing.Size(119, 20);
            this.txtCorrenteAlternada.TabIndex = 6;
            // 
            // ttDisjuntorDR
            // 
            this.ttDisjuntorDR.ToolTipTitle = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tipo de Instalação";
            this.ttDisjuntorDR.SetToolTip(this.label1, "Disjuntor contra curto e sobrecarga");
            // 
            // txtFatorPotencia
            // 
            this.txtFatorPotencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFatorPotencia.Location = new System.Drawing.Point(583, 128);
            this.txtFatorPotencia.Name = "txtFatorPotencia";
            this.txtFatorPotencia.Size = new System.Drawing.Size(142, 20);
            this.txtFatorPotencia.TabIndex = 4;
            this.txtFatorPotencia.Tag = "1";
            this.txtFatorPotencia.TextChanged += new System.EventHandler(this.txtFatorPotencia_TextChanged);
            this.txtFatorPotencia.Leave += new System.EventHandler(this.txtFatorPotencia_Leave);
            // 
            // txtTensao
            // 
            this.txtTensao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTensao.Location = new System.Drawing.Point(121, 128);
            this.txtTensao.Name = "txtTensao";
            this.txtTensao.Size = new System.Drawing.Size(144, 20);
            this.txtTensao.TabIndex = 2;
            this.txtTensao.Tag = "1";
            this.txtTensao.TextChanged += new System.EventHandler(this.txtTensao_TextChanged);
            // 
            // txtPotenciaAtiva
            // 
            this.txtPotenciaAtiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPotenciaAtiva.Location = new System.Drawing.Point(381, 128);
            this.txtPotenciaAtiva.Name = "txtPotenciaAtiva";
            this.txtPotenciaAtiva.Size = new System.Drawing.Size(118, 20);
            this.txtPotenciaAtiva.TabIndex = 3;
            this.txtPotenciaAtiva.Tag = "1";
            this.txtPotenciaAtiva.TextChanged += new System.EventHandler(this.txtPotenciaAtiva_TextChanged);
            // 
            // txtDRAmper
            // 
            this.txtDRAmper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDRAmper.Location = new System.Drawing.Point(381, 206);
            this.txtDRAmper.Name = "txtDRAmper";
            this.txtDRAmper.Size = new System.Drawing.Size(119, 20);
            this.txtDRAmper.TabIndex = 12;
            this.txtDRAmper.Tag = "1";
            // 
            // txtDisjuntor
            // 
            this.txtDisjuntor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisjuntor.Location = new System.Drawing.Point(583, 154);
            this.txtDisjuntor.Name = "txtDisjuntor";
            this.txtDisjuntor.Size = new System.Drawing.Size(143, 20);
            this.txtDisjuntor.TabIndex = 7;
            this.txtDisjuntor.Tag = "1";
            this.txtDisjuntor.TextChanged += new System.EventHandler(this.txtDisjuntor_TextChanged);
            // 
            // txtFases
            // 
            this.txtFases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFases.Location = new System.Drawing.Point(121, 180);
            this.txtFases.Name = "txtFases";
            this.txtFases.Size = new System.Drawing.Size(144, 20);
            this.txtFases.TabIndex = 8;
            this.txtFases.Tag = "1";
            this.txtFases.TextChanged += new System.EventHandler(this.txtFases_TextChanged);
            // 
            // txtTipoInstalacao
            // 
            this.txtTipoInstalacao.FormattingEnabled = true;
            this.txtTipoInstalacao.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "C",
            "D"});
            this.txtTipoInstalacao.Location = new System.Drawing.Point(381, 179);
            this.txtTipoInstalacao.Name = "txtTipoInstalacao";
            this.txtTipoInstalacao.Size = new System.Drawing.Size(119, 21);
            this.txtTipoInstalacao.TabIndex = 9;
            this.txtTipoInstalacao.Tag = "1";
            this.txtTipoInstalacao.TextChanged += new System.EventHandler(this.txtTipoInstalacao_TextChanged);
            // 
            // txtDisjuntorDR
            // 
            this.txtDisjuntorDR.FormattingEnabled = true;
            this.txtDisjuntorDR.Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            this.txtDisjuntorDR.Location = new System.Drawing.Point(121, 205);
            this.txtDisjuntorDR.Name = "txtDisjuntorDR";
            this.txtDisjuntorDR.Size = new System.Drawing.Size(144, 21);
            this.txtDisjuntorDR.TabIndex = 11;
            this.txtDisjuntorDR.Tag = "1";
            this.txtDisjuntorDR.SelectedIndexChanged += new System.EventHandler(this.txtDisjuntorDR_SelectedIndexChanged);
            // 
            // FormCadastroCircuito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 394);
            this.ControlBox = false;
            this.Controls.Add(this.txtDisjuntorDR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoInstalacao);
            this.Controls.Add(this.txtFases);
            this.Controls.Add(this.txtDisjuntor);
            this.Controls.Add(this.txtDRAmper);
            this.Controls.Add(this.txtPotenciaAtiva);
            this.Controls.Add(this.txtTensao);
            this.Controls.Add(this.txtFatorPotencia);
            this.Controls.Add(this.txtCorrenteAlternada);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFases);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTensao);
            this.Controls.Add(this.lblPotenciaAtiva);
            this.Controls.Add(this.lblFatorPotencia);
            this.Controls.Add(this.lblCorrenteAlternada);
            this.Controls.Add(this.lblBitolaCabo);
            this.Controls.Add(this.lblDisjuntor);
            this.Controls.Add(this.txtBitolaCabo);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblDRAmper);
            this.Controls.Add(this.lblDisjuntorDR);
            this.Controls.Add(this.lblPotenciaAparente);
            this.Controls.Add(this.txtPotenciaAparente);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroCircuito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Circuitos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroCircuito_FormClosing);
            this.Load += new System.EventHandler(this.FormCadastroCircuito_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.MaskedTextBox txtPotenciaAparente;
        private System.Windows.Forms.Label lblPotenciaAparente;
        private System.Windows.Forms.Label lblDisjuntorDR;
        private System.Windows.Forms.Label lblDRAmper;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblDisjuntor;
        private System.Windows.Forms.MaskedTextBox txtBitolaCabo;
        private System.Windows.Forms.Label lblBitolaCabo;
        private System.Windows.Forms.Label lblCorrenteAlternada;
        private System.Windows.Forms.Label lblFatorPotencia;
        private System.Windows.Forms.Label lblPotenciaAtiva;
        private System.Windows.Forms.Label lblTensao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblFases;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtCorrenteAlternada;
        private System.Windows.Forms.ToolTip ttDisjuntorDR;
        private System.Windows.Forms.TextBox txtFatorPotencia;
        private System.Windows.Forms.TextBox txtTensao;
        private System.Windows.Forms.TextBox txtPotenciaAtiva;
        private System.Windows.Forms.TextBox txtDRAmper;
        private System.Windows.Forms.TextBox txtDisjuntor;
        private System.Windows.Forms.TextBox txtFases;
        private System.Windows.Forms.ComboBox txtTipoInstalacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtDisjuntorDR;
    }
}