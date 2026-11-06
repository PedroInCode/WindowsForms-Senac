namespace LabWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Nascimento = new System.Windows.Forms.Label();
            this.dtp_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.lbl_Documento = new System.Windows.Forms.Label();
            this.mtb_Documento = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.cmb_Genero = new System.Windows.Forms.ComboBox();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Black;
            this.btn_Confirmar.Location = new System.Drawing.Point(674, 400);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(114, 38);
            this.btn_Confirmar.TabIndex = 0;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulário de Cadastro";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(89, 102);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(458, 26);
            this.txt_Nome.TabIndex = 2;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(31, 108);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco.Location = new System.Drawing.Point(116, 134);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(431, 26);
            this.txt_Endereco.TabIndex = 4;
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereco.Location = new System.Drawing.Point(31, 140);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(82, 20);
            this.lbl_Endereco.TabIndex = 3;
            this.lbl_Endereco.Text = "Endereço:";
            // 
            // lbl_Nascimento
            // 
            this.lbl_Nascimento.AutoSize = true;
            this.lbl_Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nascimento.Location = new System.Drawing.Point(244, 211);
            this.lbl_Nascimento.Name = "lbl_Nascimento";
            this.lbl_Nascimento.Size = new System.Drawing.Size(97, 20);
            this.lbl_Nascimento.TabIndex = 11;
            this.lbl_Nascimento.Text = "Nascimento:";
            // 
            // dtp_Nascimento
            // 
            this.dtp_Nascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Nascimento.Location = new System.Drawing.Point(347, 210);
            this.dtp_Nascimento.Name = "dtp_Nascimento";
            this.dtp_Nascimento.Size = new System.Drawing.Size(200, 26);
            this.dtp_Nascimento.TabIndex = 12;
            // 
            // lbl_Documento
            // 
            this.lbl_Documento.AutoSize = true;
            this.lbl_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Documento.Location = new System.Drawing.Point(31, 177);
            this.lbl_Documento.Name = "lbl_Documento";
            this.lbl_Documento.Size = new System.Drawing.Size(44, 20);
            this.lbl_Documento.TabIndex = 5;
            this.lbl_Documento.Text = "CPF:";
            // 
            // mtb_Documento
            // 
            this.mtb_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_Documento.Location = new System.Drawing.Point(89, 171);
            this.mtb_Documento.Mask = "000\\.000\\.000-00";
            this.mtb_Documento.Name = "mtb_Documento";
            this.mtb_Documento.Size = new System.Drawing.Size(124, 26);
            this.mtb_Documento.TabIndex = 6;
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_Telefone.Location = new System.Drawing.Point(381, 171);
            this.mtb_Telefone.Mask = "(00) 00000-0000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(166, 26);
            this.mtb_Telefone.TabIndex = 8;
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefone.Location = new System.Drawing.Point(300, 174);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(75, 20);
            this.lbl_Telefone.TabIndex = 7;
            this.lbl_Telefone.Text = "Telefone:";
            // 
            // cmb_Genero
            // 
            this.cmb_Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Genero.FormattingEnabled = true;
            this.cmb_Genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Não Binário"});
            this.cmb_Genero.Location = new System.Drawing.Point(104, 208);
            this.cmb_Genero.Name = "cmb_Genero";
            this.cmb_Genero.Size = new System.Drawing.Size(121, 28);
            this.cmb_Genero.TabIndex = 10;
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genero.Location = new System.Drawing.Point(31, 211);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(67, 20);
            this.lbl_Genero.TabIndex = 9;
            this.lbl_Genero.Text = "Genêro:";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.White;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(35, 268);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(97, 28);
            this.btn_Cadastrar.TabIndex = 13;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.cmb_Genero);
            this.Controls.Add(this.mtb_Telefone);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.mtb_Documento);
            this.Controls.Add(this.lbl_Documento);
            this.Controls.Add(this.dtp_Nascimento);
            this.Controls.Add(this.lbl_Nascimento);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Confirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Nascimento;
        private System.Windows.Forms.DateTimePicker dtp_Nascimento;
        private System.Windows.Forms.Label lbl_Documento;
        private System.Windows.Forms.MaskedTextBox mtb_Documento;
        private System.Windows.Forms.MaskedTextBox mtb_Telefone;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.ComboBox cmb_Genero;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}

