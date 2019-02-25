namespace ABSTRACTFACTORY.PATTERN
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
            this.adminBtn = new System.Windows.Forms.Button();
            this.editorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(12, 17);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(297, 74);
            this.adminBtn.TabIndex = 0;
            this.adminBtn.Text = "Admin Operation";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // editorBtn
            // 
            this.editorBtn.Location = new System.Drawing.Point(12, 97);
            this.editorBtn.Name = "editorBtn";
            this.editorBtn.Size = new System.Drawing.Size(297, 74);
            this.editorBtn.TabIndex = 1;
            this.editorBtn.Text = "Editor Operation";
            this.editorBtn.UseVisualStyleBackColor = true;
            this.editorBtn.Click += new System.EventHandler(this.editorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 189);
            this.Controls.Add(this.editorBtn);
            this.Controls.Add(this.adminBtn);
            this.Name = "Form1";
            this.Text = "ABSTRACT FACTORY";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button editorBtn;
    }
}

