namespace WindowsFormsApp1
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnplay = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(280, 364);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(139, 78);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = "猜猜看";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtinput
            // 
            this.txtinput.Font = new System.Drawing.Font("新細明體", 30F);
            this.txtinput.Location = new System.Drawing.Point(220, 246);
            this.txtinput.Name = "txtinput";
            this.txtinput.PasswordChar = '*';
            this.txtinput.Size = new System.Drawing.Size(250, 55);
            this.txtinput.TabIndex = 1;
            this.txtinput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 573);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btnplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.TextBox txtinput;
    }
}

