namespace praktikum_w4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNama = new System.Windows.Forms.Label();
            this.lblTelp = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.tBoxNama = new System.Windows.Forms.TextBox();
            this.tBoxTelp = new System.Windows.Forms.TextBox();
            this.tBoxAlamat = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnLihat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(42, 35);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(42, 15);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama:";
            this.lblNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(42, 101);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(31, 15);
            this.lblTelp.TabIndex = 1;
            this.lblTelp.Text = "Telp:";
            this.lblTelp.Click += new System.EventHandler(this.lblTelp_Click);
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(42, 68);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(48, 15);
            this.lblAlamat.TabIndex = 2;
            this.lblAlamat.Text = "Alamat:";
            this.lblAlamat.Click += new System.EventHandler(this.lblAlamat_Click);
            // 
            // tBoxNama
            // 
            this.tBoxNama.Location = new System.Drawing.Point(101, 32);
            this.tBoxNama.Name = "tBoxNama";
            this.tBoxNama.Size = new System.Drawing.Size(200, 23);
            this.tBoxNama.TabIndex = 3;
            this.tBoxNama.TextChanged += new System.EventHandler(this.tBoxNama_TextChanged);
            // 
            // tBoxTelp
            // 
            this.tBoxTelp.Location = new System.Drawing.Point(101, 101);
            this.tBoxTelp.Name = "tBoxTelp";
            this.tBoxTelp.Size = new System.Drawing.Size(150, 23);
            this.tBoxTelp.TabIndex = 4;
            this.tBoxTelp.TextChanged += new System.EventHandler(this.tBoxTelp_TextChanged);
            // 
            // tBoxAlamat
            // 
            this.tBoxAlamat.Location = new System.Drawing.Point(101, 65);
            this.tBoxAlamat.Name = "tBoxAlamat";
            this.tBoxAlamat.Size = new System.Drawing.Size(300, 23);
            this.tBoxAlamat.TabIndex = 5;
            this.tBoxAlamat.TextChanged += new System.EventHandler(this.tBoxAlamat_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(42, 153);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnLihat
            // 
            this.btnLihat.Location = new System.Drawing.Point(148, 153);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(75, 23);
            this.btnLihat.TabIndex = 7;
            this.btnLihat.Text = "Lihat Data";
            this.btnLihat.UseVisualStyleBackColor = true;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tBoxAlamat);
            this.Controls.Add(this.tBoxTelp);
            this.Controls.Add(this.tBoxNama);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblTelp);
            this.Controls.Add(this.lblNama);
            this.Name = "Form1";
            this.Text = "Form Penambahan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNama;
        private Label lblTelp;
        private Label lblAlamat;
        private TextBox tBoxNama;
        private TextBox tBoxTelp;
        private TextBox tBoxAlamat;
        private Button btnSimpan;
        private Button btnLihat;
    }
}