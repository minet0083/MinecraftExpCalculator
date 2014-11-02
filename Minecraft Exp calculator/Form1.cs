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

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_17_Click(object sender, EventArgs e)
        {
            // 変数をまとめて先に宣言してみる。
            int value_17;
            string sResultExp = "";
            string sResultLv = "";
            string sRequireExp = "";
            if (InputBox_17.TextLength == 0) // テキストボックスが空の時
            {
                MessageBox.Show("何も入力されていません。", "注意");
                return;
            }

            if (!int.TryParse(InputBox_17.Text, out value_17)) // 数字以外を入力された時
            {
                MessageBox.Show("数字以外を入力することはできません。", "注意");
                return;
            }

            value_17 = Convert.ToInt32(InputBox_17.Text); // int型に変換
            if (radioButton_LtoE_17.Checked)
            {
                
                if (0 <= value_17 && value_17 <= 15)
                {
                    sResultExp = Convert.ToString(1.5 * Math.Pow(value_17, 2) - 29.5 * value_17 + 360);
                }
                else if (30 < value_17)
                {
                    sResultExp = Convert.ToString(3.5 * Math.Pow(value_17, 2) - 151.5 * value_17 + 2220);
                }

                ResultLv_17.Text = Convert.ToString(value_17);
                ResultExp_17.Text = Convert.ToString(sResultExp);
                RequireExp_17.Text = sResultExp;
            }
            else if (radioButton_EtoL_17.Checked)
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

                ResultLv_17.Text = sResultLv;
                ResultExp_17.Text = sResultExp;
                RequireExp_17.Text = sRequireExp;
            }
        }

        private void button_18_Click(object sender, EventArgs e)
        {
            int value_18;
            string sResultExp = "";
            string sResultLv = "";
            string sRequireExp = "";
            if (InputBox_18.TextLength == 0) // テキストボックスが空の時
            {
                MessageBox.Show("何も入力されていません。", "注意");
                return;
            }

            if (!int.TryParse(InputBox_18.Text, out value_18)) // 数字以外を入力された時
            {
                MessageBox.Show("数字以外を入力することはできません。", "注意");
                return;
            }

            value_18 = Convert.ToInt32(InputBox_18.Text); // int型に変換
            if (radioButton_LtoE_18.Checked)
            {
                ResultLv_18.Text = Convert.ToString(value_18);
                
                if (0 <= value_18 && value_18 <= 15)
                {
                    sResultExp = Convert.ToString(Math.Pow(value_18, 2) + value_18 * 6);
                }
                else if (15 < value_18 && value_18 <= 30)
                {
                    sResultExp = Convert.ToString(2.5 * Math.Pow(value_18, 2) - 40.5 * value_18 + 360);
                }
                else if (30 < value_18)
                {
                    sResultExp = Convert.ToString(4.5 * Math.Pow(value_18, 2) - 162.5 * value_18 + 2220);
                }

                ResultLv_18.Text = Convert.ToString(value_18);
                ResultExp_18.Text = sResultExp;
                RequireExp_18.Text = sResultExp;
            }
            if (radioButton_EtoL_18.Checked)
            {
                double value_resultLv_18;
                
                if (value_18 == 0)
                {
                    sResultLv = Convert.ToString(0);
                    sResultExp = Convert.ToString(0);
                    RequireExp_18.Text = Convert.ToString(0);
                }
                else if (0 < value_18 && value_18 <= 352)
                {
                    value_resultLv_18 = Math.Floor((Math.Pow((36 + 4 * value_18), 0.5) - 6) / 2);
                    sResultLv = Convert.ToString(value_resultLv_18);
                    sResultExp = Convert.ToString(value_18);
                    sRequireExp = Convert.ToString(Math.Floor(Math.Pow(value_resultLv_18, 2) + 6 * (value_resultLv_18)));
                }
                else if (272 < value_18 && value_18 <= 1507)
                {
                    value_resultLv_18 = Math.Floor((40.5 + Math.Pow(1640.25 - 10 * (360 - value_18), 0.5)) / 5);
                    sResultLv = Convert.ToString(value_resultLv_18);
                    sResultExp = Convert.ToString(value_18);
                    sRequireExp = Convert.ToString(Math.Floor(2.5 * Math.Pow(value_resultLv_18, 2) - 40.5 * (value_resultLv_18) + 360));
                }
                else if (1507 < value_18)
                {
                    value_resultLv_18 = Math.Floor((162.5 + Math.Pow(26406.25 - 18 * (2220 - value_18), 0.5)) / 9);
                    sResultLv = Convert.ToString(value_resultLv_18);
                    sResultExp = Convert.ToString(value_18);
                    sRequireExp = Convert.ToString(Math.Floor(4.5 * Math.Pow(value_resultLv_18, 2) - 162.5 * (value_resultLv_18) + 2220));
                }

                ResultLv_18.Text = sResultLv;
                ResultExp_18.Text = sResultExp;
                RequireExp_18.Text = sRequireExp;
            }
        }

        private void InputBox_17_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_LtoE_18_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
