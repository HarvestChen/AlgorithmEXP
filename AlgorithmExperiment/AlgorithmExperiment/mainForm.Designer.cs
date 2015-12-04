namespace AlgorithmExperiment
{
    partial class mainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ExpItems = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择需要进入的实验，点击";
            // 
            // ExpItems
            // 
            this.ExpItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpItems.Font = new System.Drawing.Font("宋体", 13F);
            this.ExpItems.FormattingEnabled = true;
            this.ExpItems.Location = new System.Drawing.Point(21, 50);
            this.ExpItems.Name = "ExpItems";
            this.ExpItems.Size = new System.Drawing.Size(364, 25);
            this.ExpItems.TabIndex = 1;
            this.ExpItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExpItems_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 13F);
            this.btnOK.Location = new System.Drawing.Point(248, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 32);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 97);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ExpItems);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "算法设计与分析实验";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ExpItems;
        private System.Windows.Forms.Button btnOK;
    }
}

