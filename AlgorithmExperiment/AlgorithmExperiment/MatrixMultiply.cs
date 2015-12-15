using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmExperiment
{
    public partial class MatrixMultiply : Form
    {
        Form mainF;
        public MatrixMultiply(Form f)
        {
            InitializeComponent();
            mainF = f;
        }

        private void MatrixMultiply_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                mainF.Show();
            }
        }

        private void MatrixMultiply_Load(object sender, EventArgs e)
        {
            int[,] matrixA = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrixA[i, j].ToString() + "  ");
                    richTextBox1.Text += matrixA[i, j].ToString() + "  ";
                }
                Console.Write("\n");
                richTextBox1.Text += "\n";
            }
        }
    }
}
