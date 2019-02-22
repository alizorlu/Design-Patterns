namespace FACTORY.PATTERN
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userLogBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.adminLogBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 133);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userLogBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 104);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userLogBtn
            // 
            this.userLogBtn.Location = new System.Drawing.Point(35, 24);
            this.userLogBtn.Name = "userLogBtn";
            this.userLogBtn.Size = new System.Drawing.Size(366, 56);
            this.userLogBtn.TabIndex = 0;
            this.userLogBtn.Text = "CREATE LOG";
            this.userLogBtn.UseVisualStyleBackColor = true;
            this.userLogBtn.Click += new System.EventHandler(this.userLogBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.adminLogBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 104);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // adminLogBtn
            // 
            this.adminLogBtn.Location = new System.Drawing.Point(35, 24);
            this.adminLogBtn.Name = "adminLogBtn";
            this.adminLogBtn.Size = new System.Drawing.Size(366, 56);
            this.adminLogBtn.TabIndex = 1;
            this.adminLogBtn.Text = "CREATE LOG";
            this.adminLogBtn.UseVisualStyleBackColor = true;
            this.adminLogBtn.Click += new System.EventHandler(this.adminLogBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 133);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Logger Example";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button userLogBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button adminLogBtn;
    }
}

