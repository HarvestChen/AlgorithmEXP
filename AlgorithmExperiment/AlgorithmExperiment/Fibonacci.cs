using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmExperiment
{
    public partial class Fibonacci : Form
    {
        public Form mainF;
        public Fibonacci(Form f)
        {
            InitializeComponent();
            mainF = f;
        }

        private void Fibonacci_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                MessageBox.Show("Form closing cancelled.");
            }
            else
            {
                e.Cancel = false;
                mainF.Show();
            }
        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {
            
        }

        public ExecuteResult findFibMaxByIteration()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            List<FibonacciResult> fibRst = new List<FibonacciResult>();
            int fibMax = 0, maxIndex = 0;
            while (true)
            {
                fibMax = Fibonacci_Iterate(maxIndex);
                if (fibMax >= 0)
                {
                    fibRst.Add(new FibonacciResult(fibMax, maxIndex));
                    maxIndex++;
                }
                else
                {
                    fibMax = fibRst[maxIndex - 1].FibResult;
                    maxIndex = fibRst[maxIndex - 1].FibIndex;
                    break;
                }
                //progressIteration.Value = maxIndex;
                this.IterationSetRange(maxIndex);
            }
            watch.Stop();
            return new ExecuteResult(watch.ElapsedMilliseconds, new FibonacciResult(fibMax, maxIndex));
        }

        delegate void IterationSetRangeCallback(int Range);

        public void IterationSetRange(int Range)
        {
            if (this.progressIteration.InvokeRequired)
            {
                IterationSetRangeCallback d = new IterationSetRangeCallback(IterationSetRange);
                this.Invoke(d, new object[] { Range });
            }
            else
            {
                progressIteration.Value = Range;
            }
        }

        public ExecuteResult findFibMaxByRecursion()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            List<FibonacciResult> fibRst = new List<FibonacciResult>();
            int fibMax = 0, maxIndex = 0;
            while (true)
            {
                fibMax = Fibonacci_Recursion(maxIndex);
                
                if (fibMax >= 0)
                {
                    fibRst.Add(new FibonacciResult(fibMax, maxIndex));
                    maxIndex++;
                }
                else
                {
                    fibMax = fibRst[maxIndex - 1].FibResult;
                    maxIndex = fibRst[maxIndex - 1].FibIndex;
                    break;
                }
            }
            watch.Stop();
            return new ExecuteResult(watch.ElapsedMilliseconds, new FibonacciResult(fibMax, maxIndex));
        }

        #region FibonacciAlgorithms
        /// <summary>
        /// 使用迭代法输出Fibonacci数列第n项的值
        /// </summary>
        /// <param name="ValueIn">输入的n</param>
        /// <returns>第n项Fibonacci数列的值</returns>
        public int Fibonacci_Iterate(int ValueIn)
        {
            if (ValueIn == 0) return 0;
            else if (ValueIn < 3) return 1;
            else
            {
                int First = 1;
                int Second = 1;
                int Temp = 0;
                for (int index = 0; index < ValueIn - 2; index++)
                {
                    Temp = First + Second;
                    First = Second;
                    Second = Temp;
                }
                return Temp;
            }
        }

        /// <summary>
        /// 使用递归法输出Fibonacci数列第n项的值
        /// </summary>
        /// <param name="ValueIn">输入的n</param>
        /// <returns>第n项Fibonacci数列的值</returns>
        public int Fibonacci_Recursion(int ValueIn)
        {
            if (ValueIn == 0) return 0;
            else if (ValueIn < 3) return 1;
            else
            {
                return Fibonacci_Recursion(ValueIn - 1) + Fibonacci_Recursion(ValueIn - 2);
            }
        }
        #endregion

        private void btnIterationStart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread a = new System.Threading.Thread(new System.Threading.ThreadStart(IterationFind));
            a.Start();
        }

        public void IterationFind()
        {
            ExecuteResult er = findFibMaxByIteration();
            lblIterationMaxVal.Text = er.Result.FibResult.ToString();
            lblIterationTime.Text = er.TimeEllapsed.ToString() + "毫秒";
            lblIterationMaxIndex.Text = er.Result.FibIndex.ToString();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            progressIteration.Value = 0;
            progressIteration.Minimum = 0;
            progressIteration.Maximum = 47;
            progressRecursion.Value = 0;
            progressRecursion.Minimum = 0;
            progressRecursion.Maximum = 47;
            lblIterationMaxIndex.Text = "";
            lblIterationMaxVal.Text = "";
            lblIterationTime.Text = "";
            lblRecursionMaxIndex.Text = "";
            lblRecursionMaxVal.Text = "";
            lblRecursionTime.Text = "";
        }

        private void btnRecursionStart_Click(object sender, EventArgs e)
        {
            ExecuteResult er = findFibMaxByRecursion();
            lblRecursionMaxVal.Text = er.Result.FibResult.ToString();
            lblRecursionTime.Text = er.TimeEllapsed.ToString() + "毫秒";
            lblRecursionMaxIndex.Text = er.Result.FibIndex.ToString();
        }
    }
    public class FibonacciResult
    {
        public FibonacciResult(int fibRst, int fibIndex)
        {
            FibResult = fibRst;
            FibIndex = fibIndex;
        }
        public int FibResult { get; set; }
        public int FibIndex { get; set; }
    }

    public class ExecuteResult
    {
        public ExecuteResult(long time, FibonacciResult res)
        {
            TimeEllapsed = time;
            Result = res;
        }
        public long TimeEllapsed { get; set; }
        public FibonacciResult Result { get; set; }
    }
}
