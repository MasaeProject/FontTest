using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontTest
{
    public partial class Form1 : Form
    {
        private LoadFont loadFont = new LoadFont();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                systemFontComboBox.Items.Add(font.Name);
                systemFontComboBox.Text = sampleText.Font.Name;
            }
            foreach (string text in sampleTextSel.Items)
            {
                sampleText.Items.Add(text);
            }
            sampleTextSel.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Font files (*.ttf)|*.ttf|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fontFilePath = openFileDialog.FileName;
                    Exception err = loadFont.LoadFontFromFile(fontFilePath);
                    if (err != null)
                    {
                        MessageBox.Show(err.Message, "加载字体失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    sampleText.Font = loadFont.CurrentFont;
                    label1.Text = loadFont.FontInfo();
                }
            }
        }

        private void systemFontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = systemFontComboBox.SelectedItem.ToString();
            loadFont.CurrentFont = new Font(selectedFontName, 24);
            sampleText.Font = loadFont.CurrentFont;
            label1.Text = loadFont.FontInfo();
        }

        private void sampleTextSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            sampleText.SelectedIndex = sampleTextSel.SelectedIndex;
        }

        private void sampleText_SelectedIndexChanged(object sender, EventArgs e)
        {
            sampleTextSel.SelectedIndex = sampleText.SelectedIndex;
        }

        private void sampleTextSel_TextUpdate(object sender, EventArgs e)
        {
            sampleText.Text = sampleTextSel.Text;
        }

        private void sampleText_TextUpdate(object sender, EventArgs e)
        {
            sampleTextSel.Text = sampleText.Text;
        }
    }
}
