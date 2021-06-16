namespace ZoomCaption
{
    partial class Form1
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
            this.textUrl = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelF1 = new System.Windows.Forms.Label();
            this.textF1 = new System.Windows.Forms.TextBox();
            this.labelF2 = new System.Windows.Forms.Label();
            this.textF2 = new System.Windows.Forms.TextBox();
            this.labelF3 = new System.Windows.Forms.Label();
            this.textF3 = new System.Windows.Forms.TextBox();
            this.labelF4 = new System.Windows.Forms.Label();
            this.textF4 = new System.Windows.Forms.TextBox();
            this.labelF5 = new System.Windows.Forms.Label();
            this.textF5 = new System.Windows.Forms.TextBox();
            this.labelF6 = new System.Windows.Forms.Label();
            this.textF6 = new System.Windows.Forms.TextBox();
            this.labelF7 = new System.Windows.Forms.Label();
            this.textF7 = new System.Windows.Forms.TextBox();
            this.panelF1 = new System.Windows.Forms.Panel();
            this.panelF2 = new System.Windows.Forms.Panel();
            this.panelF3 = new System.Windows.Forms.Panel();
            this.panelF4 = new System.Windows.Forms.Panel();
            this.panelF5 = new System.Windows.Forms.Panel();
            this.panelF6 = new System.Windows.Forms.Panel();
            this.panelF7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelF1.SuspendLayout();
            this.panelF2.SuspendLayout();
            this.panelF3.SuspendLayout();
            this.panelF4.SuspendLayout();
            this.panelF5.SuspendLayout();
            this.panelF6.SuspendLayout();
            this.panelF7.SuspendLayout();
            this.SuspendLayout();
            // 
            // textUrl
            // 
            this.textUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUrl.Location = new System.Drawing.Point(183, 14);
            this.textUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(519, 33);
            this.textUrl.TabIndex = 0;
            // 
            // textInput
            // 
            this.textInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInput.Location = new System.Drawing.Point(13, 57);
            this.textInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(689, 33);
            this.textInput.TabIndex = 1;
            this.textInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textInput_KeyDown);
            this.textInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textInput_KeyPress);
            // 
            // textLog
            // 
            this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLog.Location = new System.Drawing.Point(13, 225);
            this.textLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(689, 75);
            this.textLog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zoom APIトークン";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panelF1);
            this.flowLayoutPanel1.Controls.Add(this.panelF2);
            this.flowLayoutPanel1.Controls.Add(this.panelF3);
            this.flowLayoutPanel1.Controls.Add(this.panelF4);
            this.flowLayoutPanel1.Controls.Add(this.panelF5);
            this.flowLayoutPanel1.Controls.Add(this.panelF6);
            this.flowLayoutPanel1.Controls.Add(this.panelF7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 97);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(693, 86);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // labelF1
            // 
            this.labelF1.AutoSize = true;
            this.labelF1.Location = new System.Drawing.Point(2, 5);
            this.labelF1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelF1.Name = "labelF1";
            this.labelF1.Size = new System.Drawing.Size(33, 25);
            this.labelF1.TabIndex = 7;
            this.labelF1.Text = "F1";
            // 
            // textF1
            // 
            this.textF1.Location = new System.Drawing.Point(39, 2);
            this.textF1.Margin = new System.Windows.Forms.Padding(2);
            this.textF1.Name = "textF1";
            this.textF1.Size = new System.Drawing.Size(101, 33);
            this.textF1.TabIndex = 0;
            // 
            // labelF2
            // 
            this.labelF2.AutoSize = true;
            this.labelF2.Location = new System.Drawing.Point(2, 5);
            this.labelF2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelF2.Name = "labelF2";
            this.labelF2.Size = new System.Drawing.Size(33, 25);
            this.labelF2.TabIndex = 8;
            this.labelF2.Text = "F2";
            // 
            // textF2
            // 
            this.textF2.Location = new System.Drawing.Point(39, 2);
            this.textF2.Margin = new System.Windows.Forms.Padding(2);
            this.textF2.Name = "textF2";
            this.textF2.Size = new System.Drawing.Size(101, 33);
            this.textF2.TabIndex = 1;
            // 
            // labelF3
            // 
            this.labelF3.AutoSize = true;
            this.labelF3.Location = new System.Drawing.Point(2, 5);
            this.labelF3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelF3.Name = "labelF3";
            this.labelF3.Size = new System.Drawing.Size(33, 25);
            this.labelF3.TabIndex = 9;
            this.labelF3.Text = "F3";
            // 
            // textF3
            // 
            this.textF3.Location = new System.Drawing.Point(39, 2);
            this.textF3.Margin = new System.Windows.Forms.Padding(2);
            this.textF3.Name = "textF3";
            this.textF3.Size = new System.Drawing.Size(101, 33);
            this.textF3.TabIndex = 2;
            // 
            // labelF4
            // 
            this.labelF4.AutoSize = true;
            this.labelF4.Location = new System.Drawing.Point(2, 5);
            this.labelF4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelF4.Name = "labelF4";
            this.labelF4.Size = new System.Drawing.Size(33, 25);
            this.labelF4.TabIndex = 10;
            this.labelF4.Text = "F4";
            // 
            // textF4
            // 
            this.textF4.Location = new System.Drawing.Point(39, 2);
            this.textF4.Margin = new System.Windows.Forms.Padding(2);
            this.textF4.Name = "textF4";
            this.textF4.Size = new System.Drawing.Size(101, 33);
            this.textF4.TabIndex = 3;
            // 
            // labelF5
            // 
            this.labelF5.AutoSize = true;
            this.labelF5.Location = new System.Drawing.Point(2, 5);
            this.labelF5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelF5.Name = "labelF5";
            this.labelF5.Size = new System.Drawing.Size(33, 25);
            this.labelF5.TabIndex = 11;
            this.labelF5.Text = "F5";
            // 
            // textF5
            // 
            this.textF5.Location = new System.Drawing.Point(39, 2);
            this.textF5.Margin = new System.Windows.Forms.Padding(2);
            this.textF5.Name = "textF5";
            this.textF5.Size = new System.Drawing.Size(101, 33);
            this.textF5.TabIndex = 4;
            // 
            // labelF6
            // 
            this.labelF6.AutoSize = true;
            this.labelF6.Location = new System.Drawing.Point(2, 5);
            this.labelF6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelF6.Name = "labelF6";
            this.labelF6.Size = new System.Drawing.Size(33, 25);
            this.labelF6.TabIndex = 12;
            this.labelF6.Text = "F6";
            // 
            // textF6
            // 
            this.textF6.Location = new System.Drawing.Point(39, 2);
            this.textF6.Margin = new System.Windows.Forms.Padding(2);
            this.textF6.Name = "textF6";
            this.textF6.Size = new System.Drawing.Size(101, 33);
            this.textF6.TabIndex = 5;
            // 
            // labelF7
            // 
            this.labelF7.AutoSize = true;
            this.labelF7.Location = new System.Drawing.Point(2, 5);
            this.labelF7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelF7.Name = "labelF7";
            this.labelF7.Size = new System.Drawing.Size(33, 25);
            this.labelF7.TabIndex = 13;
            this.labelF7.Text = "F7";
            // 
            // textF7
            // 
            this.textF7.Location = new System.Drawing.Point(39, 2);
            this.textF7.Margin = new System.Windows.Forms.Padding(2);
            this.textF7.Name = "textF7";
            this.textF7.Size = new System.Drawing.Size(101, 33);
            this.textF7.TabIndex = 6;
            // 
            // panelF1
            // 
            this.panelF1.AutoSize = true;
            this.panelF1.Controls.Add(this.labelF1);
            this.panelF1.Controls.Add(this.textF1);
            this.panelF1.Location = new System.Drawing.Point(3, 3);
            this.panelF1.Name = "panelF1";
            this.panelF1.Size = new System.Drawing.Size(142, 37);
            this.panelF1.TabIndex = 14;
            // 
            // panelF2
            // 
            this.panelF2.AutoSize = true;
            this.panelF2.Controls.Add(this.labelF2);
            this.panelF2.Controls.Add(this.textF2);
            this.panelF2.Location = new System.Drawing.Point(151, 3);
            this.panelF2.Name = "panelF2";
            this.panelF2.Size = new System.Drawing.Size(142, 37);
            this.panelF2.TabIndex = 15;
            // 
            // panelF3
            // 
            this.panelF3.AutoSize = true;
            this.panelF3.Controls.Add(this.labelF3);
            this.panelF3.Controls.Add(this.textF3);
            this.panelF3.Location = new System.Drawing.Point(299, 3);
            this.panelF3.Name = "panelF3";
            this.panelF3.Size = new System.Drawing.Size(142, 37);
            this.panelF3.TabIndex = 16;
            // 
            // panelF4
            // 
            this.panelF4.AutoSize = true;
            this.panelF4.Controls.Add(this.labelF4);
            this.panelF4.Controls.Add(this.textF4);
            this.panelF4.Location = new System.Drawing.Point(447, 3);
            this.panelF4.Name = "panelF4";
            this.panelF4.Size = new System.Drawing.Size(142, 37);
            this.panelF4.TabIndex = 17;
            // 
            // panelF5
            // 
            this.panelF5.AutoSize = true;
            this.panelF5.Controls.Add(this.labelF5);
            this.panelF5.Controls.Add(this.textF5);
            this.panelF5.Location = new System.Drawing.Point(3, 46);
            this.panelF5.Name = "panelF5";
            this.panelF5.Size = new System.Drawing.Size(142, 37);
            this.panelF5.TabIndex = 18;
            // 
            // panelF6
            // 
            this.panelF6.AutoSize = true;
            this.panelF6.Controls.Add(this.labelF6);
            this.panelF6.Controls.Add(this.textF6);
            this.panelF6.Location = new System.Drawing.Point(151, 46);
            this.panelF6.Name = "panelF6";
            this.panelF6.Size = new System.Drawing.Size(142, 37);
            this.panelF6.TabIndex = 19;
            // 
            // panelF7
            // 
            this.panelF7.AutoSize = true;
            this.panelF7.Controls.Add(this.labelF7);
            this.panelF7.Controls.Add(this.textF7);
            this.panelF7.Location = new System.Drawing.Point(299, 46);
            this.panelF7.Name = "panelF7";
            this.panelF7.Size = new System.Drawing.Size(142, 37);
            this.panelF7.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ログ";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(567, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "最前面に配置";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "シーケンス初期化（字幕が出ない時に押す）";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.textUrl);
            this.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Zoom Captioner";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelF1.ResumeLayout(false);
            this.panelF1.PerformLayout();
            this.panelF2.ResumeLayout(false);
            this.panelF2.PerformLayout();
            this.panelF3.ResumeLayout(false);
            this.panelF3.PerformLayout();
            this.panelF4.ResumeLayout(false);
            this.panelF4.PerformLayout();
            this.panelF5.ResumeLayout(false);
            this.panelF5.PerformLayout();
            this.panelF6.ResumeLayout(false);
            this.panelF6.PerformLayout();
            this.panelF7.ResumeLayout(false);
            this.panelF7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textF1;
        private System.Windows.Forms.TextBox textF2;
        private System.Windows.Forms.TextBox textF3;
        private System.Windows.Forms.TextBox textF4;
        private System.Windows.Forms.TextBox textF5;
        private System.Windows.Forms.TextBox textF6;
        private System.Windows.Forms.TextBox textF7;
        private System.Windows.Forms.Label labelF1;
        private System.Windows.Forms.Label labelF2;
        private System.Windows.Forms.Label labelF3;
        private System.Windows.Forms.Label labelF4;
        private System.Windows.Forms.Label labelF5;
        private System.Windows.Forms.Label labelF6;
        private System.Windows.Forms.Label labelF7;
        private System.Windows.Forms.Panel panelF1;
        private System.Windows.Forms.Panel panelF2;
        private System.Windows.Forms.Panel panelF3;
        private System.Windows.Forms.Panel panelF4;
        private System.Windows.Forms.Panel panelF5;
        private System.Windows.Forms.Panel panelF6;
        private System.Windows.Forms.Panel panelF7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}

