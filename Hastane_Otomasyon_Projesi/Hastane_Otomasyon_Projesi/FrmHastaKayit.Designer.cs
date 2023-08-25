namespace Hastane_Otomasyon_Projesi
{
    partial class FrmHastaKayit
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
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.maskedtel = new System.Windows.Forms.MaskedTextBox();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.cmbboxcinsiyet = new System.Windows.Forms.ComboBox();
            this.btnkayıtol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(178, 306);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(180, 30);
            this.txtSifre.TabIndex = 8;
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(178, 215);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(180, 30);
            this.MskTc.TabIndex = 7;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(106, 306);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(58, 25);
            this.lblsifre.TabIndex = 6;
            this.lblsifre.Text = "Şifre:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(31, 215);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(133, 25);
            this.lbltc.TabIndex = 5;
            this.lbltc.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hasta Kayıt Paneli";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(178, 127);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(180, 30);
            this.txtad.TabIndex = 11;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Location = new System.Drawing.Point(121, 132);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(43, 25);
            this.lblad.TabIndex = 10;
            this.lblad.Text = "Ad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(178, 169);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(180, 30);
            this.txtsoyad.TabIndex = 13;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Location = new System.Drawing.Point(89, 172);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(75, 25);
            this.lblsoyad.TabIndex = 12;
            this.lblsoyad.Text = "Soyad:";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltel.Location = new System.Drawing.Point(80, 260);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(84, 25);
            this.lbltel.TabIndex = 14;
            this.lbltel.Text = "Telefon:";
            // 
            // maskedtel
            // 
            this.maskedtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtel.Location = new System.Drawing.Point(178, 257);
            this.maskedtel.Mask = "(999) 000-0000";
            this.maskedtel.Name = "maskedtel";
            this.maskedtel.Size = new System.Drawing.Size(180, 30);
            this.maskedtel.TabIndex = 15;
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcinsiyet.Location = new System.Drawing.Point(76, 359);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lblcinsiyet.TabIndex = 16;
            this.lblcinsiyet.Text = "Cinsiyet:";
            // 
            // cmbboxcinsiyet
            // 
            this.cmbboxcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbboxcinsiyet.FormattingEnabled = true;
            this.cmbboxcinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbboxcinsiyet.Location = new System.Drawing.Point(178, 351);
            this.cmbboxcinsiyet.Name = "cmbboxcinsiyet";
            this.cmbboxcinsiyet.Size = new System.Drawing.Size(180, 33);
            this.cmbboxcinsiyet.TabIndex = 17;
            // 
            // btnkayıtol
            // 
            this.btnkayıtol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnkayıtol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıtol.Location = new System.Drawing.Point(208, 412);
            this.btnkayıtol.Name = "btnkayıtol";
            this.btnkayıtol.Size = new System.Drawing.Size(118, 39);
            this.btnkayıtol.TabIndex = 18;
            this.btnkayıtol.Text = "Kayıt Ol";
            this.btnkayıtol.UseVisualStyleBackColor = false;
            // 
            // FrmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(493, 496);
            this.Controls.Add(this.btnkayıtol);
            this.Controls.Add(this.cmbboxcinsiyet);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.maskedtel);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lbltc);
            this.Name = "FrmHastaKayit";
            this.Text = "FrmHastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.MaskedTextBox maskedtel;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.ComboBox cmbboxcinsiyet;
        private System.Windows.Forms.Button btnkayıtol;
    }
}