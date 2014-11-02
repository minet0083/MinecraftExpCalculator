using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftExpCalculator
{
    public partial class AppWindow : Form
    {
        public AppWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int value;
            double s_resultLv = new double();
            double s_resultExp = new double();
            double s_requireExp = new double();

            // テキストボックス未入力時
            if (inputBox.TextLength == 0)
            {
                MessageBox.Show("何も入力されていません。", "注意");
                return;
            }

            // 数字以外を入力された時
            if (!int.TryParse(inputBox.Text, out value)) 
            {
                MessageBox.Show("数字以外を入力することはできません。", "注意");
                return;
            }

            // int型に変換
            value = Convert.ToInt32(inputBox.Text);

            if (value < 0)
            {
                MessageBox.Show("負の数値を入力することはできません。", "注意");
                return;
            }
            
            // 1.7の計算方式を適用する
            if (radioButton_v17.Checked)
            {
                // レベルを経験値に変換
                if (radioButton_LtoE.Checked)
                {
                    if (0 <= value && value <= 15)
                    {
                        s_resultExp = value * 17;
                    }
                    else if (15 < value && value <= 30)
                    {
                        s_resultExp = 1.5 * Math.Pow(value, 2) - 29.5 * value + 360;
                    }
                    else if (30 < value)
                    {
                        s_resultExp = 3.5 * Math.Pow(value, 2) - 151.5 * value + 2220;
                    }
                    s_resultLv = value;
                    s_requireExp = s_resultExp;
                }

                // 経験値をレベルに変換
                if (radioButton_EtoL.Checked)
                {
                    if (value == 0)
                    {
                        s_resultLv = 0;
                        s_requireExp = 0;
                    }
                    else if (0 < value && value <= 272)
                    {
                        s_resultLv = (value / 17);
                        s_requireExp = s_resultLv * 17;
                    }
                    else if (272 < value && value <= 887)
                    {
                        s_resultLv = Math.Floor((29.5 + Math.Pow(870.25 - 6 * (360 - value), 0.5)) / 3);
                        s_requireExp = Math.Floor(1.5 * Math.Pow(s_resultLv, 2) - 29.5 * (s_resultLv) + 360);
                    }
                    else if (887 < value)
                    {
                        s_resultLv = Math.Floor((151.5 + Math.Pow(22952.25 - 14 * (2220 - value), 0.5)) / 7);
                        s_requireExp = Math.Floor(3.5 * Math.Pow(s_resultLv, 2) - 151.5 * (s_resultLv) + 2220);
                    }
                    s_resultExp = value;
                }
            }

            // 1.8の計算方式を適用する
            else if (radioButton_v18.Checked)
            {
                // レベルを経験値に変換
                if (radioButton_LtoE.Checked)
                {
                    if (0 <= value && value <= 15)
                    {
                        s_resultExp = Math.Pow(value, 2) + value * 6;
                    }
                    else if (15 < value && value <= 30)
                    {
                        s_resultExp = 2.5 * Math.Pow(value, 2) - 40.5 * value + 360;
                    }
                    else if (30 < value)
                    {
                        s_resultExp = 4.5 * Math.Pow(value, 2) - 162.5 * value + 2220;
                    }
                    s_resultLv = value;
                    s_requireExp = s_resultExp;
                }

                // 経験値をレベルに変換
                if (radioButton_EtoL.Checked)
                {
                    if (value == 0)
                    {
                        s_resultLv = 0;
                        s_requireExp = 0;
                    }
                    else if (0 < value && value <= 352)
                    {
                        s_resultLv = Math.Floor((Math.Pow((36 + 4 * value), 0.5) - 6) / 2);
                        s_requireExp = Math.Floor(Math.Pow(s_resultLv, 2) + 6 * (s_resultLv));
                    }
                    else if (272 < value && value <= 887)
                    {
                        s_resultLv = Math.Floor((40.5 + Math.Pow(1640.25 - 10 * (360 - value), 0.5)) / 5);
                        s_requireExp = Math.Floor(2.5 * Math.Pow(s_resultLv, 2) - 40.5 * (s_resultLv) + 360);
                    }
                    else if (887 < value)
                    {
                        s_resultLv = Math.Floor((162.5 + Math.Pow(26406.25 - 18 * (2220 - value), 0.5)) / 9);
                        s_requireExp = Math.Floor(4.5 * Math.Pow(s_resultLv, 2) - 162.5 * (s_resultLv) + 2220);
                    }
                    s_resultExp = value;
                }
            }
            resultLv.Text = Convert.ToString(s_resultLv);
            resultExp.Text = Convert.ToString(s_resultExp);
            requireExp.Text = Convert.ToString(s_requireExp);
        }
    }
}
