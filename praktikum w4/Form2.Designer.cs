namespace praktikum_w4
{
    partial class Form2
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
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.tBoxAlamat2 = new System.Windows.Forms.TextBox();
            this.tBoxTelp2 = new System.Windows.Forms.TextBox();
            this.tBoxNama2 = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblTelp = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(121, 157);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "Prev Data";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(40, 157);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 14;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // tBoxAlamat2
            // 
            this.tBoxAlamat2.Location = new System.Drawing.Point(99, 69);
            this.tBoxAlamat2.Name = "tBoxAlamat2";
            this.tBoxAlamat2.Size = new System.Drawing.Size(300, 23);
            this.tBoxAlamat2.TabIndex = 13;
            // 
            // tBoxTelp2
            // 
            this.tBoxTelp2.Location = new System.Drawing.Point(99, 105);
            this.tBoxTelp2.Name = "tBoxTelp2";
            this.tBoxTelp2.Size = new System.Drawing.Size(150, 23);
            this.tBoxTelp2.TabIndex = 12;
            // 
            // tBoxNama2
            // 
            this.tBoxNama2.Location = new System.Drawing.Point(99, 36);
            this.tBoxNama2.Name = "tBoxNama2";
            this.tBoxNama2.Size = new System.Drawing.Size(200, 23);
            this.tBoxNama2.TabIndex = 11;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(40, 72);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(48, 15);
            this.lblAlamat.TabIndex = 10;
            this.lblAlamat.Text = "Alamat:";
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(40, 105);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(31, 15);
            this.lblTelp.TabIndex = 9;
            this.lblTelp.Text = "Telp:";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(40, 39);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(42, 15);
            this.lblNama.TabIndex = 8;
            this.lblNama.Text = "Nama:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(202, 157);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next Data";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.tBoxAlamat2);
            this.Controls.Add(this.tBoxTelp2);
            this.Controls.Add(this.tBoxNama2);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblTelp);
            this.Controls.Add(this.lblNama);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrev;
        private Button btnKembali;
        private TextBox tBoxAlamat2;
        private TextBox tBoxTelp2;
        private TextBox tBoxNama2;
        private Label lblAlamat;
        private Label lblTelp;
        private Label lblNama;
        private Button btnNext;
    }
}