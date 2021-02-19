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
            this.textF1 = new System.Windows.Forms.TextBox();
            this.textF2 = new System.Windows.Forms.TextBox();
            this.textF3 = new System.Windows.Forms.TextBox();
            this.textF4 = new System.Windows.Forms.TextBox();
            this.textF5 = new System.Windows.Forms.TextBox();
            this.textF6 = new System.Windows.Forms.TextBox();
            this.textF7 = new System.Windows.Forms.TextBox();
            this.textSeq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textUrl
            // 
            this.textUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUrl.Location = new System.Drawing.Point(145, 16);
            this.textUrl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(525, 31);
            this.textUrl.TabIndex = 0;
            // 
            // textInput
            // 
            this.textInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInput.Location = new System.Drawing.Point(18, 59);
            this.textInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(652, 31);
            this.textInput.TabIndex = 1;
            this.textInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textInput_KeyDown);
            this.textInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textInput_KeyPress);
            // 
            // textLog
            // 
            this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLog.Location = new System.Drawing.Point(18, 235);
            this.textLog.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(652, 111);
            this.textLog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zoom API Key";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.textF1);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.textF2);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.textF3);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.textF4);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.textF5);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.textF6);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.textF7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(652, 94);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // textF1
            // 
            this.textF1.Location = new System.Drawing.Point(38, 3);
            this.textF1.Name = "textF1";
            this.textF1.Size = new System.Drawing.Size(120, 31);
            this.textF1.TabIndex = 0;
            // 
            // textF2
            // 
            this.textF2.Location = new System.Drawing.Point(199, 3);
            this.textF2.Name = "textF2";
            this.textF2.Size = new System.Drawing.Size(120, 31);
            this.textF2.TabIndex = 1;
            // 
            // textF3
            // 
            this.textF3.Location = new System.Drawing.Point(360, 3);
            this.textF3.Name = "textF3";
            this.textF3.Size = new System.Drawing.Size(120, 31);
            this.textF3.TabIndex = 2;
            // 
            // textF4
            // 
            this.textF4.Location = new System.Drawing.Point(521, 3);
            this.textF4.Name = "textF4";
            this.textF4.Size = new System.Drawing.Size(120, 31);
            this.textF4.TabIndex = 3;
            // 
            // textF5
            // 
            this.textF5.Location = new System.Drawing.Point(38, 40);
            this.textF5.Name = "textF5";
            this.textF5.Size = new System.Drawing.Size(120, 31);
            this.textF5.TabIndex = 4;
            // 
            // textF6
            // 
            this.textF6.Location = new System.Drawing.Point(199, 40);
            this.textF6.Name = "textF6";
            this.textF6.Size = new System.Drawing.Size(120, 31);
            this.textF6.TabIndex = 5;
            // 
            // textF7
            // 
            this.textF7.Location = new System.Drawing.Point(360, 40);
            this.textF7.Name = "textF7";
            this.textF7.Size = new System.Drawing.Size(120, 31);
            this.textF7.TabIndex = 6;
            // 
            // textSeq
            // 
            this.textSeq.Location = new System.Drawing.Point(73, 200);
            this.textSeq.Name = "textSeq";
            this.textSeq.Size = new System.Drawing.Size(100, 31);
            this.textSeq.TabIndex = 5;
            this.textSeq.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seq:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "F1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "F2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "F3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "F4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "F5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "F6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "F7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSeq);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.textUrl);
            this.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Zoom Captioner";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TextBox textSeq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

