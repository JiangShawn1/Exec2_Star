namespace Exec2_Star
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.textBoxsRows = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.midButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(313, 94);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "靠左三角";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "列數";
            // 
            // startLabel
            // 
            this.startLabel.Location = new System.Drawing.Point(192, 317);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(253, 95);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "startLabel";
            // 
            // textBoxsRows
            // 
            this.textBoxsRows.Location = new System.Drawing.Point(194, 94);
            this.textBoxsRows.Name = "textBoxsRows";
            this.textBoxsRows.Size = new System.Drawing.Size(100, 22);
            this.textBoxsRows.TabIndex = 2;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(194, 147);
            this.textBoxStart.Multiline = true;
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxStart.Size = new System.Drawing.Size(251, 115);
            this.textBoxStart.TabIndex = 2;
            // 
            // midButton
            // 
            this.midButton.Location = new System.Drawing.Point(406, 94);
            this.midButton.Name = "midButton";
            this.midButton.Size = new System.Drawing.Size(75, 23);
            this.midButton.TabIndex = 3;
            this.midButton.Text = "等腰三角";
            this.midButton.UseVisualStyleBackColor = true;
            this.midButton.Click += new System.EventHandler(this.midButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(498, 94);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 3;
            this.rightButton.Text = "靠右三角";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.midButton);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.textBoxsRows);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.TextBox textBoxsRows;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Button midButton;
        private System.Windows.Forms.Button rightButton;
    }
}

