namespace PROPERTY.PATTERN
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
            this.teacherBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacherBtn
            // 
            this.teacherBtn.Location = new System.Drawing.Point(12, 12);
            this.teacherBtn.Name = "teacherBtn";
            this.teacherBtn.Size = new System.Drawing.Size(396, 57);
            this.teacherBtn.TabIndex = 0;
            this.teacherBtn.Text = "New Teacher";
            this.teacherBtn.UseVisualStyleBackColor = true;
            this.teacherBtn.Click += new System.EventHandler(this.teacherBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(12, 75);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(396, 57);
            this.customerBtn.TabIndex = 1;
            this.customerBtn.Text = "New Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(12, 138);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(396, 57);
            this.adminBtn.TabIndex = 3;
            this.adminBtn.Text = "New Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 203);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.teacherBtn);
            this.Name = "Form1";
            this.Text = "PROPERTY.PATTERN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teacherBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button adminBtn;
    }
}

