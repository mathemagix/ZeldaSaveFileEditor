using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMTool
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void compareButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Program Files (x86)\\Project64 2.3\\Save";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == null)
            {
                MessageBox.Show("No File Selected");
                this.Show();
                return;
            }
            byte[] fullByteArray = openFile(openFileDialog.FileName);
            FileSelectorForm fileSelector = new FileSelectorForm(fullByteArray);
            fileSelector.ShowDialog();
            if (fileSelector.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("No File Selected");
                this.Show();
                return;
            }
            int offset = fileSelector.Offset;
            FileEditorForm fileEditor = new FileEditorForm(openFileDialog.FileName, fullByteArray, offset);
            fileEditor.ShowDialog();
            this.Show();
        }

        private void graphicalEditor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private byte[] openFile(string filename)
        {
            BinaryReader binaryReader = new BinaryReader(File.Open(filename, FileMode.Open));
            byte[] byteArray = binaryReader.ReadBytes(99999);
            binaryReader.Close();
            return renumberByteArray(byteArray);
        }


        private byte[] renumberByteArray(byte[] byteArray)
        {
            byte[] renumberedArray = new byte[byteArray.Length];
            for (int i = 0; i < byteArray.Length / 4; i++)
            {
                renumberedArray[4 * i] = byteArray[(4 * i) + 3];
                renumberedArray[(4 * i) + 1] = byteArray[(4 * i) + 2];
                renumberedArray[(4 * i) + 2] = byteArray[(4 * i) + 1];
                renumberedArray[(4 * i) + 3] = byteArray[4 * i];
            }
            return renumberedArray;
        }
    }
}
