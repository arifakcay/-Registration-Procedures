namespace homework
{
    partial class PageMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCat = new System.Windows.Forms.Button();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.buttonVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCat
            // 
            this.buttonCat.BackColor = System.Drawing.Color.Lime;
            this.buttonCat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCat.Location = new System.Drawing.Point(136, 133);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(152, 99);
            this.buttonCat.TabIndex = 0;
            this.buttonCat.Text = "Kedi";
            this.buttonCat.UseVisualStyleBackColor = false;
            this.buttonCat.Click += new System.EventHandler(this.ButtonCat_Click);
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonLibrary.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLibrary.Location = new System.Drawing.Point(314, 133);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(152, 99);
            this.buttonLibrary.TabIndex = 1;
            this.buttonLibrary.Text = "Kütüphane";
            this.buttonLibrary.UseVisualStyleBackColor = false;
            this.buttonLibrary.Click += new System.EventHandler(this.ButtonLibrary_Click);
            // 
            // buttonVehicle
            // 
            this.buttonVehicle.BackColor = System.Drawing.Color.Gray;
            this.buttonVehicle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonVehicle.Location = new System.Drawing.Point(494, 133);
            this.buttonVehicle.Name = "buttonVehicle";
            this.buttonVehicle.Size = new System.Drawing.Size(152, 99);
            this.buttonVehicle.TabIndex = 2;
            this.buttonVehicle.Text = "Araç";
            this.buttonVehicle.UseVisualStyleBackColor = false;
            this.buttonVehicle.Click += new System.EventHandler(this.ButtonVehicle_Click);
            // 
            // PageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVehicle);
            this.Controls.Add(this.buttonLibrary);
            this.Controls.Add(this.buttonCat);
            this.Name = "PageMain";
            this.Text = "PageMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCat;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Button buttonVehicle;
    }
}

