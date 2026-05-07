namespace appproduto
{
    partial class frmmenu
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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnproduto = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelmenu.Controls.Add(this.btncliente);
            this.panelmenu.Controls.Add(this.btnproduto);
            this.panelmenu.Location = new System.Drawing.Point(64, 56);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(1000, 474);
            this.panelmenu.TabIndex = 9;
            // 
            // btnproduto
            // 
            this.btnproduto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduto.Location = new System.Drawing.Point(387, 96);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.Size = new System.Drawing.Size(232, 78);
            this.btnproduto.TabIndex = 5;
            this.btnproduto.Text = "Produto";
            this.btnproduto.UseVisualStyleBackColor = false;
            this.btnproduto.Click += new System.EventHandler(this.btnproduto_Click);
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.Location = new System.Drawing.Point(387, 297);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(232, 78);
            this.btncliente.TabIndex = 6;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1120, 590);
            this.Controls.Add(this.panelmenu);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnproduto;
        private System.Windows.Forms.Button btncliente;
    }
}