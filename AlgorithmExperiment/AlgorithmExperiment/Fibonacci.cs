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
            ExecuteResult a, b;
            a = findFibMaxByIteration();
            //b = findFibMaxByRecursion();
            Console.WriteLine("Iteration: Time Elappsed: {0}ms, FibMax: {1}, MaxIndex: {2}", a.TimeEllapsed.ToString(), a.Result.FibResult.ToString(), a.Result.FibIndex.ToString());
            //Console.WriteLine("Recursion:\nTime Elappsed: {0}ms, FibMax: {1}, MaxIndex: {2}", b.TimeEllapsed.ToString(), b.Result.FibResult.ToString(), b.Result.FibIndex.ToString());
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
