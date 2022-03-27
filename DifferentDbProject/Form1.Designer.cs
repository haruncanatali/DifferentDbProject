namespace DifferentDbProject
{
    partial class Form1
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
            if ( disposing && ( components != null ) )
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
            this.yaziTxt = new System.Windows.Forms.TextBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.postgreChck = new System.Windows.Forms.CheckBox();
            this.sqlServerChck = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.farkliPlatfomChck = new System.Windows.Forms.CheckBox();
            this.ayniPlatformChck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // yaziTxt
            // 
            this.yaziTxt.Location = new System.Drawing.Point(66, 19);
            this.yaziTxt.Name = "yaziTxt";
            this.yaziTxt.Size = new System.Drawing.Size(214, 20);
            this.yaziTxt.TabIndex = 0;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(143, 45);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(75, 23);
            this.ekleBtn.TabIndex = 1;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ekleBtn);
            this.groupBox1.Controls.Add(this.yaziTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.postgreChck);
            this.groupBox2.Controls.Add(this.sqlServerChck);
            this.groupBox2.Location = new System.Drawing.Point(188, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veritabanı Yönetim Sistemi";
            // 
            // postgreChck
            // 
            this.postgreChck.AutoSize = true;
            this.postgreChck.Location = new System.Drawing.Point(6, 42);
            this.postgreChck.Name = "postgreChck";
            this.postgreChck.Size = new System.Drawing.Size(83, 17);
            this.postgreChck.TabIndex = 0;
            this.postgreChck.Text = "PostgreSQL";
            this.postgreChck.UseVisualStyleBackColor = true;
            // 
            // sqlServerChck
            // 
            this.sqlServerChck.AutoSize = true;
            this.sqlServerChck.Location = new System.Drawing.Point(6, 19);
            this.sqlServerChck.Name = "sqlServerChck";
            this.sqlServerChck.Size = new System.Drawing.Size(81, 17);
            this.sqlServerChck.TabIndex = 0;
            this.sqlServerChck.Text = "SQL Server";
            this.sqlServerChck.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.farkliPlatfomChck);
            this.groupBox3.Controls.Add(this.ayniPlatformChck);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 81);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eylem";
            // 
            // farkliPlatfomChck
            // 
            this.farkliPlatfomChck.AutoSize = true;
            this.farkliPlatfomChck.Location = new System.Drawing.Point(6, 42);
            this.farkliPlatfomChck.Name = "farkliPlatfomChck";
            this.farkliPlatfomChck.Size = new System.Drawing.Size(91, 17);
            this.farkliPlatfomChck.TabIndex = 0;
            this.farkliPlatfomChck.Text = "Farklı platform";
            this.farkliPlatfomChck.UseVisualStyleBackColor = true;
            // 
            // ayniPlatformChck
            // 
            this.ayniPlatformChck.AutoSize = true;
            this.ayniPlatformChck.Location = new System.Drawing.Point(6, 19);
            this.ayniPlatformChck.Name = "ayniPlatformChck";
            this.ayniPlatformChck.Size = new System.Drawing.Size(160, 17);
            this.ayniPlatformChck.TabIndex = 0;
            this.ayniPlatformChck.Text = "Aynı platfrom farklı veritabanı";
            this.ayniPlatformChck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 183);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DifferentDB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox yaziTxt;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox postgreChck;
        private System.Windows.Forms.CheckBox sqlServerChck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox farkliPlatfomChck;
        private System.Windows.Forms.CheckBox ayniPlatformChck;
    }
}

