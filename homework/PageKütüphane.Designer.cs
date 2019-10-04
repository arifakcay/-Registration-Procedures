namespace homework
{
    partial class PageKütüphane
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
            this.buttonMainPageLibrary = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.textBoxYılEkle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxYazarEkle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTürEkle = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxKitapSec = new System.Windows.Forms.ComboBox();
            this.lblYıl = new System.Windows.Forms.Label();
            this.lblTür = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMainPageLibrary
            // 
            this.buttonMainPageLibrary.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMainPageLibrary.Location = new System.Drawing.Point(631, 29);
            this.buttonMainPageLibrary.Name = "buttonMainPageLibrary";
            this.buttonMainPageLibrary.Size = new System.Drawing.Size(131, 45);
            this.buttonMainPageLibrary.TabIndex = 1;
            this.buttonMainPageLibrary.Text = "Ana Sayfa";
            this.buttonMainPageLibrary.UseVisualStyleBackColor = true;
            this.buttonMainPageLibrary.Click += new System.EventHandler(this.ButtonMainPageLibrary_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonKitapEkle);
            this.groupBox1.Controls.Add(this.textBoxYılEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxYazarEkle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAdEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxTürEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 231);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekle";
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKitapEkle.Location = new System.Drawing.Point(93, 174);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(102, 39);
            this.buttonKitapEkle.TabIndex = 10;
            this.buttonKitapEkle.Text = "Ekle";
            this.buttonKitapEkle.UseVisualStyleBackColor = true;
            this.buttonKitapEkle.Click += new System.EventHandler(this.ButtonKediEkle_Click);
            // 
            // textBoxYılEkle
            // 
            this.textBoxYılEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYılEkle.Location = new System.Drawing.Point(140, 132);
            this.textBoxYılEkle.Name = "textBoxYılEkle";
            this.textBoxYılEkle.Size = new System.Drawing.Size(102, 28);
            this.textBoxYılEkle.TabIndex = 9;
            this.textBoxYılEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxYılEkle_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Basım Yılı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kitap Türü :";
            // 
            // textBoxYazarEkle
            // 
            this.textBoxYazarEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYazarEkle.Location = new System.Drawing.Point(140, 61);
            this.textBoxYazarEkle.Name = "textBoxYazarEkle";
            this.textBoxYazarEkle.Size = new System.Drawing.Size(184, 28);
            this.textBoxYazarEkle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazar :";
            // 
            // textBoxAdEkle
            // 
            this.textBoxAdEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdEkle.Location = new System.Drawing.Point(140, 27);
            this.textBoxAdEkle.Name = "textBoxAdEkle";
            this.textBoxAdEkle.Size = new System.Drawing.Size(184, 28);
            this.textBoxAdEkle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap Adı : ";
            // 
            // comboBoxTürEkle
            // 
            this.comboBoxTürEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxTürEkle.FormattingEnabled = true;
            this.comboBoxTürEkle.Location = new System.Drawing.Point(140, 94);
            this.comboBoxTürEkle.Name = "comboBoxTürEkle";
            this.comboBoxTürEkle.Size = new System.Drawing.Size(102, 29);
            this.comboBoxTürEkle.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxKitapSec);
            this.groupBox2.Controls.Add(this.lblYıl);
            this.groupBox2.Controls.Add(this.lblTür);
            this.groupBox2.Controls.Add(this.lblYazar);
            this.groupBox2.Controls.Add(this.lblAd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(397, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 231);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap";
            // 
            // comboBoxKitapSec
            // 
            this.comboBoxKitapSec.FormattingEnabled = true;
            this.comboBoxKitapSec.Location = new System.Drawing.Point(30, 41);
            this.comboBoxKitapSec.Name = "comboBoxKitapSec";
            this.comboBoxKitapSec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKitapSec.TabIndex = 20;
            this.comboBoxKitapSec.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKitapSec_SelectedIndexChanged);
            // 
            // lblYıl
            // 
            this.lblYıl.AutoSize = true;
            this.lblYıl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYıl.Location = new System.Drawing.Point(123, 182);
            this.lblYıl.Name = "lblYıl";
            this.lblYıl.Size = new System.Drawing.Size(19, 21);
            this.lblYıl.TabIndex = 19;
            this.lblYıl.Text = "-";
            // 
            // lblTür
            // 
            this.lblTür.AutoSize = true;
            this.lblTür.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTür.Location = new System.Drawing.Point(123, 147);
            this.lblTür.Name = "lblTür";
            this.lblTür.Size = new System.Drawing.Size(19, 21);
            this.lblTür.TabIndex = 18;
            this.lblTür.Text = "-";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.Location = new System.Drawing.Point(94, 113);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(19, 21);
            this.lblYazar.TabIndex = 17;
            this.lblYazar.Text = "-";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(123, 79);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(19, 21);
            this.lblAd.TabIndex = 16;
            this.lblAd.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Basım Yılı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kitap Türü :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Yazar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(26, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kitap Adı : ";
            // 
            // PageKütüphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonMainPageLibrary);
            this.Name = "PageKütüphane";
            this.Text = "PageKütüphane";
            this.Load += new System.EventHandler(this.PageKütüphane_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMainPageLibrary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonKitapEkle;
        private System.Windows.Forms.TextBox textBoxYılEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxYazarEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTürEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxKitapSec;
        private System.Windows.Forms.Label lblYıl;
        private System.Windows.Forms.Label lblTür;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}