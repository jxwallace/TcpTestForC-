namespace TCPclientAndTcpLisenter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.startTCPServerButton = new System.Windows.Forms.Button();
            this.stopTCPServerButton = new System.Windows.Forms.Button();
            this.reciveTextTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Location = new System.Drawing.Point(37, 21);
            this.IPAddressTextBox.Multiline = true;
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(119, 27);
            this.IPAddressTextBox.TabIndex = 0;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(37, 78);
            this.portTextBox.Multiline = true;
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(119, 32);
            this.portTextBox.TabIndex = 1;
            // 
            // startTCPServerButton
            // 
            this.startTCPServerButton.Location = new System.Drawing.Point(37, 141);
            this.startTCPServerButton.Name = "startTCPServerButton";
            this.startTCPServerButton.Size = new System.Drawing.Size(119, 41);
            this.startTCPServerButton.TabIndex = 2;
            this.startTCPServerButton.Text = "启动TCP服务器";
            this.startTCPServerButton.UseVisualStyleBackColor = true;
            this.startTCPServerButton.Click += new System.EventHandler(this.startTCPServerButton_Click);
            // 
            // stopTCPServerButton
            // 
            this.stopTCPServerButton.Location = new System.Drawing.Point(37, 211);
            this.stopTCPServerButton.Name = "stopTCPServerButton";
            this.stopTCPServerButton.Size = new System.Drawing.Size(119, 41);
            this.stopTCPServerButton.TabIndex = 3;
            this.stopTCPServerButton.Text = "停止TCP服务器";
            this.stopTCPServerButton.UseVisualStyleBackColor = true;
            this.stopTCPServerButton.Click += new System.EventHandler(this.stopTCPServerButton_Click);
            // 
            // reciveTextTextBox
            // 
            this.reciveTextTextBox.Location = new System.Drawing.Point(206, 21);
            this.reciveTextTextBox.Multiline = true;
            this.reciveTextTextBox.Name = "reciveTextTextBox";
            this.reciveTextTextBox.Size = new System.Drawing.Size(146, 84);
            this.reciveTextTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reciveTextTextBox);
            this.Controls.Add(this.stopTCPServerButton);
            this.Controls.Add(this.startTCPServerButton);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.IPAddressTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button startTCPServerButton;
        private System.Windows.Forms.Button stopTCPServerButton;
        private System.Windows.Forms.TextBox reciveTextTextBox;
    }
}

