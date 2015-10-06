namespace aula061015
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblPresente1 = new System.Windows.Forms.Label();
            this.lblPresente2 = new System.Windows.Forms.Label();
            this.lblPresente3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtPresente1 = new System.Windows.Forms.TextBox();
            this.txtPresente2 = new System.Windows.Forms.TextBox();
            this.txtPresente3 = new System.Windows.Forms.TextBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.bntStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(13, 40);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(64, 13);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // lblPresente1
            // 
            this.lblPresente1.AutoSize = true;
            this.lblPresente1.Location = new System.Drawing.Point(12, 61);
            this.lblPresente1.Name = "lblPresente1";
            this.lblPresente1.Size = new System.Drawing.Size(80, 13);
            this.lblPresente1.TabIndex = 2;
            this.lblPresente1.Text = "Primeira opção:";
            // 
            // lblPresente2
            // 
            this.lblPresente2.AutoSize = true;
            this.lblPresente2.Location = new System.Drawing.Point(12, 84);
            this.lblPresente2.Name = "lblPresente2";
            this.lblPresente2.Size = new System.Drawing.Size(86, 13);
            this.lblPresente2.TabIndex = 3;
            this.lblPresente2.Text = "Segunda opção:";
            // 
            // lblPresente3
            // 
            this.lblPresente3.AutoSize = true;
            this.lblPresente3.Location = new System.Drawing.Point(12, 106);
            this.lblPresente3.Name = "lblPresente3";
            this.lblPresente3.Size = new System.Drawing.Size(82, 13);
            this.lblPresente3.TabIndex = 4;
            this.lblPresente3.Text = "Terceira opção:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(83, 37);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(247, 20);
            this.txtSobrenome.TabIndex = 6;
            // 
            // txtPresente1
            // 
            this.txtPresente1.Location = new System.Drawing.Point(98, 58);
            this.txtPresente1.Name = "txtPresente1";
            this.txtPresente1.Size = new System.Drawing.Size(231, 20);
            this.txtPresente1.TabIndex = 7;
            // 
            // txtPresente2
            // 
            this.txtPresente2.Location = new System.Drawing.Point(98, 81);
            this.txtPresente2.Name = "txtPresente2";
            this.txtPresente2.Size = new System.Drawing.Size(231, 20);
            this.txtPresente2.TabIndex = 8;
            // 
            // txtPresente3
            // 
            this.txtPresente3.Location = new System.Drawing.Point(98, 103);
            this.txtPresente3.Name = "txtPresente3";
            this.txtPresente3.Size = new System.Drawing.Size(231, 20);
            this.txtPresente3.TabIndex = 9;
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(254, 129);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 10;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // bntStatus
            // 
            this.bntStatus.Location = new System.Drawing.Point(164, 129);
            this.bntStatus.Name = "bntStatus";
            this.bntStatus.Size = new System.Drawing.Size(75, 23);
            this.bntStatus.TabIndex = 11;
            this.bntStatus.Text = "Status";
            this.bntStatus.UseVisualStyleBackColor = true;
            this.bntStatus.Click += new System.EventHandler(this.bntStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 190);
            this.Controls.Add(this.bntStatus);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.txtPresente3);
            this.Controls.Add(this.txtPresente2);
            this.Controls.Add(this.txtPresente1);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPresente3);
            this.Controls.Add(this.lblPresente2);
            this.Controls.Add(this.lblPresente1);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblPresente1;
        private System.Windows.Forms.Label lblPresente2;
        private System.Windows.Forms.Label lblPresente3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtPresente1;
        private System.Windows.Forms.TextBox txtPresente2;
        private System.Windows.Forms.TextBox txtPresente3;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button bntStatus;
    }
}

