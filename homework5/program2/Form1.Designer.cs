namespace program2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.IndexK = new System.Windows.Forms.TextBox();
            this.IndexN = new System.Windows.Forms.TextBox();
            this.TreePer1 = new System.Windows.Forms.TextBox();
            this.TreePer2 = new System.Windows.Forms.TextBox();
            this.TreeAngle1 = new System.Windows.Forms.TextBox();
            this.TreeAngle2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LengBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LineThick = new System.Windows.Forms.TextBox();
            this.LineColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(1111, 560);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(98, 37);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1002, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "两树位置系数";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1002, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "迭代次数";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1002, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "树1长度";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1002, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "树2长度";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ColorLabel.Location = new System.Drawing.Point(1002, 459);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(67, 15);
            this.ColorLabel.TabIndex = 1;
            this.ColorLabel.Text = "更换颜色";
            this.ColorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1002, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "树1角度";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1002, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "树2角度";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // IndexK
            // 
            this.IndexK.Location = new System.Drawing.Point(1111, 72);
            this.IndexK.Name = "IndexK";
            this.IndexK.Size = new System.Drawing.Size(100, 25);
            this.IndexK.TabIndex = 2;
            this.IndexK.Text = "1.0";
            this.IndexK.TextChanged += new System.EventHandler(this.IndexK_TextChanged);
            // 
            // IndexN
            // 
            this.IndexN.Location = new System.Drawing.Point(1111, 118);
            this.IndexN.Name = "IndexN";
            this.IndexN.Size = new System.Drawing.Size(100, 25);
            this.IndexN.TabIndex = 2;
            this.IndexN.Text = "10";
            this.IndexN.TextChanged += new System.EventHandler(this.IndexN_TextChanged);
            // 
            // TreePer1
            // 
            this.TreePer1.Location = new System.Drawing.Point(1111, 163);
            this.TreePer1.Name = "TreePer1";
            this.TreePer1.Size = new System.Drawing.Size(100, 25);
            this.TreePer1.TabIndex = 2;
            this.TreePer1.Text = "0.6";
            this.TreePer1.TextChanged += new System.EventHandler(this.TreePer1_TextChanged);
            // 
            // TreePer2
            // 
            this.TreePer2.Location = new System.Drawing.Point(1111, 205);
            this.TreePer2.Name = "TreePer2";
            this.TreePer2.Size = new System.Drawing.Size(100, 25);
            this.TreePer2.TabIndex = 2;
            this.TreePer2.Text = "0.7";
            this.TreePer2.TextChanged += new System.EventHandler(this.TreePer2_TextChanged);
            // 
            // TreeAngle1
            // 
            this.TreeAngle1.Location = new System.Drawing.Point(1111, 250);
            this.TreeAngle1.Name = "TreeAngle1";
            this.TreeAngle1.Size = new System.Drawing.Size(100, 25);
            this.TreeAngle1.TabIndex = 2;
            this.TreeAngle1.Text = "30";
            this.TreeAngle1.TextChanged += new System.EventHandler(this.TreeAngle1_TextChanged);
            // 
            // TreeAngle2
            // 
            this.TreeAngle2.Location = new System.Drawing.Point(1111, 293);
            this.TreeAngle2.Name = "TreeAngle2";
            this.TreeAngle2.Size = new System.Drawing.Size(100, 25);
            this.TreeAngle2.TabIndex = 2;
            this.TreeAngle2.Text = "20";
            this.TreeAngle2.TextChanged += new System.EventHandler(this.TreeAngle2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1002, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "高度";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // LengBox
            // 
            this.LengBox.Location = new System.Drawing.Point(1111, 340);
            this.LengBox.Name = "LengBox";
            this.LengBox.Size = new System.Drawing.Size(100, 25);
            this.LengBox.TabIndex = 3;
            this.LengBox.Text = "150";
            this.LengBox.TextChanged += new System.EventHandler(this.LengBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1002, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "线粗细";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // LineThick
            // 
            this.LineThick.Location = new System.Drawing.Point(1111, 417);
            this.LineThick.Name = "LineThick";
            this.LineThick.Size = new System.Drawing.Size(100, 25);
            this.LineThick.TabIndex = 4;
            this.LineThick.Text = "1";
            this.LineThick.TextChanged += new System.EventHandler(this.LineThick_TextChanged);
            // 
            // LineColor
            // 
            this.LineColor.BackColor = System.Drawing.Color.Blue;
            this.LineColor.Enabled = false;
            this.LineColor.Location = new System.Drawing.Point(1111, 448);
            this.LineColor.Name = "LineColor";
            this.LineColor.ReadOnly = true;
            this.LineColor.Size = new System.Drawing.Size(100, 25);
            this.LineColor.TabIndex = 5;
            this.LineColor.TextChanged += new System.EventHandler(this.LineColor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.LineColor);
            this.Controls.Add(this.LineThick);
            this.Controls.Add(this.LengBox);
            this.Controls.Add(this.TreeAngle2);
            this.Controls.Add(this.TreeAngle1);
            this.Controls.Add(this.TreePer2);
            this.Controls.Add(this.TreePer1);
            this.Controls.Add(this.IndexN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IndexK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Draw);
            this.Name = "Form1";
            this.Text = "CayleyTree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox IndexK;
        private System.Windows.Forms.TextBox IndexN;
        private System.Windows.Forms.TextBox TreePer1;
        private System.Windows.Forms.TextBox TreePer2;
        private System.Windows.Forms.TextBox TreeAngle1;
        private System.Windows.Forms.TextBox TreeAngle2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LengBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox LineThick;
        private System.Windows.Forms.TextBox LineColor;
    }
}

