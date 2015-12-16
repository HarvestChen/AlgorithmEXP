namespace AlgorithmExperiment
{
    partial class EightCoins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listRst = new System.Windows.Forms.ListBox();
            this.btnCreateSequence = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listRst
            // 
            this.listRst.Font = new System.Drawing.Font("宋体", 11F);
            this.listRst.FormattingEnabled = true;
            this.listRst.ItemHeight = 15;
            this.listRst.Location = new System.Drawing.Point(123, 12);
            this.listRst.Name = "listRst";
            this.listRst.Size = new System.Drawing.Size(373, 259);
            this.listRst.TabIndex = 0;
            // 
            // btnCreateSequence
            // 
            this.btnCreateSequence.Font = new System.Drawing.Font("宋体", 11F);
            this.btnCreateSequence.Location = new System.Drawing.Point(12, 12);
            this.btnCreateSequence.Name = "btnCreateSequence";
            this.btnCreateSequence.Size = new System.Drawing.Size(93, 52);
            this.btnCreateSequence.TabIndex = 1;
            this.btnCreateSequence.Text = "创建硬币序列";
            this.btnCreateSequence.UseVisualStyleBackColor = true;
            this.btnCreateSequence.Click += new System.EventHandler(this.btnCreateSequence_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 11F);
            this.btnStart.Location = new System.Drawing.Point(12, 70);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 52);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始执行";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("宋体", 11F);
            this.btnClr.Location = new System.Drawing.Point(12, 128);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(93, 52);
            this.btnClr.TabIndex = 1;
            this.btnClr.Text = "清屏";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // EightCoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 284);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCreateSequence);
            this.Controls.Add(this.listRst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EightCoins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "减治法在组合问题中的应用——8枚硬币问题";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EightCoins_FormClosing);
            this.Load += new System.EventHandler(this.EightCoins_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRst;
        private System.Windows.Forms.Button btnCreateSequence;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClr;
    }
}