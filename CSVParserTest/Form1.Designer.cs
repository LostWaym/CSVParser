namespace CSVParserTest
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
            this.m_input = new System.Windows.Forms.TextBox();
            this.m_output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_parse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_input
            // 
            this.m_input.Location = new System.Drawing.Point(12, 12);
            this.m_input.Multiline = true;
            this.m_input.Name = "m_input";
            this.m_input.Size = new System.Drawing.Size(239, 426);
            this.m_input.TabIndex = 0;
            // 
            // m_output
            // 
            this.m_output.Location = new System.Drawing.Point(340, 12);
            this.m_output.Multiline = true;
            this.m_output.Name = "m_output";
            this.m_output.ReadOnly = true;
            this.m_output.Size = new System.Drawing.Size(448, 426);
            this.m_output.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出";
            // 
            // m_parse
            // 
            this.m_parse.Location = new System.Drawing.Point(259, 415);
            this.m_parse.Name = "m_parse";
            this.m_parse.Size = new System.Drawing.Size(75, 23);
            this.m_parse.TabIndex = 4;
            this.m_parse.Text = "解析";
            this.m_parse.UseVisualStyleBackColor = true;
            this.m_parse.Click += new System.EventHandler(this.m_parse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_parse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_output);
            this.Controls.Add(this.m_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_input;
        private System.Windows.Forms.TextBox m_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_parse;
    }
}

