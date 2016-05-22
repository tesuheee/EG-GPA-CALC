namespace GPA計算機
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(100, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "S ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(99, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "A ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(98, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "B ：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(99, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "C ：";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(153, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 25);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "1";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox2.Location = new System.Drawing.Point(153, 161);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 25);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "1,2,3";
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "1";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox3.Location = new System.Drawing.Point(153, 214);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(76, 25);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "1,2,3";
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.DisplayMember = "1";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox4.Location = new System.Drawing.Point(153, 269);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(76, 25);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.ValueMember = "1,2,3";
            this.comboBox4.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label11.Location = new System.Drawing.Point(72, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "S, A, B, C, D を全て選択してください";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "GPAを計算...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(99, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "D ：";
            // 
            // comboBox5
            // 
            this.comboBox5.DisplayMember = "1";
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox5.Location = new System.Drawing.Point(153, 322);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(76, 25);
            this.comboBox5.TabIndex = 2;
            this.comboBox5.ValueMember = "1,2,3";
            this.comboBox5.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(45, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "（例）Sが2つ、2単位と1単位なら、Sは3を選択";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label7.Location = new System.Drawing.Point(247, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "単位";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label8.Location = new System.Drawing.Point(247, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "単位";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label9.Location = new System.Drawing.Point(247, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "単位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label10.Location = new System.Drawing.Point(247, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "単位";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label12.Location = new System.Drawing.Point(247, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "単位";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "リセット";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPA計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
    }
}

