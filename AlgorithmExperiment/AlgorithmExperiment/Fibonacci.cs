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

        #region Calling winform controls using thread-safe method
        //delegates in tabGroup1
        delegate void IterationSetRangeCallback(int Range);
        delegate void IterationSetMaxValLblCallback(string Text);
        delegate void IterationSetTimeLblCallback(string Text);
        delegate void IterationSetMaxIndexLblCallback(string Text);
        delegate void RecursionSetRangeCallback(int Range);
        delegate void RecursionSetMaxValLblCallback(string Text);
        delegate void RecursionSetTimeLblCallback(string Text);
        delegate void RecursionSetMaxIndexLblCallback(string Text);
        delegate int GetAlgorithmSelectCallback();

        //delegates in tabGroup2
        delegate void IterationSetRangeDelegate(int Range);
        delegate void IterationSetBasicOperationNumDelegate(string Text);
        delegate void IterationSetFibResultDelegate(string Text);
        delegate void RecursionSetRangeDelegate(int Range);
        delegate void RecursionSetBasicOperationNumDelegate(string Text);
        delegate void RecursionSetFibResultDelegate(string Text);

        //methods in tabGroup2
        public void RecursionSetFibResult(string Text)
        {
            if (this.lblFibNValRecursion.InvokeRequired)
            {
                RecursionSetFibResultDelegate d = new RecursionSetFibResultDelegate(RecursionSetFibResult);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                this.lblFibNValRecursion.Text = Text;
            }
        }

        public void RecursionSetBasicOperationNum(string Text)
        {
            if (this.lblBasicOperateNumRecursion.InvokeRequired)
            {
                RecursionSetBasicOperationNumDelegate d = new RecursionSetBasicOperationNumDelegate(RecursionSetBasicOperationNum);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                this.lblBasicOperateNumRecursion.Text = Text;
            }
        }

        public void RecursionSetRangeInTab2(int Range)
        {
            if (this.progressRecursionInTab2.InvokeRequired)
            {
                RecursionSetRangeDelegate d = new RecursionSetRangeDelegate(RecursionSetRangeInTab2);
                this.Invoke(d, new object[] { Range });
            }
            else
            {
                this.progressRecursionInTab2.Value = Range;
            }
        }

        public void IterationSetFibResult(string Text)
        {
            if (this.lblFibNVal.InvokeRequired)
            {
                IterationSetFibResultDelegate d = new IterationSetFibResultDelegate(IterationSetFibResult);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                this.lblFibNVal.Text = Text;
            }
        }

        public void IterationSetRangeInTab2(int Range)
        {
            if (this.progressIterationInTab2.InvokeRequired)
            {
                IterationSetRangeDelegate d = new IterationSetRangeDelegate(IterationSetRangeInTab2);
                this.Invoke(d, new object[] { Range });
            }
            else
            {
                this.progressIterationInTab2.Value = Range;
            }
        }

        public void IterationSetBasicOperationNum(string Text)
        {
            if (this.lblBasicOperateNum.InvokeRequired)
            {
                IterationSetBasicOperationNumDelegate d = new IterationSetBasicOperationNumDelegate(IterationSetBasicOperationNum);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                this.lblBasicOperateNum.Text = Text;
            }
        }

        //methods in tabGroup1
        public int GetAlgorithmSelect()
        {
            int index = 0;
            if (this.AlgorithmSelect.InvokeRequired)
            {
                GetAlgorithmSelectCallback d = new GetAlgorithmSelectCallback(GetAlgorithmSelect);
                this.Invoke(d);
            }
            else
            {
                index = this.AlgorithmSelect.SelectedIndex;
            }
            return index;
        }

        public void RecursionSetMaxIndexLbl(string Text)
        {
            if (this.lblRecursionMaxIndex.InvokeRequired)
            {
                RecursionSetMaxValLblCallback d = new RecursionSetMaxValLblCallback(RecursionSetMaxIndexLbl);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                lblRecursionMaxIndex.Text = Text;
            }
        }

        public void RecursionSetTimeLbl(string Text)
        {
            if (this.lblRecursionTime.InvokeRequired)
            {
                RecursionSetTimeLblCallback d = new RecursionSetTimeLblCallback(RecursionSetTimeLbl);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                lblRecursionTime.Text = Text;
            }
        }

        public void RecursionSetMaxValLbl(string Text)
        {
            if (this.lblRecursionMaxVal.InvokeRequired)
            {
                RecursionSetMaxValLblCallback d = new RecursionSetMaxValLblCallback(RecursionSetMaxValLbl);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                lblRecursionMaxVal.Text = Text;
            }
        }

        public void RecursionSetRange(int Range)
        {
            if (this.progressRecursion.InvokeRequired)
            {
                RecursionSetRangeCallback d = new RecursionSetRangeCallback(RecursionSetRange);
                this.Invoke(d, new object[] { Range });
            }
            else
            {
                progressRecursion.Value = Range;
            }
        }

        public void IterationSetMaxIndexLbl(string Text)
        {
            if (this.lblIterationMaxIndex.InvokeRequired)
            {
                IterationSetMaxValLblCallback d = new IterationSetMaxValLblCallback(IterationSetMaxIndexLbl);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                lblIterationMaxIndex.Text = Text;
            }
        }

        public void IterationSetTimeLbl(string Text)
        {
            if (this.lblIterationTime.InvokeRequired)
            {
                IterationSetTimeLblCallback d = new IterationSetTimeLblCallback(IterationSetTimeLbl);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                lblIterationTime.Text = Text;
            }
        }

        public void IterationSetMaxValLbl(string Text)
        {
            if (this.lblIterationMaxVal.InvokeRequired)
            {
                IterationSetMaxValLblCallback d = new IterationSetMaxValLblCallback(IterationSetMaxValLbl);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                lblIterationMaxVal.Text = Text;
            }
        }

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
        #endregion

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

        /// <summary>
        /// 使用改进后的算法输出Fibonacci数列的第n项的值
        /// </summary>
        /// <param name="ValueIn">输入的n</param>
        /// <returns>第n项Fibonacci数列的值</returns>
        public int Fibonacci_New(int ValueIn)
        {
            double sqrt5 = Math.Sqrt(5);
            return Convert.ToInt32((1 / sqrt5) * (Math.Pow((1 + sqrt5) / 2, ValueIn) - Math.Pow((1 - sqrt5) / 2, ValueIn)));
        }

        #endregion

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
                if (t != null)
                {
                    t.Abort();
                }
                e.Cancel = false;
                mainF.Show();
            }
        }

        #region Question1: Find the max index of Fib(n)
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
                this.IterationSetRange(maxIndex);
            }
            watch.Stop();
            return new ExecuteResult(watch.ElapsedMilliseconds, new FibonacciResult(fibMax, maxIndex));
        }

        public ExecuteResult finFibMaxByNewIteration()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            List<FibonacciResult> fibRst = new List<FibonacciResult>();
            int fibMax = 0, maxIndex = 0;
            while (true)
            {
                fibMax = Fibonacci_New(maxIndex);
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
                this.IterationSetRange(maxIndex);
            }
            watch.Stop();
            return new ExecuteResult(watch.ElapsedMilliseconds, new FibonacciResult(fibMax, maxIndex));
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
                this.RecursionSetRange(maxIndex);
            }
            watch.Stop();
            return new ExecuteResult(watch.ElapsedMilliseconds, new FibonacciResult(fibMax, maxIndex));
        }

        private void btnIterationStart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread a = new System.Threading.Thread(new System.Threading.ThreadStart(IterationFind));
            a.Start();
        }

        public void IterationFind()
        {
            ExecuteResult er;
            if (this.GetAlgorithmSelect() == 0)
            {
                er = findFibMaxByIteration();
            }
            else
            {
                er = finFibMaxByNewIteration();
            }
            this.IterationSetMaxIndexLbl(er.Result.FibIndex.ToString());
            this.IterationSetMaxValLbl(er.Result.FibResult.ToString());
            this.IterationSetTimeLbl(er.TimeEllapsed.ToString() + "毫秒");
        }

        public void RecursionFind()
        {
            ExecuteResult er = findFibMaxByRecursion();
            this.RecursionSetMaxIndexLbl(er.Result.FibIndex.ToString());
            this.RecursionSetMaxValLbl(er.Result.FibResult.ToString());
            this.RecursionSetTimeLbl(er.TimeEllapsed.ToString() + "毫秒");
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            AlgorithmSelect.SelectedIndex = 0;
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
            DialogResult dr = MessageBox.Show("切换选项卡或退出实验将会强行打断算法执行过程，确认开始执行？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                System.Threading.Thread b = new System.Threading.Thread(new System.Threading.ThreadStart(RecursionFind));
                b.Start();
                t = b;
            }
        }

        public System.Threading.Thread t;

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            if (t != null)
            {
                t.Abort();
            }
        }
        #endregion

        private void btnIterateStart_Click(object sender, EventArgs e)
        {

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
