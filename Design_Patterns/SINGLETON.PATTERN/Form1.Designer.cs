namespace SINGLETON.PATTERN
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
            this.getModelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.cityCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birtDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // getModelBtn
            // 
            this.getModelBtn.Location = new System.Drawing.Point(12, 229);
            this.getModelBtn.Name = "getModelBtn";
            this.getModelBtn.Size = new System.Drawing.Size(275, 32);
            this.getModelBtn.TabIndex = 0;
            this.getModelBtn.Text = "Save User";
            this.getModelBtn.UseVisualStyleBackColor = true;
            this.getModelBtn.Click += new System.EventHandler(this.getModelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(13, 34);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(274, 22);
            this.emailTxt.TabIndex = 2;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // cityCode
            // 
            this.cityCode.Location = new System.Drawing.Point(15, 80);
            this.cityCode.Name = "cityCode";
            this.cityCode.Size = new System.Drawing.Size(274, 22);
            this.cityCode.TabIndex = 4;
            this.cityCode.TextChanged += new System.EventHandler(this.cityCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "City Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birth Date";
            // 
            // birtDate
            // 
            this.birtDate.Location = new System.Drawing.Point(17, 139);
            this.birtDate.Name = "birtDate";
            this.birtDate.Size = new System.Drawing.Size(272, 22);
            this.birtDate.TabIndex = 6;
            this.birtDate.ValueChanged += new System.EventHandler(this.birtDate_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 285);
            this.Controls.Add(this.birtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getModelBtn);
            this.Name = "Form1";
            this.Text = "Singleton Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getModelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox cityCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birtDate;
    }
}

