using System.Drawing.Printing;
using System.Windows.Forms;

namespace Day01_WF____SimpleNotePad
{
    public partial class Notepad : Form
    {
        string? filePathIfExist;
        public Notepad()
        {
            InitializeComponent();
            filePathIfExist = null;
        }
        private void saveAsToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (saveFileD.ShowDialog() == DialogResult.OK)
            {
                rightTxtBox.SaveFile(saveFileD.FileName);
                rightTxtBox.Clear();
                filePathIfExist = null;
            }
        }

        private void openFileToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (openFileD.ShowDialog() == DialogResult.OK)
            {
                rightTxtBox.LoadFile(openFileD.FileName);
                filePathIfExist = openFileD.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (filePathIfExist != null)
            {
                rightTxtBox.SaveFile(filePathIfExist);
                rightTxtBox.Clear();
                filePathIfExist = null;
            }
            else
            {
                saveAsToolStripMenuItem_Click(null, null);
            }

        }

        private void newFileToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (rightTxtBox.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to save the file?",
                    "Save",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
            rightTxtBox.Clear();
            filePathIfExist = null;
        }

        private void exitToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (rightTxtBox.Text != "")
            {
                DialogResult result = MessageBox.Show("File will be lost if not save!\n Do you want to save it before exit",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (fontD.ShowDialog() == DialogResult.OK)
            {
                if (rightTxtBox.SelectedText != "")
                    rightTxtBox.SelectionFont = fontD.Font;
                else
                    rightTxtBox.Font = fontD.Font;
            }
        }

        private void colorToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rightTxtBox.SelectedText != "")
                    rightTxtBox.SelectionColor = colorD.Color;
                else
                    rightTxtBox.ForeColor = colorD.Color;
            }
        }

        private void themeToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rightTxtBox.SelectedText != "")
                    rightTxtBox.SelectionBackColor = colorD.Color;
                else
                    rightTxtBox.BackColor = colorD.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple notepad application.\n" +
                "Created by: Mustafa Hegazy\n" +
                "Version: 1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rightTxtBox.Text != "")
            {
                if (printD.ShowDialog() == DialogResult.OK)
                {
                    printDoc.PrinterSettings = printD.PrinterSettings;
                    printDoc.Print();
                }
            }
            else
            {
                MessageBox.Show("Nothing to print!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string textToPrint = rightTxtBox.Text;
            Font printFont = new Font("Arial", 12);
            float yPos = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;


            string[] lines = textToPrint.Split('\n');
            foreach (string line in lines)
            {
                yPos = topMargin + (printFont.GetHeight(e.Graphics) * lines.ToList().IndexOf(line));
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            }


            e.HasMorePages = false;
        }

    }
}
