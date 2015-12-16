namespace AlgorithmExperiment
{
    partial class MatrixMultiply
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
            this.matrixATextBox = new System.Windows.Forms.RichTextBox();
            this.matrixBTextBox = new System.Windows.Forms.RichTextBox();
            this.matrixResultTextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BFTime = new System.Windows.Forms.Label();
            this.DACTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matrixATextBox
            // 
            this.matrixATextBox.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixATextBox.Location = new System.Drawing.Point(12, 49);
            this.matrixATextBox.Name = "matrixATextBox";
            this.matrixATextBox.ReadOnly = true;
            this.matrixATextBox.Size = new System.Drawing.Size(231, 199);
            this.matrixATextBox.TabIndex = 0;
            this.matrixATextBox.TabStop = false;
            this.matrixATextBox.Text = "";
            // 
            // matrixBTextBox
            // 
            this.matrixBTextBox.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixBTextBox.Location = new System.Drawing.Point(297, 49);
            this.matrixBTextBox.Name = "matrixBTextBox";
            this.matrixBTextBox.ReadOnly = true;
            this.matrixBTextBox.Size = new System.Drawing.Size(231, 199);
            this.matrixBTextBox.TabIndex = 0;
            this.matrixBTextBox.TabStop = false;
            this.matrixBTextBox.Text = "";
            // 
            // matrixResultTextbox
            // 
            this.matrixResultTextbox.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixResultTextbox.Location = new System.Drawing.Point(579, 49);
            this.matrixResultTextbox.Name = "matrixResultTextbox";
            this.matrixResultTextbox.ReadOnly = true;
            this.matrixResultTextbox.Size = new System.Drawing.Size(231, 199);
            this.matrixResultTextbox.TabIndex = 0;
            this.matrixResultTextbox.TabStop = false;
            this.matrixResultTextbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "矩阵A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(381, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "矩阵B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(618, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "矩阵乘法运算结果";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(255, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "×";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F);
            this.label5.Location = new System.Drawing.Point(538, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "＝";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("宋体", 14F);
            this.btnRandom.Location = new System.Drawing.Point(12, 265);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(231, 37);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "生成矩阵数据";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("宋体", 14F);
            this.btnCalculate.Location = new System.Drawing.Point(12, 313);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(231, 37);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DACTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BFTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox1.Location = new System.Drawing.Point(297, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "耗时比对";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.Location = new System.Drawing.Point(7, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "BF方法";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14F);
            this.label7.Location = new System.Drawing.Point(278, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "DAC方法";
            // 
            // BFTime
            // 
            this.BFTime.AutoSize = true;
            this.BFTime.Font = new System.Drawing.Font("宋体", 14F);
            this.BFTime.Location = new System.Drawing.Point(74, 43);
            this.BFTime.Name = "BFTime";
            this.BFTime.Size = new System.Drawing.Size(67, 19);
            this.BFTime.TabIndex = 1;
            this.BFTime.Text = "BF方法";
            // 
            // DACTime
            // 
            this.DACTime.AutoSize = true;
            this.DACTime.Font = new System.Drawing.Font("宋体", 14F);
            this.DACTime.Location = new System.Drawing.Point(357, 43);
            this.DACTime.Name = "DACTime";
            this.DACTime.Size = new System.Drawing.Size(77, 19);
            this.DACTime.TabIndex = 1;
            this.DACTime.Text = "DAC方法";
            // 
            // MatrixMultiply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrixResultTextbox);
            this.Controls.Add(this.matrixBTextBox);
            this.Controls.Add(this.matrixATextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatrixMultiply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分治法在数值问题中的应用——矩阵相乘问题";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatrixMultiply_FormClosing);
            this.Load += new System.EventHandler(this.MatrixMultiply_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox matrixATextBox;
        private System.Windows.Forms.RichTextBox matrixBTextBox;
        private System.Windows.Forms.RichTextBox matrixResultTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DACTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BFTime;
        private System.Windows.Forms.Label label6;
    }
}