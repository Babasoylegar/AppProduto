namespace appproduto
{
    partial class v
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
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnbvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(416, 335);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(107, 42);
            this.btnnovo.TabIndex = 6;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnbvoltar
            // 
            this.btnbvoltar.BackColor = System.Drawing.Color.Salmon;
            this.btnbvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbvoltar.Location = new System.Drawing.Point(505, 396);
            this.btnbvoltar.Name = "btnbvoltar";
            this.btnbvoltar.Size = new System.Drawing.Size(107, 42);
            this.btnbvoltar.TabIndex = 7;
            this.btnbvoltar.Text = "Voltar";
            this.btnbvoltar.UseVisualStyleBackColor = false;
            this.btnbvoltar.Click += new System.EventHandler(this.btnbvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(590, 335);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(107, 42);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.txtrg);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.lblrg);
            this.groupBox1.Controls.Add(this.lblcpf);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(406, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 196);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(119, 75);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(157, 22);
            this.txtcpf.TabIndex = 5;
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(119, 112);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(157, 22);
            this.txtrg.TabIndex = 4;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(119, 40);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(157, 22);
            this.txtnome.TabIndex = 3;
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrg.Location = new System.Drawing.Point(26, 112);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(29, 16);
            this.lblrg.TabIndex = 2;
            this.lblrg.Text = "RG";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(26, 75);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(36, 16);
            this.lblcpf.TabIndex = 1;
            this.lblcpf.Text = "CPF";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(26, 40);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(48, 16);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome";
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1120, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnbvoltar);
            this.Controls.Add(this.btnnovo);
            this.Name = "v";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.v_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnbvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnome;
    }
}