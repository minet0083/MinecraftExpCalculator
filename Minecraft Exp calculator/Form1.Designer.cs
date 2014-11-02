namespace Minecraft_Exp_calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ResultExp = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RequireExp = new System.Windows.Forms.Label();
            this.ResultLv = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_EtoL = new System.Windows.Forms.RadioButton();
            this.radioButton_LtoE = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton_v17 = new System.Windows.Forms.RadioButton();
            this.radioButton_v18 = new System.Windows.Forms.RadioButton();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "計算結果";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ResultExp);
            this.groupBox5.Location = new System.Drawing.Point(227, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(212, 138);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "経験値";
            // 
            // ResultExp
            // 
            this.ResultExp.AutoSize = true;
            this.ResultExp.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultExp.Location = new System.Drawing.Point(7, 19);
            this.ResultExp.Name = "ResultExp";
            this.ResultExp.Size = new System.Drawing.Size(33, 35);
            this.ResultExp.TabIndex = 0;
            this.ResultExp.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.RequireExp);
            this.groupBox4.Controls.Add(this.ResultLv);
            this.groupBox4.Location = new System.Drawing.Point(7, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 138);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "レベル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "上記レベル必要経験値";
            // 
            // RequireExp
            // 
            this.RequireExp.AutoSize = true;
            this.RequireExp.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RequireExp.Location = new System.Drawing.Point(6, 119);
            this.RequireExp.Name = "RequireExp";
            this.RequireExp.Size = new System.Drawing.Size(16, 16);
            this.RequireExp.TabIndex = 1;
            this.RequireExp.Text = "0";
            // 
            // ResultLv
            // 
            this.ResultLv.AutoSize = true;
            this.ResultLv.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultLv.Location = new System.Drawing.Point(6, 15);
            this.ResultLv.Name = "ResultLv";
            this.ResultLv.Size = new System.Drawing.Size(33, 35);
            this.ResultLv.TabIndex = 0;
            this.ResultLv.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button);
            this.groupBox2.Controls.Add(this.InputBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "レベルまたは経験値を入力";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(256, 16);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 2;
            this.button.Text = "計算";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_17_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数値 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_EtoL);
            this.groupBox1.Controls.Add(this.radioButton_LtoE);
            this.groupBox1.Location = new System.Drawing.Point(175, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "計算方式";
            // 
            // radioButton_EtoL
            // 
            this.radioButton_EtoL.AutoSize = true;
            this.radioButton_EtoL.Location = new System.Drawing.Point(142, 18);
            this.radioButton_EtoL.Name = "radioButton_EtoL";
            this.radioButton_EtoL.Size = new System.Drawing.Size(108, 16);
            this.radioButton_EtoL.TabIndex = 1;
            this.radioButton_EtoL.Text = "経験値 → レベル";
            this.radioButton_EtoL.UseVisualStyleBackColor = true;
            // 
            // radioButton_LtoE
            // 
            this.radioButton_LtoE.AutoSize = true;
            this.radioButton_LtoE.Checked = true;
            this.radioButton_LtoE.Location = new System.Drawing.Point(7, 19);
            this.radioButton_LtoE.Name = "radioButton_LtoE";
            this.radioButton_LtoE.Size = new System.Drawing.Size(108, 16);
            this.radioButton_LtoE.TabIndex = 0;
            this.radioButton_LtoE.TabStop = true;
            this.radioButton_LtoE.Text = "レベル → 経験値";
            this.radioButton_LtoE.UseVisualStyleBackColor = true;
            this.radioButton_LtoE.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton_v18);
            this.groupBox6.Controls.Add(this.radioButton_v17);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 47);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Minecraftバージョン選択";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // radioButton_v17
            // 
            this.radioButton_v17.AutoSize = true;
            this.radioButton_v17.Checked = true;
            this.radioButton_v17.Location = new System.Drawing.Point(7, 19);
            this.radioButton_v17.Name = "radioButton_v17";
            this.radioButton_v17.Size = new System.Drawing.Size(37, 16);
            this.radioButton_v17.TabIndex = 0;
            this.radioButton_v17.TabStop = true;
            this.radioButton_v17.Text = "1.7";
            this.radioButton_v17.UseVisualStyleBackColor = true;
            // 
            // radioButton_v18
            // 
            this.radioButton_v18.AutoCheck = false;
            this.radioButton_v18.AutoSize = true;
            this.radioButton_v18.Location = new System.Drawing.Point(59, 19);
            this.radioButton_v18.Name = "radioButton_v18";
            this.radioButton_v18.Size = new System.Drawing.Size(37, 16);
            this.radioButton_v18.TabIndex = 1;
            this.radioButton_v18.TabStop = true;
            this.radioButton_v18.Text = "1.8";
            this.radioButton_v18.UseVisualStyleBackColor = true;
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(47, 18);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(203, 19);
            this.InputBox.TabIndex = 1;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_17_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(474, 292);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(480, 320);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "Form1";
            this.Text = "Minecraft Exp Calculator v0.2";
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label ResultExp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RequireExp;
        private System.Windows.Forms.Label ResultLv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_EtoL;
        private System.Windows.Forms.RadioButton radioButton_LtoE;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton_v18;
        private System.Windows.Forms.RadioButton radioButton_v17;
        private System.Windows.Forms.TextBox InputBox;

    }
}

