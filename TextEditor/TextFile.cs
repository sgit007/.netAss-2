using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextFile : Form
    {
        string filename = "";
        float NewSize;
        private void PopulateFontSizes() //populate the combo box
        {
            for (int i = 1; i <= 75; i++)
            {
                toolStripComboBox1.Items.Add(i);
            }

            toolStripComboBox1.SelectedIndex = 11;
        }

        public TextFile()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton.PerformClick();
        }
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogue1 = new OpenFileDialog(); //open a file dialog box
            openFileDialogue1.Title = "Open a text file";
            openFileDialogue1.Filter = "Text Files(*.rtf) | *.rtf | All Files (*.*) | *.*";
            DialogResult dr = openFileDialogue1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filename = openFileDialogue1.FileName;
                MessageBox.Show("The field selected was: " + filename);

            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton.PerformClick();
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(filename == "")
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else
            {
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton.PerformClick();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog(); //save a file
            saveFile.Filter = "Text Files(*.rtf) | *.rtf | All Files (*.*) | *.*";
            DialogResult dr = saveFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripButton.PerformClick();
        }
        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripButton.PerformClick();
        }
        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripButton.PerformClick();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
            float.TryParse(toolStripComboBox1.SelectedItem.ToString(), out NewSize);
            Font NewFont = new Font(richTextBox1.Name, NewSize, richTextBox1.SelectionFont.Style);
            richTextBox1.SelectionFont = NewFont;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Font BoldFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.SizeInPoints, FontStyle.Bold);
            Font RegularFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.SizeInPoints, FontStyle.Regular);

            if (richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
            }

            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Font ItalicFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.SizeInPoints, FontStyle.Italic);
            Font RegularFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.SizeInPoints, FontStyle.Regular);

            if (richTextBox1.SelectionFont.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
            }

            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font UnderlineFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.SizeInPoints, FontStyle.Underline);
            Font RegularFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.SizeInPoints, FontStyle.Regular);

            if (richTextBox1.SelectionFont.Underline)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
            }

            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
            }
        }
    }
}
