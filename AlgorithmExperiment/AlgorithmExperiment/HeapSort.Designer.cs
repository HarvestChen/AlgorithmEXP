namespace AlgorithmExperiment
{
    partial class HeapSort
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
            this.unsortedArea = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sortedArea = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeEllapsedLabel = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // unsortedArea
            // 
            this.unsortedArea.Location = new System.Drawing.Point(112, 13);
            this.unsortedArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unsortedArea.Name = "unsortedArea";
            this.unsortedArea.Size = new System.Drawing.Size(681, 129);
            this.unsortedArea.TabIndex = 0;
            this.unsortedArea.TabStop = false;
            this.unsortedArea.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "待排序区域";
            // 
            // sortedArea
            // 
            this.sortedArea.Location = new System.Drawing.Point(112, 150);
            this.sortedArea.Margin = new System.Windows.Forms.Padding(4);
            this.sortedArea.Name = "sortedArea";
            this.sortedArea.Size = new System.Drawing.Size(681, 129);
            this.sortedArea.TabIndex = 0;
            this.sortedArea.TabStop = false;
            this.sortedArea.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "有序区域";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "排序耗时";
            // 
            // timeEllapsedLabel
            // 
            this.timeEllapsedLabel.AutoSize = true;
            this.timeEllapsedLabel.Location = new System.Drawing.Point(91, 302);
            this.timeEllapsedLabel.Name = "timeEllapsedLabel";
            this.timeEllapsedLabel.Size = new System.Drawing.Size(72, 16);
            this.timeEllapsedLabel.TabIndex = 1;
            this.timeEllapsedLabel.Text = "排序耗时";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(589, 293);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(99, 34);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "生成数据";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(694, 293);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(99, 34);
            this.btnCls.TabIndex = 2;
            this.btnCls.TabStop = false;
            this.btnCls.Text = "清屏";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(484, 293);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(99, 34);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "开始排序";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "随机生成";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "个数(3~5000)";
            // 
            // dataNumber
            // 
            this.dataNumber.Location = new System.Drawing.Point(297, 297);
            this.dataNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.dataNumber.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.dataNumber.Name = "dataNumber";
            this.dataNumber.Size = new System.Drawing.Size(72, 26);
            this.dataNumber.TabIndex = 3;
            this.dataNumber.TabStop = false;
            this.dataNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // HeapSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 335);
            this.Controls.Add(this.dataNumber);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.timeEllapsedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortedArea);
            this.Controls.Add(this.unsortedArea);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HeapSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "变治法在排序问题中的应用——堆排序问题";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HeapSort_FormClosing);
            this.Load += new System.EventHandler(this.HeapSort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox unsortedArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox sortedArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeEllapsedLabel;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown dataNumber;
    }
}