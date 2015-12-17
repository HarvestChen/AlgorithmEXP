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

        #region MatrixAlgorithms
        /// <summary>
        /// 使用蛮力法(BF Method)进行矩阵乘法
        /// </summary>
        /// <param name="matrixA">矩阵A</param>
        /// <param name="matrixB">矩阵B</param>
        /// <returns>矩阵A与矩阵B的乘积</returns>
        public float[,] MatrixMultiplyUseBruteForceMethod(float[,] matrixA,float[,] matrixB)
        {
            //Make sure that the cols of A equals to the rows of B.
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                return null;
            }
            //To storage the result.
            float[,] matrixResult = new float[matrixA.GetLength(0), matrixB.GetLength(1)];
            //Traverse all rows in matrixA
            for(int i = 0; i < matrixA.GetLength(0); i++)
            {
                //Traverse all cols in matrixB
                for(int j = 0; j < matrixB.GetLength(1); j++)
                {
                    //matrixElement means each elements in matrix
                    float matrixElement = 0;
                    for(int k = 0; k < matrixA.GetLength(1); k++)
                    {
                        matrixElement += (matrixA[i, k] * matrixB[k, j]);
                    }
                    matrixResult[i, j] = matrixElement;
                }
            }
            return matrixResult;
        }

        /// <summary>
        /// 使用分治法(DAC Method)进行矩阵的乘法
        /// </summary>
        /// <param name="a">矩阵A</param>
        /// <param name="b">矩阵B</param>
        /// <returns>矩阵A与矩阵B的乘积</returns>
        public static float[,] MatrixMultiplyUseDivideAndConquerMethod(float[,] a, float[,] b)
        {
            //a，b均是2的乘方的方阵
            float[,] result = new float[a.GetLength(0), a.GetLength(0)];
            if (a.GetLength(0) == 2)
            {
                //如果a,b均是2阶的，递归结束条件
                result = StrassMul(a, b);
            }
            else
            {
                //a的四个子矩阵
                float[,] A00 = copyArrays(a, 1);
                float[,] A01 = copyArrays(a, 2);
                float[,] A10 = copyArrays(a, 3);
                float[,] A11 = copyArrays(a, 4);
                //b的四个子矩阵
                float[,] B00 = copyArrays(b, 1);
                float[,] B01 = copyArrays(b, 2);
                float[,] B10 = copyArrays(b, 3);
                float[,] B11 = copyArrays(b, 4);
                //递归调用
                float[,] m1 = MatrixMultiplyUseDivideAndConquerMethod(addArrays(A00, A11), addArrays(B00, B11));
                float[,] m2 = MatrixMultiplyUseDivideAndConquerMethod(addArrays(A10, A11), B00);
                float[,] m3 = MatrixMultiplyUseDivideAndConquerMethod(A00, subArrays(B01, B11));
                float[,] m4 = MatrixMultiplyUseDivideAndConquerMethod(A11, subArrays(B10, B00));
                float[,] m5 = MatrixMultiplyUseDivideAndConquerMethod(addArrays(A00, A01), B11);
                float[,] m6 = MatrixMultiplyUseDivideAndConquerMethod(subArrays(A10, A00), addArrays(B00, B01));
                float[,] m7 = MatrixMultiplyUseDivideAndConquerMethod(subArrays(A01, A11), addArrays(B10, B11));
                //得到result的四个子矩阵
                float[,] C00 = addArrays(m7, subArrays(addArrays(m1, m4), m5));
                float[,] C01 = addArrays(m3, m5);
                float[,] C10 = addArrays(m2, m4);
                float[,] C11 = addArrays(m6, subArrays(addArrays(m1, m3), m2));
                //将四个子矩阵合并成result
                Merge(result, C00, 1);
                Merge(result, C01, 2);
                Merge(result, C10, 3);
                Merge(result, C11, 4);
            }
            return result;
        }


        private static void Merge(float[,] result, float[,] C, int flag)
        {
            //将C复制到result的相应位置
            switch (flag)
            {
                case 1:
                    for (int i = 0; i < result.GetLength(0) / 2; i++)
                        for (int j = 0; j < result.GetLength(0) / 2; j++)
                            result[i, j] = C[i, j];
                    break;
                case 2:
                    for (int i = 0; i < result.GetLength(0) / 2; i++)
                        for (int j = result.GetLength(0) / 2; j < result.GetLength(0); j++)
                            result[i, j] = C[i, j - result.GetLength(0) / 2];
                    break;
                case 3:
                    for (int i = result.GetLength(0) / 2; i < result.GetLength(0); i++)
                        for (int j = 0; j < result.GetLength(0) / 2; j++)
                            result[i, j] = C[i - result.GetLength(0) / 2, j];
                    break;
                case 4:
                    for (int i = result.GetLength(0) / 2; i < result.GetLength(0); i++)
                        for (int j = result.GetLength(0) / 2; j < result.GetLength(0); j++)
                            result[i, j] = C[i - result.GetLength(0) / 2, j - result.GetLength(0) / 2];
                    break;
            }
        }


        private static float[,] copyArrays(float[,] a, int flag)
        {
            //得到分割矩阵的子矩阵
            float[,] result = new float[a.GetLength(0) / 2, a.GetLength(0) / 2];
            switch (flag)
            {
                case 1:
                    for (int i = 0; i < a.GetLength(0) / 2; i++)
                        for (int j = 0; j < a.GetLength(0) / 2; j++)
                            result[i, j] = a[i, j];
                    break;
                case 2:
                    for (int i = 0; i < a.GetLength(0) / 2; i++)
                        for (int j = a.GetLength(0) / 2; j < a.GetLength(0); j++)
                            result[i, j - a.GetLength(0) / 2] = a[i, j];
                    break;
                case 3:
                    for (int i = a.GetLength(0) / 2; i < a.GetLength(0); i++)
                        for (int j = 0; j < a.GetLength(0) / 2; j++)
                            result[i - a.GetLength(0) / 2, j] = a[i, j];
                    break;
                case 4:
                    for (int i = a.GetLength(0) / 2; i < a.GetLength(0); i++)
                        for (int j = a.GetLength(0) / 2; j < a.GetLength(0); j++)
                            result[i - a.GetLength(0) / 2, j - a.GetLength(0) / 2] = a[i, j];
                    break;
            }

            return result;
        }


        private static float[,] StrassMul(float[,] a, float[,] b)
        {
            //计算2个二阶的矩阵乘法
            //Strassen方法使用了7次乘法，18次加法（传统方法是8次乘法4次加法）
            float[,] result = new float[2, 2];

            float m1 = (a[0, 0] + a[1, 1]) * (b[0, 0] + b[1, 1]);
            float m2 = (a[1, 0] + a[1, 1]) * b[0, 0];
            float m3 = a[0, 0] * (b[0, 1] - b[1, 1]);
            float m4 = a[1, 1] * (b[1, 0] - b[0, 0]);
            float m5 = (a[0, 0] + a[0, 1]) * b[1, 1];
            float m6 = (a[1, 0] - a[0, 0]) * (b[0, 0] + b[0, 1]);
            float m7 = (a[0, 1] - a[1, 1]) * (b[1, 0] + b[1, 1]);

            result[0, 0] = m1 + m4 - m5 + m7;
            result[0, 1] = m3 + m5;
            result[1, 0] = m2 + m4;
            result[1, 1] = m1 + m3 - m2 + m6;

            return result;
        }


        private static float[,] addArrays(float[,] a, float[,] b)
        {
            //求2个同阶矩阵的和
            float[,] result = new float[a.GetLength(0), a.GetLength(0)];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(0); j++)
                    result[i, j] = a[i, j] + b[i, j];
            return result;
        }


        private static float[,] subArrays(float[,] a, float[,] b)
        {
            //矩阵减法
            float[,] result = new float[a.GetLength(0), a.GetLength(0)];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(0); j++)
                    result[i, j] = a[i, j] - b[i, j];
            return result;
        }
        #endregion

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

        float[,] matrixA, matrixB, matrixResult;

        private void btnRandom_Click(object sender, EventArgs e)
        {
            BFTime.Text = "";
            DACTime.Text = "";
            matrixA = null;
            matrixB = null;
            matrixATextBox.Text = "";
            matrixBTextBox.Text = "";
            matrixResultTextbox.Text = "";
            int aCol, aRow, bCol, bRow;
            Random random = new Random();
            int num = random.Next(2, 9);
            while (true)
            {
                if (num % 2 != 0)
                {
                    num = random.Next(2, 9);
                }
                else { break; }
            }
            aRow = num;
            bRow = num;
            aCol = num;
            bCol = num;
            matrixA = new float[aRow, aCol];
            matrixB = new float[bRow, bCol];
            for(int i = 0; i < matrixA.GetLength(0); i++)
            {
                for(int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = random.Next(0, 10);
                    matrixATextBox.Text += matrixA[i, j] + "\t";
                }
                matrixATextBox.Text += "\n";
            }
            for(int i = 0; i < matrixB.GetLength(0); i++)
            {
                for(int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixB[i, j] = random.Next(0, 10);
                    matrixBTextBox.Text += matrixB[i, j] + "\t";
                }
                matrixBTextBox.Text += "\n";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Reset();
            matrixResultTextbox.Text = "";
            BFTime.Text = "";
            DACTime.Text = "";
            if (matrixA != null && matrixB != null)
            {
                watch.Start();
                matrixResult = MatrixMultiplyUseBruteForceMethod(matrixA, matrixB);
                watch.Stop();
                BFTime.Text = watch.ElapsedMilliseconds.ToString() + "毫秒";
                if (matrixResult != null)
                {
                    for(int i = 0; i < matrixResult.GetLength(0); i++)
                    {
                        for(int j = 0; j < matrixResult.GetLength(1); j++)
                        {
                            matrixResultTextbox.Text += matrixResult[i, j] + "\t";
                        }
                        matrixResultTextbox.Text += "\n";
                    }
                }
                else
                {
                    matrixResultTextbox.Text += "\n\n\n\n矩阵A与矩阵B无法相乘";
                }
                watch.Reset();
                matrixResult = MatrixMultiplyUseDivideAndConquerMethod(matrixA, matrixB);
                watch.Stop();
                DACTime.Text = watch.ElapsedMilliseconds.ToString() + "毫秒";
            }
            else
            {
                matrixResultTextbox.Text += "\n\n\n\n请输入矩阵A与矩阵B的数据";
            }
        }

        private void MatrixMultiply_Load(object sender, EventArgs e)
        {
            matrixATextBox.Text = "";
            matrixBTextBox.Text = "";
            matrixResultTextbox.Text = "";
            matrixA = null;
            matrixB = null;
            BFTime.Text = "";
            DACTime.Text = "";
            btnRandom.Focus();
        }
    }
}
