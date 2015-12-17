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
    public partial class HeapSort : Form
    {
        Form mainF;
        public HeapSort(Form f)
        {
            InitializeComponent();
            mainF = f;
        }

        private void HeapSort_FormClosing(object sender, FormClosingEventArgs e)
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

        #region HeapSortAlgorithms
        /// <summary>
        /// 元素交换
        /// </summary>
        /// <param name="a">元素a</param>
        /// <param name="b">元素b</param>
        public void Swap(ref int a, ref int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// 大顶堆的调整过程
        /// </summary>
        /// <param name="array">待调整的数组</param>
        /// <param name="currentIndex">待调整元素在数组中的位置(根节点)</param>
        /// <param name="heapSize">堆中所有元素的个数</param>
        public void MaxHeapify(int[] array, int currentIndex, int heapSize)
        {
            try
            {
                //左子节点在数组中的位置
                int left = 2 * currentIndex + 1;
                //右子节点在数组中的位置
                int right = 2 * currentIndex + 2;
                //记录此根节点, 左子节点, 右子节点三者中最大值的位置
                int large = currentIndex;

                //与左子节点进行比较
                if (left < heapSize && array[left] > array[large])
                {
                    large = left;
                }
                //与右子节点进行比较
                if (right < heapSize && array[right] > array[large])
                {
                    large = right;
                }
                //如果 currentIndex != large 则表明 large 发生变化(左右子节点中有大于根节点的情况)
                if (currentIndex != large)
                {
                    //将左右节点中的大者与根节点进行交换(实现局部大顶堆)
                    Swap(ref array[currentIndex], ref array[large]);
                    //以上次调整动作的large位置(为此次调整的根节点位置), 进行递归调整
                    MaxHeapify(array, large, heapSize);
                }
            }
            catch(Exception ex) { }
        }

        /// <summary>
        /// 创建大顶堆(根节点大于左右子节点)
        /// </summary>
        /// <param name="array">待排序数组</param>
        public void BuildMaxHeap(int[] array)
        {
            try
            {
                //根据大顶堆的性质可知: 数组的前半段元素为根节点, 其余元素都为叶子节点
                //从最底层的最后一个根节点开始进行大顶堆的调整
                for(int i = array.Length / 2 - 1; i >= 0; i--)
                {
                    //调整大顶堆
                    MaxHeapify(array, i, array.Length);
                }
            }
            catch(Exception ex) { }
        }

        /// <summary>
        /// 堆排序算法
        /// </summary>
        /// <param name="array">待排序数组</param>
        public void HeapSortAlgorithm(int[] array)
        {
            try
            {
                //创建大顶堆
                BuildMaxHeap(array);
                for(int i = array.Length - 1; i > 0; i--)
                {
                    //将堆顶元素依次与无序区的最后一位交换(使堆顶元素进入有序区)
                    Swap(ref array[0], ref array[i]);
                    //重新将无序区调整为大顶堆
                    MaxHeapify(array, 0, i);
                }
            }
            catch(Exception ex) { }
        }
        #endregion

        private void HeapSort_Load(object sender, EventArgs e)
        {
            timeEllapsedLabel.Text = "";
            sortedArea.Text = "";
            unsortedArea.Text = "";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (unsortedArea.Text.Trim(' ') != "")
            {
                try
                {
                    timeEllapsedLabel.Text = "";
                    sortedArea.Text = "";
                    System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                    string dataRead = this.unsortedArea.Text;
                    int[] array;
                    string[] b;
                    string[] a = dataRead.Split(' ');
                    if (a[a.Length - 1] == "")
                    {
                        b = new string[a.Length - 1];
                        for (int i = 0; i < b.Length; i++)
                        {
                            b[i] = a[i];
                        }
                        array = new int[b.Length];
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = Convert.ToInt32(b[i]);
                        }
                        watch.Reset();
                        watch.Start();
                        HeapSortAlgorithm(array);
                        watch.Stop();
                        timeEllapsedLabel.Text = watch.ElapsedMilliseconds.ToString() + "毫秒";
                        foreach (int k in array)
                        {
                            sortedArea.Text += k.ToString() + " ";
                        }
                    }
                    else
                    {
                        array = new int[a.Length];
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = Convert.ToInt32(a[i]);
                        }
                        watch.Reset();
                        watch.Start();
                        HeapSortAlgorithm(array);
                        watch.Stop();
                        timeEllapsedLabel.Text = watch.ElapsedMilliseconds.ToString() + "毫秒";
                        foreach (int k in array)
                        {
                            sortedArea.Text += k.ToString() + " ";
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请生成数据或手动输入数据，数与数之间使用空格做间隔。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                unsortedArea.Text = "";
                sortedArea.Text = "";
                timeEllapsedLabel.Text = "";
                int num = (int)this.dataNumber.Value;
                Random random = new Random();
                for (int i = 0; i < num; i++)
                {
                    unsortedArea.Text += random.Next().ToString() + " ";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            unsortedArea.Text = "";
            sortedArea.Text = "";
            timeEllapsedLabel.Text = "";
        }
    }
}
