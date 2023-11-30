
namespace PhraseNet
{
    partial class frmPrincipal
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
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.btnCarregarTexto = new System.Windows.Forms.Button();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalavraChave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNormalizarTexto = new System.Windows.Forms.CheckBox();
            this.cbStopWords = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.palavra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocorrenciaNoTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocorrenciaPalavra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocorrenciaPalavra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOcorrencias = new System.Windows.Forms.DataGridView();
            this.palavra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palavra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroOcorrencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.lblPalavras = new System.Windows.Forms.Label();
            this.lblCaracter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnStopWords = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbTexto.Location = new System.Drawing.Point(532, 558);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(1217, 239);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // btnCarregarTexto
            // 
            this.btnCarregarTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarTexto.Location = new System.Drawing.Point(16, 113);
            this.btnCarregarTexto.Name = "btnCarregarTexto";
            this.btnCarregarTexto.Size = new System.Drawing.Size(134, 56);
            this.btnCarregarTexto.TabIndex = 2;
            this.btnCarregarTexto.Text = "Carregar Texto";
            this.btnCarregarTexto.UseVisualStyleBackColor = true;
            this.btnCarregarTexto.Click += new System.EventHandler(this.btnCarregarTexto_Click);
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisar.Location = new System.Drawing.Point(156, 113);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(134, 56);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palavra chave";
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPalavraChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavraChave.Location = new System.Drawing.Point(16, 50);
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.Size = new System.Drawing.Size(274, 26);
            this.txtPalavraChave.TabIndex = 4;
            this.txtPalavraChave.Text = "para";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arquivo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNormalizarTexto);
            this.groupBox1.Controls.Add(this.cbStopWords);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dgvOcorrencias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblArquivo);
            this.groupBox1.Controls.Add(this.lblPalavras);
            this.groupBox1.Controls.Add(this.lblCaracter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 594);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatisticas";
            // 
            // cbNormalizarTexto
            // 
            this.cbNormalizarTexto.AutoSize = true;
            this.cbNormalizarTexto.Checked = true;
            this.cbNormalizarTexto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNormalizarTexto.Location = new System.Drawing.Point(140, 137);
            this.cbNormalizarTexto.Name = "cbNormalizarTexto";
            this.cbNormalizarTexto.Size = new System.Drawing.Size(146, 24);
            this.cbNormalizarTexto.TabIndex = 6;
            this.cbNormalizarTexto.Text = "Normalizar Texto";
            this.cbNormalizarTexto.UseVisualStyleBackColor = true;
            // 
            // cbStopWords
            // 
            this.cbStopWords.AutoSize = true;
            this.cbStopWords.Checked = true;
            this.cbStopWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStopWords.Location = new System.Drawing.Point(10, 137);
            this.cbStopWords.Name = "cbStopWords";
            this.cbStopWords.Size = new System.Drawing.Size(112, 24);
            this.cbStopWords.TabIndex = 6;
            this.cbStopWords.Text = "Stop Words";
            this.cbStopWords.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palavra,
            this.ocorrenciaNoTexto,
            this.ocorrenciaPalavra1,
            this.ocorrenciaPalavra2});
            this.dataGridView1.Location = new System.Drawing.Point(10, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 198);
            this.dataGridView1.TabIndex = 4;
            // 
            // palavra
            // 
            this.palavra.HeaderText = "Palavra";
            this.palavra.Name = "palavra";
            this.palavra.ReadOnly = true;
            // 
            // ocorrenciaNoTexto
            // 
            this.ocorrenciaNoTexto.HeaderText = "Count";
            this.ocorrenciaNoTexto.Name = "ocorrenciaNoTexto";
            this.ocorrenciaNoTexto.ReadOnly = true;
            // 
            // ocorrenciaPalavra1
            // 
            this.ocorrenciaPalavra1.HeaderText = "Count P1";
            this.ocorrenciaPalavra1.Name = "ocorrenciaPalavra1";
            this.ocorrenciaPalavra1.ReadOnly = true;
            // 
            // ocorrenciaPalavra2
            // 
            this.ocorrenciaPalavra2.HeaderText = "Count P2";
            this.ocorrenciaPalavra2.Name = "ocorrenciaPalavra2";
            this.ocorrenciaPalavra2.ReadOnly = true;
            // 
            // dgvOcorrencias
            // 
            this.dgvOcorrencias.AllowUserToAddRows = false;
            this.dgvOcorrencias.AllowUserToDeleteRows = false;
            this.dgvOcorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcorrencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palavra1,
            this.palavra2,
            this.numeroOcorrencias});
            this.dgvOcorrencias.Location = new System.Drawing.Point(10, 180);
            this.dgvOcorrencias.Name = "dgvOcorrencias";
            this.dgvOcorrencias.ReadOnly = true;
            this.dgvOcorrencias.Size = new System.Drawing.Size(459, 198);
            this.dgvOcorrencias.TabIndex = 4;
            // 
            // palavra1
            // 
            this.palavra1.HeaderText = "Palavra 1";
            this.palavra1.Name = "palavra1";
            this.palavra1.ReadOnly = true;
            // 
            // palavra2
            // 
            this.palavra2.HeaderText = "Palavra 2";
            this.palavra2.Name = "palavra2";
            this.palavra2.ReadOnly = true;
            // 
            // numeroOcorrencias
            // 
            this.numeroOcorrencias.HeaderText = "Count";
            this.numeroOcorrencias.Name = "numeroOcorrencias";
            this.numeroOcorrencias.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Palavras:";
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivo.Location = new System.Drawing.Point(103, 37);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(14, 20);
            this.lblArquivo.TabIndex = 3;
            this.lblArquivo.Text = "-";
            // 
            // lblPalavras
            // 
            this.lblPalavras.AutoSize = true;
            this.lblPalavras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavras.Location = new System.Drawing.Point(103, 104);
            this.lblPalavras.Name = "lblPalavras";
            this.lblPalavras.Size = new System.Drawing.Size(18, 20);
            this.lblPalavras.TabIndex = 3;
            this.lblPalavras.Text = "0";
            // 
            // lblCaracter
            // 
            this.lblCaracter.AutoSize = true;
            this.lblCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracter.Location = new System.Drawing.Point(103, 70);
            this.lblCaracter.Name = "lblCaracter";
            this.lblCaracter.Size = new System.Drawing.Size(18, 20);
            this.lblCaracter.TabIndex = 3;
            this.lblCaracter.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caracteres:";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnStopWords
            // 
            this.btnStopWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopWords.Location = new System.Drawing.Point(371, 113);
            this.btnStopWords.Name = "btnStopWords";
            this.btnStopWords.Size = new System.Drawing.Size(134, 56);
            this.btnStopWords.TabIndex = 2;
            this.btnStopWords.Text = "Stop Words";
            this.btnStopWords.UseVisualStyleBackColor = true;
            this.btnStopWords.Click += new System.EventHandler(this.btnStopWords_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(532, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1217, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 809);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPalavraChave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopWords);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.btnCarregarTexto);
            this.Controls.Add(this.rtbTexto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phrase Nets";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Button btnCarregarTexto;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalavraChave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOcorrencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn palavra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn palavra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOcorrencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Label lblPalavras;
        private System.Windows.Forms.Label lblCaracter;
        private System.Windows.Forms.CheckBox cbNormalizarTexto;
        private System.Windows.Forms.CheckBox cbStopWords;
        private System.Windows.Forms.Button btnStopWords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn palavra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocorrenciaNoTexto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocorrenciaPalavra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocorrenciaPalavra2;
    }
}

