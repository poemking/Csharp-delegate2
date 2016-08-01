namespace WinProj_delegate2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoser = new System.Windows.Forms.Button();
            this.btnFriend = new System.Windows.Forms.Button();
            this.btnGirl = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoser
            // 
            this.btnLoser.Location = new System.Drawing.Point(13, 41);
            this.btnLoser.Name = "btnLoser";
            this.btnLoser.Size = new System.Drawing.Size(75, 23);
            this.btnLoser.TabIndex = 0;
            this.btnLoser.Text = "魯蛇借10元";
            this.btnLoser.UseVisualStyleBackColor = true;
            this.btnLoser.Click += new System.EventHandler(this.btnLoser_Click);
            // 
            // btnFriend
            // 
            this.btnFriend.Location = new System.Drawing.Point(131, 41);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Size = new System.Drawing.Size(75, 23);
            this.btnFriend.TabIndex = 1;
            this.btnFriend.Text = "死黨借100";
            this.btnFriend.UseVisualStyleBackColor = true;
            this.btnFriend.Click += new System.EventHandler(this.btnFriend_Click);
            // 
            // btnGirl
            // 
            this.btnGirl.Location = new System.Drawing.Point(249, 41);
            this.btnGirl.Name = "btnGirl";
            this.btnGirl.Size = new System.Drawing.Size(75, 23);
            this.btnGirl.TabIndex = 2;
            this.btnGirl.Text = "正妹借30萬";
            this.btnGirl.UseVisualStyleBackColor = true;
            this.btnGirl.Click += new System.EventHandler(this.btnGirl_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 70);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(311, 227);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 309);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnGirl);
            this.Controls.Add(this.btnFriend);
            this.Controls.Add(this.btnLoser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoser;
        private System.Windows.Forms.Button btnFriend;
        private System.Windows.Forms.Button btnGirl;
        private System.Windows.Forms.TextBox txtResult;
    }
}

