using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Exp_calculator
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void button_17_Click(object sender, EventArgs e)
        {
            // 変数をまとめて先に宣言してみる。
            int value_17;
            string sResultExp = "";
            string sResultLv = "";
            string sRequireExp = "";
            if (InputBox.TextLength == 0) // テキストボックスが空の時
            {
                MessageBox.Show("何も入力されていません。", "注意");
                return;
            }

            if (!int.TryParse(InputBox.Text, out value_17)) // 数字以外を入力された時
            {
                MessageBox.Show("数字以外を入力することはできません。", "注意");
                return;
            }

            value_17 = Convert.ToInt32(InputBox.Text); // int型に変換
            if (radioButton_LtoE.Checked)
            {
                
                if (0 <= value_17 && value_17 <= 15)
                {
                    sResultExp = Convert.ToString(1.5 * Math.Pow(value_17, 2) - 29.5 * value_17 + 360);
                }
                else if (30 < value_17)
                {
                    sResultExp = Convert.ToString(3.5 * Math.Pow(value_17, 2) - 151.5 * value_17 + 2220);
                }

                ResultLv.Text = Convert.ToString(value_17);
                ResultExp.Text = Convert.ToString(sResultExp);
                RequireExp.Text = sResultExp;
            }
            else if (radioButton_EtoL.Checked)
            {
                double value_resultLv_17;
                if (value_17 == 0)
                {
                    sResultLv = Convert.ToString(0);
                    sResultExp = Convert.ToString(0);
                    sRequireExp = Convert.ToString(0);
                }
                else if (0 < value_17 && value_17 <= 272)
                {
                    value_resultLv_17 = (value_17 / 17);
                    sResultLv = Convert.ToString((value_resultLv_17));
                    sResultExp = Convert.ToString(value_17);
                    sRequireExp = Convert.ToString(value_resultLv_17 * 17);
                }
                else if (272 < value_17 && value_17 <= 887)
                {
                    value_resultLv_17 = Math.Floor((29.5 + Math.Pow(870.25 - 6 * (360 - value_17), 0.5)) / 3);
                    sResultLv = Convert.ToString(value_resultLv_17);
                    sResultExp = Convert.ToString(value_17);
                    sRequireExp = Convert.ToString(Math.Floor(1.5 * Math.Pow(value_resultLv_17, 2) - 29.5 * (value_resultLv_17) + 360));
                }
                else if (887 < value_17)
                {
                    value_resultLv_17 = Math.Floor((151.5 + Math.Pow(22952.25 - 14 * (2220 - value_17), 0.5)) / 7);
                    sResultLv = Convert.ToString(value_resultLv_17);
                    sResultExp = Convert.ToString(value_17);
                    sRequireExp = Convert.ToString(Math.Floor(3.5 * Math.Pow(value_resultLv_17, 2) - 151.5 * (value_resultLv_17) + 2220));
                }

                ResultLv.Text = sResultLv;
                ResultExp.Text = sResultExp;
                RequireExp.Text = sRequireExp;
            }
        }

       }
}
