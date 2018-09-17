namespace CefSharpApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.debugGroupBox = new System.Windows.Forms.GroupBox();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.debugGotoIndexButton = new System.Windows.Forms.Button();
            this.debugGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // debugGroupBox
            // 
            this.debugGroupBox.Controls.Add(this.debugGotoIndexButton);
            this.debugGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.debugGroupBox.Location = new System.Drawing.Point(0, 0);
            this.debugGroupBox.Name = "debugGroupBox";
            this.debugGroupBox.Size = new System.Drawing.Size(200, 1114);
            this.debugGroupBox.TabIndex = 0;
            this.debugGroupBox.TabStop = false;
            this.debugGroupBox.Text = "DEBUG";
            // 
            // browserPanel
            // 
            this.browserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPanel.Location = new System.Drawing.Point(200, 0);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(1462, 1114);
            this.browserPanel.TabIndex = 1;
            // 
            // debugGotoIndexButton
            // 
            this.debugGotoIndexButton.Location = new System.Drawing.Point(12, 30);
            this.debugGotoIndexButton.Name = "debugGotoIndexButton";
            this.debugGotoIndexButton.Size = new System.Drawing.Size(182, 47);
            this.debugGotoIndexButton.TabIndex = 0;
            this.debugGotoIndexButton.Text = "indexへ遷移";
            this.debugGotoIndexButton.UseVisualStyleBackColor = true;
            this.debugGotoIndexButton.Click += new System.EventHandler(this.debugGotoIndexButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1114);
            this.Controls.Add(this.browserPanel);
            this.Controls.Add(this.debugGroupBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.debugGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox debugGroupBox;
        private System.Windows.Forms.Panel browserPanel;
        private System.Windows.Forms.Button debugGotoIndexButton;
    }
}

