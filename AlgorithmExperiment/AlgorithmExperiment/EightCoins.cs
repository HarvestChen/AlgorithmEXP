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
    public partial class EightCoins : Form
    {
        int[] eightCoins = new int[8];

        Form mainF;
        public EightCoins(Form f)
        {
            InitializeComponent();
            mainF = f;
        }

        private void EightCoins_FormClosing(object sender, FormClosingEventArgs e)
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

        #region EightCoinsAlgorithms
        public string CreateASequence()
        {
            Random random = new Random();
            int fateCoinIndex = random.Next(0, 7);
            int fateCoinWeight = random.Next(0, 10);
            int trueCoinWeight = random.Next(0, 10);
            while (true)
            {
                if (trueCoinWeight == fateCoinWeight)
                {
                    trueCoinWeight = random.Next(0, 10);
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (i == fateCoinIndex)
                {
                    eightCoins[i] = fateCoinWeight;
                }
                else
                {
                    eightCoins[i] = trueCoinWeight;
                }
            }
            if (fateCoinWeight > trueCoinWeight)
            {
                return string.Format("第{0}枚硬币是比较重的假币，重量为{1}，真币重量为{2}", (fateCoinIndex + 1).ToString(), fateCoinWeight.ToString(), trueCoinWeight.ToString());
            }
            else
            {
                return string.Format("第{0}枚硬币是比较轻的假币，重量为{1}，真币重量为{2}", (fateCoinIndex + 1).ToString(), fateCoinWeight.ToString(), trueCoinWeight.ToString());
            }
        }

        public void EightCoinsAlgorithm()
        {
            listRst.Items.Add("-------------Comparison Start-------------");
            listRst.Items.Add("C1+C2+C3 ? C4+C5+C6");
            if (eightCoins[0] + eightCoins[1] + eightCoins[2] > eightCoins[3] + eightCoins[4] + eightCoins[5])
            {
                listRst.Items.Add("C1+C2+C3 > C4+C5+C6, C1+C4 ? C2+C5");
                if (eightCoins[0] + eightCoins[3] > eightCoins[1] + eightCoins[4])
                {
                    listRst.Items.Add("C1+C4 > C2+C5, C1 ? C2");
                    if (eightCoins[0] > eightCoins[1])
                    {
                        listRst.Items.Add("C1 > C2, C1 is a HEAVIER FATE coin.");
                    }
                    else
                    {
                        listRst.Items.Add("C1 = C2, C5 is a LIGHTER FATE coin.");
                    }
                }
                else if (eightCoins[0] + eightCoins[3] < eightCoins[1] + eightCoins[4])
                {
                    listRst.Items.Add("C1+C4 < C2+C5, C2 ? C1");
                    if (eightCoins[1] > eightCoins[0])
                    {
                        listRst.Items.Add("C2 > C1, C2 is a HEAVIER FATE coin.");
                    }
                    else
                    {
                        listRst.Items.Add("C2 = C1, C3 is a LIGHTER FATE coin.");
                    }
                }
                else
                {
                    listRst.Items.Add("C1+C4 = C2+C5, C3 ? C1");
                    if (eightCoins[2] > eightCoins[0])
                    {
                        listRst.Items.Add("C3 > C1, C5 is a HEAVIER FATE coin.");
                    }
                    else
                    {
                        listRst.Items.Add("C3 = C1, C6 is a LIGHTER FATE coin.");
                    }
                }
            }
            else if (eightCoins[0] + eightCoins[1] + eightCoins[2] < eightCoins[3] + eightCoins[4] + eightCoins[5])
            {
                listRst.Items.Add("C1+C2+C3 < C4+C5+C6, C1+C4 ? C2+C5");
                if (eightCoins[0] + eightCoins[3] > eightCoins[1] + eightCoins[4])
                {
                    listRst.Items.Add("C1+C4 > C2+C5, C1 ? C2");
                    if (eightCoins[0] > eightCoins[1])
                    {
                        listRst.Items.Add("C1 > C2, C2 is a LIGHTER FATE coin.");
                    }
                    else
                    {
                        listRst.Items.Add("C1 = C2, C4 is a HEAVIER FATE coin.");
                    }
                }
                else if (eightCoins[0] + eightCoins[3] < eightCoins[1] + eightCoins[4])
                {
                    listRst.Items.Add("C1+C4 < C2+C5, C2 ? C1");
                    if (eightCoins[1] > eightCoins[0])
                    {
                        listRst.Items.Add("C2 > C1, C1 is a LIGHTER FATE coin.");
                    }
                    else
                    {
                        listRst.Items.Add("C2 = C1, C5 is a HEAVIER FATE coin.");
                    }
                }
                else
                {
                    listRst.Items.Add("C1+C4 = C2+C5, C1 ? C3");
                    if (eightCoins[0] > eightCoins[2])
                    {
                        listRst.Items.Add("C1 > C3, C3 is a LIGHTER FATE coin.");
                    }
                    else
                    {
                        listRst.Items.Add("C1 = C3, C6 is a HEAVIER FATE coin.");
                    }
                }
            }
            else
            {
                listRst.Items.Add("C1+C2+C3 = C4+C5+C6, C7 ? C8");
                if (eightCoins[6] > eightCoins[7])
                {
                    listRst.Items.Add("C7 > C8, C7 ? C1");
                    if (eightCoins[6] > eightCoins[0])
                    {
                        listRst.Items.Add("C7 > C1, C7 is a HEAVIER FATE coin.");
                    }
                    else
                    {
                        listRst.Items.Add("C7 = C1, C8 is a LIGHTER FATE coin.");
                    }
                }
                else
                {
                    listRst.Items.Add("C7 < C8, C8 ? C1");
                    if (eightCoins[7] > eightCoins[0])
                    {
                        listRst.Items.Add("C8 > C1, C8 is a HEAVIER FATE coin.");
                    }
                    else
                    {
                        listRst.Items.Add("C8 = C1, C7 is a LIGHTER FATE coin.");
                    }
                }
            }
            listRst.Items.Add("-------------Comparison   End-------------");
        }
        #endregion

        private void EightCoins_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
        }

        private void btnCreateSequence_Click(object sender, EventArgs e)
        {
            listRst.Items.Add(CreateASequence());
            btnStart.Enabled = true;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            listRst.Items.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            EightCoinsAlgorithm();
        }
    }
}
