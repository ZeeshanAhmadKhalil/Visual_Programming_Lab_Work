using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace notepad_top_options
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_main.Clear();//New
        }
        private void openCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();//open
            StreamReader open_file = new StreamReader(openFileDialog1.FileName);
            text_main.Text=open_file.ReadToEnd();
            open_file.Close();
        }
        private void openCtrlOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();//save
            StreamWriter save_file = new StreamWriter(saveFileDialog1.FileName);
            save_file.WriteLine(text_main.Text);
            save_file.Close();
        }
        private void undoCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_main.Undo();
        }
        private void redoCtrlYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_main.Undo();
        }
        private void cutCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_main.Cut();
        }
        private void copyCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_main.Copy();
        }
        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_main.Paste();
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_main.SelectAll();
        }

        private void printCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument prntDoc =
                new System.Drawing.Printing.PrintDocument();
        }

        private void openCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();//Save as
            System.IO.StreamWriter SaveFile =
                new System.IO.StreamWriter(saveFileDialog1.FileName);
            SaveFile.WriteLine(text_main.Text);
            SaveFile.Close();
        }

        

        
        //private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    System.Drawing.Printing.PrintDocument prntDoc = new System.Drawing.Printing.PrintDocument();
        //    PrintPreviewDialog preview = new PrintPreviewDialog();
        //    prntDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prntDoc_PrintPage);
        //    preview.Document = prntDoc;
        //    if (preview.ShowDialog(this) == DialogResult.OK)
        //    {
        //        prntDoc.Print();
        //    }

        //}
    }
}
