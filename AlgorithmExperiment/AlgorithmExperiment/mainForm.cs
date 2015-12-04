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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            ExpItems.Focus();
            ExpItems.Items.Add("算法分析基础-Fibonacci序列问题");
            ExpItems.Items.Add("分治法在数值问题中的应用-矩阵相乘问题");
            ExpItems.Items.Add("减治法在组合问题中的应用-8枚硬币问题");
            ExpItems.Items.Add("变治法在排序问题中的应用-堆排序问题");
            ExpItems.Items.Add("动态规划法在图问题中的应用-全源最短路径问题");
            ExpItems.SelectedIndex = 0;
        }

        private void ExpItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (ExpItems.SelectedIndex)
            {
                case 0:
                    Fibonacci fib = new Fibonacci(this);
                    fib.Show();
                    this.Hide();
                    break;
                case 1:
                    MatrixMultiply mat = new MatrixMultiply(this);
                    mat.Show();
                    this.Hide();
                    break;
                case 2:
                    EightCoins eig = new EightCoins(this);
                    eig.Show();
                    this.Hide();
                    break;
                case 3:
                    HeapSort hea = new HeapSort(this);
                    hea.Show();
                    this.Hide();
                    break;
                case 4:
                    ShortestPath shor = new ShortestPath(this);
                    shor.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
