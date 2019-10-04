namespace homework
{
    partial class PageArac
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
            this.buttonMainPage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMarkaEkle = new System.Windows.Forms.ComboBox();
            this.comboBoxModelEkle = new System.Windows.Forms.ComboBox();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.textBoxYılEkle = new System.Windows.Forms.TextBox();
            this.labelYilEkle = new System.Windows.Forms.Label();
            this.labelModelEkle = new System.Windows.Forms.Label();
            this.labelKasaTipEkle = new System.Windows.Forms.Label();
            this.labelMarkaEkle = new System.Windows.Forms.Label();
            this.comboBoxTipEkle = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxAraçSeç = new System.Windows.Forms.ComboBox();
            this.lblYıl = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMainPage
            // 
            this.buttonMainPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMainPage.Location = new System.Drawing.Point(640, 30);
            this.buttonMainPage.Name = "buttonMainPage";
            this.buttonMainPage.Size = new System.Drawing.Size(131, 45);
            this.buttonMainPage.TabIndex = 2;
            this.buttonMainPage.Text = "Ana Sayfa";
            this.buttonMainPage.UseVisualStyleBackColor = true;
            this.buttonMainPage.Click += new System.EventHandler(this.ButtonMainPage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMarkaEkle);
            this.groupBox1.Controls.Add(this.comboBoxModelEkle);
            this.groupBox1.Controls.Add(this.buttonKitapEkle);
            this.groupBox1.Controls.Add(this.textBoxYılEkle);
            this.groupBox1.Controls.Add(this.labelYilEkle);
            this.groupBox1.Controls.Add(this.labelModelEkle);
            this.groupBox1.Controls.Add(this.labelKasaTipEkle);
            this.groupBox1.Controls.Add(this.labelMarkaEkle);
            this.groupBox1.Controls.Add(this.comboBoxTipEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 231);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Ekle";
            // 
            // comboBoxMarkaEkle
            // 
            this.comboBoxMarkaEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxMarkaEkle.FormattingEnabled = true;
            this.comboBoxMarkaEkle.Location = new System.Drawing.Point(140, 24);
            this.comboBoxMarkaEkle.Name = "comboBoxMarkaEkle";
            this.comboBoxMarkaEkle.Size = new System.Drawing.Size(102, 29);
            this.comboBoxMarkaEkle.TabIndex = 12;
            this.comboBoxMarkaEkle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMarkaEkle_SelectedIndexChanged);
            // 
            // comboBoxModelEkle
            // 
            this.comboBoxModelEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxModelEkle.FormattingEnabled = true;
            this.comboBoxModelEkle.Location = new System.Drawing.Point(140, 59);
            this.comboBoxModelEkle.Name = "comboBoxModelEkle";
            this.comboBoxModelEkle.Size = new System.Drawing.Size(102, 29);
            this.comboBoxModelEkle.TabIndex = 11;
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
            this.buttonKitapEkle.Click += new System.EventHandler(this.ButtonKitapEkle_Click);
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
            // labelYilEkle
            // 
            this.labelYilEkle.AutoSize = true;
            this.labelYilEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYilEkle.Location = new System.Drawing.Point(25, 132);
            this.labelYilEkle.Name = "labelYilEkle";
            this.labelYilEkle.Size = new System.Drawing.Size(102, 21);
            this.labelYilEkle.TabIndex = 8;
            this.labelYilEkle.Text = "Üretim Yılı :";
            // 
            // labelModelEkle
            // 
            this.labelModelEkle.AutoSize = true;
            this.labelModelEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelModelEkle.Location = new System.Drawing.Point(25, 64);
            this.labelModelEkle.Name = "labelModelEkle";
            this.labelModelEkle.Size = new System.Drawing.Size(66, 21);
            this.labelModelEkle.TabIndex = 6;
            this.labelModelEkle.Text = "Model :";
            // 
            // labelKasaTipEkle
            // 
            this.labelKasaTipEkle.AutoSize = true;
            this.labelKasaTipEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKasaTipEkle.Location = new System.Drawing.Point(25, 97);
            this.labelKasaTipEkle.Name = "labelKasaTipEkle";
            this.labelKasaTipEkle.Size = new System.Drawing.Size(89, 21);
            this.labelKasaTipEkle.TabIndex = 4;
            this.labelKasaTipEkle.Text = "Kasa Tipi :";
            // 
            // labelMarkaEkle
            // 
            this.labelMarkaEkle.AutoSize = true;
            this.labelMarkaEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMarkaEkle.Location = new System.Drawing.Point(25, 30);
            this.labelMarkaEkle.Name = "labelMarkaEkle";
            this.labelMarkaEkle.Size = new System.Drawing.Size(127, 21);
            this.labelMarkaEkle.TabIndex = 2;
            this.labelMarkaEkle.Text = "Araç Markası : ";
            // 
            // comboBoxTipEkle
            // 
            this.comboBoxTipEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxTipEkle.FormattingEnabled = true;
            this.comboBoxTipEkle.Location = new System.Drawing.Point(140, 94);
            this.comboBoxTipEkle.Name = "comboBoxTipEkle";
            this.comboBoxTipEkle.Size = new System.Drawing.Size(102, 29);
            this.comboBoxTipEkle.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxAraçSeç);
            this.groupBox2.Controls.Add(this.lblYıl);
            this.groupBox2.Controls.Add(this.lblTip);
            this.groupBox2.Controls.Add(this.lblModel);
            this.groupBox2.Controls.Add(this.lblMarka);
            this.groupBox2.Location = new System.Drawing.Point(359, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 231);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Üretim Yılı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Model :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Kasa Tipi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Araç Markası : ";
            // 
            // comboBoxAraçSeç
            // 
            this.comboBoxAraçSeç.FormattingEnabled = true;
            this.comboBoxAraçSeç.Location = new System.Drawing.Point(30, 41);
            this.comboBoxAraçSeç.Name = "comboBoxAraçSeç";
            this.comboBoxAraçSeç.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAraçSeç.TabIndex = 20;
            this.comboBoxAraçSeç.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAraçSeç_SelectedIndexChanged);
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
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTip.Location = new System.Drawing.Point(123, 147);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(19, 21);
            this.lblTip.TabIndex = 18;
            this.lblTip.Text = "-";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(104, 113);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(19, 21);
            this.lblModel.TabIndex = 17;
            this.lblModel.Text = "-";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(132, 79);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(19, 21);
            this.lblMarka.TabIndex = 16;
            this.lblMarka.Text = "-";
            // 
            // PageArac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonMainPage);
            this.Name = "PageArac";
            this.Text = "PageArac";
            this.Load += new System.EventHandler(this.PageArac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMainPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonKitapEkle;
        private System.Windows.Forms.TextBox textBoxYılEkle;
        private System.Windows.Forms.Label labelYilEkle;
        private System.Windows.Forms.Label labelModelEkle;
        private System.Windows.Forms.Label labelKasaTipEkle;
        private System.Windows.Forms.Label labelMarkaEkle;
        private System.Windows.Forms.ComboBox comboBoxTipEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxAraçSeç;
        private System.Windows.Forms.Label lblYıl;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.ComboBox comboBoxMarkaEkle;
        private System.Windows.Forms.ComboBox comboBoxModelEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}