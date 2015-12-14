namespace AlgorithmExperiment
{
    partial class Fibonacci
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
            this.tabGroup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupRecursion = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressRecursion = new System.Windows.Forms.ProgressBar();
            this.lblRecursionMaxIndex = new System.Windows.Forms.Label();
            this.lblRecursionTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRecursionMaxVal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRecursionStart = new System.Windows.Forms.Button();
            this.groupIterate = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressIteration = new System.Windows.Forms.ProgressBar();
            this.lblIterationMaxIndex = new System.Windows.Forms.Label();
            this.lblIterationTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIterationMaxVal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIterationStart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabGroup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupRecursion.SuspendLayout();
            this.groupIterate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.tabPage1);
            this.tabGroup.Controls.Add(this.tabPage2);
            this.tabGroup.Location = new System.Drawing.Point(13, 12);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.SelectedIndex = 0;
            this.tabGroup.Size = new System.Drawing.Size(513, 348);
            this.tabGroup.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupRecursion);
            this.tabPage1.Controls.Add(this.groupIterate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查找最大的Fib(n)";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            this.tabPage1.Leave += new System.EventHandler(this.tabPage1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "整型数(int)的最大值为2147483647";
            // 
            // groupRecursion
            // 
            this.groupRecursion.Controls.Add(this.label6);
            this.groupRecursion.Controls.Add(this.progressRecursion);
            this.groupRecursion.Controls.Add(this.lblRecursionMaxIndex);
            this.groupRecursion.Controls.Add(this.lblRecursionTime);
            this.groupRecursion.Controls.Add(this.label9);
            this.groupRecursion.Controls.Add(this.label10);
            this.groupRecursion.Controls.Add(this.lblRecursionMaxVal);
            this.groupRecursion.Controls.Add(this.label12);
            this.groupRecursion.Controls.Add(this.btnRecursionStart);
            this.groupRecursion.Location = new System.Drawing.Point(6, 145);
            this.groupRecursion.Name = "groupRecursion";
            this.groupRecursion.Size = new System.Drawing.Size(493, 104);
            this.groupRecursion.TabIndex = 0;
            this.groupRecursion.TabStop = false;
            this.groupRecursion.Text = "递归法查找";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "查找进度";
            // 
            // progressRecursion
            // 
            this.progressRecursion.Location = new System.Drawing.Point(64, 59);
            this.progressRecursion.Name = "progressRecursion";
            this.progressRecursion.Size = new System.Drawing.Size(423, 23);
            this.progressRecursion.TabIndex = 2;
            // 
            // lblRecursionMaxIndex
            // 
            this.lblRecursionMaxIndex.AutoSize = true;
            this.lblRecursionMaxIndex.Location = new System.Drawing.Point(293, 28);
            this.lblRecursionMaxIndex.Name = "lblRecursionMaxIndex";
            this.lblRecursionMaxIndex.Size = new System.Drawing.Size(41, 12);
            this.lblRecursionMaxIndex.TabIndex = 1;
            this.lblRecursionMaxIndex.Text = "label2";
            // 
            // lblRecursionTime
            // 
            this.lblRecursionTime.AutoSize = true;
            this.lblRecursionTime.Location = new System.Drawing.Point(388, 28);
            this.lblRecursionTime.Name = "lblRecursionTime";
            this.lblRecursionTime.Size = new System.Drawing.Size(41, 12);
            this.lblRecursionTime.TabIndex = 1;
            this.lblRecursionTime.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "n的值";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "耗时";
            // 
            // lblRecursionMaxVal
            // 
            this.lblRecursionMaxVal.AutoSize = true;
            this.lblRecursionMaxVal.Location = new System.Drawing.Point(180, 28);
            this.lblRecursionMaxVal.Name = "lblRecursionMaxVal";
            this.lblRecursionMaxVal.Size = new System.Drawing.Size(41, 12);
            this.lblRecursionMaxVal.TabIndex = 1;
            this.lblRecursionMaxVal.Text = "label2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "最大的Fib(n)";
            // 
            // btnRecursionStart
            // 
            this.btnRecursionStart.Location = new System.Drawing.Point(7, 23);
            this.btnRecursionStart.Name = "btnRecursionStart";
            this.btnRecursionStart.Size = new System.Drawing.Size(75, 23);
            this.btnRecursionStart.TabIndex = 0;
            this.btnRecursionStart.Text = "开始";
            this.btnRecursionStart.UseVisualStyleBackColor = true;
            this.btnRecursionStart.Click += new System.EventHandler(this.btnRecursionStart_Click);
            // 
            // groupIterate
            // 
            this.groupIterate.Controls.Add(this.label3);
            this.groupIterate.Controls.Add(this.progressIteration);
            this.groupIterate.Controls.Add(this.lblIterationMaxIndex);
            this.groupIterate.Controls.Add(this.lblIterationTime);
            this.groupIterate.Controls.Add(this.label5);
            this.groupIterate.Controls.Add(this.label4);
            this.groupIterate.Controls.Add(this.lblIterationMaxVal);
            this.groupIterate.Controls.Add(this.label2);
            this.groupIterate.Controls.Add(this.btnIterationStart);
            this.groupIterate.Location = new System.Drawing.Point(6, 35);
            this.groupIterate.Name = "groupIterate";
            this.groupIterate.Size = new System.Drawing.Size(493, 104);
            this.groupIterate.TabIndex = 0;
            this.groupIterate.TabStop = false;
            this.groupIterate.Text = "迭代法查找";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "查找进度";
            // 
            // progressIteration
            // 
            this.progressIteration.Location = new System.Drawing.Point(64, 59);
            this.progressIteration.Name = "progressIteration";
            this.progressIteration.Size = new System.Drawing.Size(423, 23);
            this.progressIteration.TabIndex = 2;
            // 
            // lblIterationMaxIndex
            // 
            this.lblIterationMaxIndex.AutoSize = true;
            this.lblIterationMaxIndex.Location = new System.Drawing.Point(293, 28);
            this.lblIterationMaxIndex.Name = "lblIterationMaxIndex";
            this.lblIterationMaxIndex.Size = new System.Drawing.Size(41, 12);
            this.lblIterationMaxIndex.TabIndex = 1;
            this.lblIterationMaxIndex.Text = "label2";
            // 
            // lblIterationTime
            // 
            this.lblIterationTime.AutoSize = true;
            this.lblIterationTime.Location = new System.Drawing.Point(388, 28);
            this.lblIterationTime.Name = "lblIterationTime";
            this.lblIterationTime.Size = new System.Drawing.Size(41, 12);
            this.lblIterationTime.TabIndex = 1;
            this.lblIterationTime.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "n的值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "耗时";
            // 
            // lblIterationMaxVal
            // 
            this.lblIterationMaxVal.AutoSize = true;
            this.lblIterationMaxVal.Location = new System.Drawing.Point(180, 28);
            this.lblIterationMaxVal.Name = "lblIterationMaxVal";
            this.lblIterationMaxVal.Size = new System.Drawing.Size(41, 12);
            this.lblIterationMaxVal.TabIndex = 1;
            this.lblIterationMaxVal.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "最大的Fib(n)";
            // 
            // btnIterationStart
            // 
            this.btnIterationStart.Location = new System.Drawing.Point(7, 23);
            this.btnIterationStart.Name = "btnIterationStart";
            this.btnIterationStart.Size = new System.Drawing.Size(75, 23);
            this.btnIterationStart.TabIndex = 0;
            this.btnIterationStart.Text = "开始";
            this.btnIterationStart.UseVisualStyleBackColor = true;
            this.btnIterationStart.Click += new System.EventHandler(this.btnIterationStart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 373);
            this.Controls.Add(this.tabGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fibonacci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fibonacci_FormClosing);
            this.tabGroup.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupRecursion.ResumeLayout(false);
            this.groupRecursion.PerformLayout();
            this.groupIterate.ResumeLayout(false);
            this.groupIterate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGroup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupIterate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressIteration;
        private System.Windows.Forms.Label lblIterationTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIterationMaxVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIterationStart;
        private System.Windows.Forms.Label lblIterationMaxIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupRecursion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressRecursion;
        private System.Windows.Forms.Label lblRecursionMaxIndex;
        private System.Windows.Forms.Label lblRecursionTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRecursionMaxVal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRecursionStart;
    }
}