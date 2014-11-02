namespace MinecraftExpCalculator
{
    partial class AppWindow
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
            this.groupBox_versionSelect = new System.Windows.Forms.GroupBox();
            this.radioButton_v18 = new System.Windows.Forms.RadioButton();
            this.radioButton_v17 = new System.Windows.Forms.RadioButton();
            this.groupBox_calculateType = new System.Windows.Forms.GroupBox();
            this.radioButton_EtoL = new System.Windows.Forms.RadioButton();
            this.radioButton_LtoE = new System.Windows.Forms.RadioButton();
            this.groupBox_inputArea = new System.Windows.Forms.GroupBox();
            this.button = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.description1 = new System.Windows.Forms.Label();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.groupBox_resultExperience = new System.Windows.Forms.GroupBox();
            this.groupBox_resultLevel = new System.Windows.Forms.GroupBox();
            this.resultLv = new System.Windows.Forms.Label();
            this.resultExp = new System.Windows.Forms.Label();
            this.requireExp = new System.Windows.Forms.Label();
            this.description2 = new System.Windows.Forms.Label();
            this.groupBox_versionSelect.SuspendLayout();
            this.groupBox_calculateType.SuspendLayout();
            this.groupBox_inputArea.SuspendLayout();
            this.groupBox_result.SuspendLayout();
            this.groupBox_resultExperience.SuspendLayout();
            this.groupBox_resultLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_versionSelect
            // 
            this.groupBox_versionSelect.Controls.Add(this.radioButton_v18);
            this.groupBox_versionSelect.Controls.Add(this.radioButton_v17);
            this.groupBox_versionSelect.Location = new System.Drawing.Point(5, 5);
            this.groupBox_versionSelect.Name = "groupBox_versionSelect";
            this.groupBox_versionSelect.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_versionSelect.Size = new System.Drawing.Size(129, 46);
            this.groupBox_versionSelect.TabIndex = 0;
            this.groupBox_versionSelect.TabStop = false;
            this.groupBox_versionSelect.Text = "Minecraftバージョン";
            // 
            // radioButton_v18
            // 
            this.radioButton_v18.AutoSize = true;
            this.radioButton_v18.Location = new System.Drawing.Point(68, 18);
            this.radioButton_v18.Name = "radioButton_v18";
            this.radioButton_v18.Size = new System.Drawing.Size(37, 16);
            this.radioButton_v18.TabIndex = 1;
            this.radioButton_v18.Text = "1.8";
            this.radioButton_v18.UseVisualStyleBackColor = true;
            // 
            // radioButton_v17
            // 
            this.radioButton_v17.AutoSize = true;
            this.radioButton_v17.Checked = true;
            this.radioButton_v17.Location = new System.Drawing.Point(9, 18);
            this.radioButton_v17.Name = "radioButton_v17";
            this.radioButton_v17.Size = new System.Drawing.Size(37, 16);
            this.radioButton_v17.TabIndex = 0;
            this.radioButton_v17.TabStop = true;
            this.radioButton_v17.Text = "1.7";
            this.radioButton_v17.UseVisualStyleBackColor = true;
            // 
            // groupBox_calculateType
            // 
            this.groupBox_calculateType.Controls.Add(this.radioButton_EtoL);
            this.groupBox_calculateType.Controls.Add(this.radioButton_LtoE);
            this.groupBox_calculateType.Location = new System.Drawing.Point(140, 5);
            this.groupBox_calculateType.Name = "groupBox_calculateType";
            this.groupBox_calculateType.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_calculateType.Size = new System.Drawing.Size(327, 46);
            this.groupBox_calculateType.TabIndex = 1;
            this.groupBox_calculateType.TabStop = false;
            this.groupBox_calculateType.Text = "計算方式";
            // 
            // radioButton_EtoL
            // 
            this.radioButton_EtoL.AutoSize = true;
            this.radioButton_EtoL.Location = new System.Drawing.Point(135, 18);
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
            this.radioButton_LtoE.Location = new System.Drawing.Point(8, 18);
            this.radioButton_LtoE.Name = "radioButton_LtoE";
            this.radioButton_LtoE.Size = new System.Drawing.Size(108, 16);
            this.radioButton_LtoE.TabIndex = 0;
            this.radioButton_LtoE.TabStop = true;
            this.radioButton_LtoE.Text = "レベル → 経験値";
            this.radioButton_LtoE.UseVisualStyleBackColor = true;
            // 
            // groupBox_inputArea
            // 
            this.groupBox_inputArea.Controls.Add(this.button);
            this.groupBox_inputArea.Controls.Add(this.inputBox);
            this.groupBox_inputArea.Controls.Add(this.description1);
            this.groupBox_inputArea.Location = new System.Drawing.Point(5, 58);
            this.groupBox_inputArea.Name = "groupBox_inputArea";
            this.groupBox_inputArea.Size = new System.Drawing.Size(462, 45);
            this.groupBox_inputArea.TabIndex = 2;
            this.groupBox_inputArea.TabStop = false;
            this.groupBox_inputArea.Text = "レベルまたは経験値を入力";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(176, 14);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 2;
            this.button.Text = "計算";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(50, 16);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(120, 19);
            this.inputBox.TabIndex = 1;
            // 
            // description1
            // 
            this.description1.AutoSize = true;
            this.description1.Location = new System.Drawing.Point(9, 19);
            this.description1.Name = "description1";
            this.description1.Size = new System.Drawing.Size(35, 12);
            this.description1.TabIndex = 0;
            this.description1.Text = "数値 :";
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.groupBox_resultExperience);
            this.groupBox_result.Controls.Add(this.groupBox_resultLevel);
            this.groupBox_result.Location = new System.Drawing.Point(5, 110);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(462, 175);
            this.groupBox_result.TabIndex = 3;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "計算結果";
            // 
            // groupBox_resultExperience
            // 
            this.groupBox_resultExperience.Controls.Add(this.resultExp);
            this.groupBox_resultExperience.Location = new System.Drawing.Point(234, 19);
            this.groupBox_resultExperience.Name = "groupBox_resultExperience";
            this.groupBox_resultExperience.Size = new System.Drawing.Size(221, 149);
            this.groupBox_resultExperience.TabIndex = 1;
            this.groupBox_resultExperience.TabStop = false;
            this.groupBox_resultExperience.Text = "経験値";
            // 
            // groupBox_resultLevel
            // 
            this.groupBox_resultLevel.Controls.Add(this.description2);
            this.groupBox_resultLevel.Controls.Add(this.requireExp);
            this.groupBox_resultLevel.Controls.Add(this.resultLv);
            this.groupBox_resultLevel.Location = new System.Drawing.Point(7, 19);
            this.groupBox_resultLevel.Name = "groupBox_resultLevel";
            this.groupBox_resultLevel.Size = new System.Drawing.Size(221, 149);
            this.groupBox_resultLevel.TabIndex = 0;
            this.groupBox_resultLevel.TabStop = false;
            this.groupBox_resultLevel.Text = "レベル";
            // 
            // resultLv
            // 
            this.resultLv.AutoSize = true;
            this.resultLv.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultLv.Location = new System.Drawing.Point(6, 15);
            this.resultLv.Name = "resultLv";
            this.resultLv.Size = new System.Drawing.Size(36, 37);
            this.resultLv.TabIndex = 0;
            this.resultLv.Text = "0";
            // 
            // resultExp
            // 
            this.resultExp.AutoSize = true;
            this.resultExp.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultExp.Location = new System.Drawing.Point(6, 15);
            this.resultExp.Name = "resultExp";
            this.resultExp.Size = new System.Drawing.Size(36, 37);
            this.resultExp.TabIndex = 0;
            this.resultExp.Text = "0";
            // 
            // requireExp
            // 
            this.requireExp.AutoSize = true;
            this.requireExp.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.requireExp.Location = new System.Drawing.Point(6, 125);
            this.requireExp.Name = "requireExp";
            this.requireExp.Size = new System.Drawing.Size(21, 21);
            this.requireExp.TabIndex = 1;
            this.requireExp.Text = "0";
            // 
            // description2
            // 
            this.description2.AutoSize = true;
            this.description2.Location = new System.Drawing.Point(4, 113);
            this.description2.Name = "description2";
            this.description2.Size = new System.Drawing.Size(118, 12);
            this.description2.TabIndex = 2;
            this.description2.Text = "上記レベル必要経験値";
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(472, 290);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.groupBox_inputArea);
            this.Controls.Add(this.groupBox_calculateType);
            this.Controls.Add(this.groupBox_versionSelect);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AppWindow";
            this.Text = "Minecraft Exp Calculator vβ";
            this.groupBox_versionSelect.ResumeLayout(false);
            this.groupBox_versionSelect.PerformLayout();
            this.groupBox_calculateType.ResumeLayout(false);
            this.groupBox_calculateType.PerformLayout();
            this.groupBox_inputArea.ResumeLayout(false);
            this.groupBox_inputArea.PerformLayout();
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_resultExperience.ResumeLayout(false);
            this.groupBox_resultExperience.PerformLayout();
            this.groupBox_resultLevel.ResumeLayout(false);
            this.groupBox_resultLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_versionSelect;
        private System.Windows.Forms.RadioButton radioButton_v18;
        private System.Windows.Forms.RadioButton radioButton_v17;
        private System.Windows.Forms.GroupBox groupBox_calculateType;
        private System.Windows.Forms.RadioButton radioButton_LtoE;
        private System.Windows.Forms.RadioButton radioButton_EtoL;
        private System.Windows.Forms.GroupBox groupBox_inputArea;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label description1;
        private System.Windows.Forms.GroupBox groupBox_result;
        private System.Windows.Forms.GroupBox groupBox_resultExperience;
        private System.Windows.Forms.GroupBox groupBox_resultLevel;
        private System.Windows.Forms.Label resultExp;
        private System.Windows.Forms.Label description2;
        private System.Windows.Forms.Label requireExp;
        private System.Windows.Forms.Label resultLv;
    }
}

