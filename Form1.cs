using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace textEdit_ad0027
{
    public partial class frmeditor : Form
    {
        public frmeditor()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile= new OpenFileDialog();
            openFile.Title = "Open a file ";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile= new SaveFileDialog();
            saveFile.Title = "Save file as ";
            saveFile.CheckFileExists = false;
            saveFile.CheckPathExists= false;
            saveFile.DefaultExt = "txt";
            saveFile.Filter = "Text Files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFile.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton.PerformClick();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripButton.PerformClick();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripButton.PerformClick();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripButton.PerformClick();
        }
  

        private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.ForeColor;
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }
    }
}
