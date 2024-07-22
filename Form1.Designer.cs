namespace FontTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sampleText = new System.Windows.Forms.ComboBox();
            this.systemFontComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sampleTextSel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(796, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择字体文件... (&B)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "字体文件 (*.ttf;*.otf)|*.ttf;*.otf|所有文件 (*.*)|*.*";
            this.openFileDialog.ReadOnlyChecked = true;
            this.openFileDialog.ShowReadOnly = true;
            // 
            // sampleText
            // 
            this.sampleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sampleText.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleText.FormattingEnabled = true;
            this.sampleText.Location = new System.Drawing.Point(12, 178);
            this.sampleText.Name = "sampleText";
            this.sampleText.Size = new System.Drawing.Size(984, 45);
            this.sampleText.TabIndex = 2;
            this.sampleText.SelectedIndexChanged += new System.EventHandler(this.sampleText_SelectedIndexChanged);
            this.sampleText.TextUpdate += new System.EventHandler(this.sampleText_TextUpdate);
            // 
            // systemFontComboBox
            // 
            this.systemFontComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemFontComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.systemFontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemFontComboBox.FormattingEnabled = true;
            this.systemFontComboBox.Location = new System.Drawing.Point(12, 39);
            this.systemFontComboBox.Name = "systemFontComboBox";
            this.systemFontComboBox.Size = new System.Drawing.Size(778, 29);
            this.systemFontComboBox.TabIndex = 3;
            this.systemFontComboBox.SelectedIndexChanged += new System.EventHandler(this.systemFontComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // sampleTextSel
            // 
            this.sampleTextSel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleTextSel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sampleTextSel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleTextSel.FormattingEnabled = true;
            this.sampleTextSel.Items.AddRange(new object[] {
            "ABCDEFG abcdefg 1234567 ()\'\"?:;,.",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "abcdefghijklmnopqrstuvwxyz",
            "0.123456789 +-*/=?%",
            "!\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~",
            "甲乙丙丁戊己庚辛壬癸",
            "壹拾贰亿叁仟肆佰伍拾陆万柒仟捌佰玖拾",
            "가나다라마바사아자차카타파하",
            "あいうえおかきくけこさしすせそたちつ",
            "アイウエオカキクケコサシスセソタチツ"});
            this.sampleTextSel.Location = new System.Drawing.Point(12, 106);
            this.sampleTextSel.Name = "sampleTextSel";
            this.sampleTextSel.Size = new System.Drawing.Size(984, 45);
            this.sampleTextSel.TabIndex = 2;
            this.sampleTextSel.SelectedIndexChanged += new System.EventHandler(this.sampleTextSel_SelectedIndexChanged);
            this.sampleTextSel.TextUpdate += new System.EventHandler(this.sampleTextSel_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "选择一个已安装的字体：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "或：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "输入文本：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "以此字体显示文本：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.systemFontComboBox);
            this.Controls.Add(this.sampleTextSel);
            this.Controls.Add(this.sampleText);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "字体预览";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox sampleText;
        private System.Windows.Forms.ComboBox systemFontComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sampleTextSel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

