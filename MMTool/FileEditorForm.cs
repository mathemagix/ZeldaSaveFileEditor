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
    public partial class FileEditorForm : Form
    {
        public FileEditorForm()
        {
            InitializeComponent();
            this.AddressSeeker.Hexadecimal = true;
        }

        public FileEditorForm(string filename, byte[] fullSaveFile, int offset)
        {
            InitializeComponent();
            this.AddressSeeker.Hexadecimal = true;
            this.offset = offset;
            this.fullSaveFile = fullSaveFile;
            this.filename = filename;
            updateListView();
        }

        private string filename = "";
        private int offset = 0x0000;
        private byte[] fullSaveFile = new byte[0x10000];
        const int slotSize = 0x2000;

        private void updateListView()
        {
            if (MainFileListView.Items.Count != 0) MainFileListView.Items.Clear();
            for (int i=offset; i < offset + slotSize; i++)
            {
                ListViewItem item = new ListViewItem(new string[] { (i - offset).ToString("X4"), fullSaveFile[i].ToString("X2"), Convert.ToString(fullSaveFile[i], 2).PadLeft(8, '0'), fullSaveFile[i].ToString() });
                MainFileListView.Items.Add(item);
            }
        }

        private void MainFileListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MainFileListView.SelectedItems.Count != 0) AddressSeeker.Value = MainFileListView.SelectedItems[0].Index;
            updatePointValueIndicators(fullSaveFile[(int)AddressSeeker.Value + offset]);
        }

        private void AddressSeeker_ValueChanged(object sender, EventArgs e)
        {
            MainFileListView.SelectedItems.Clear();
            MainFileListView.Items[(int)AddressSeeker.Value].Selected = true;
            MainFileListView.Items[(int)AddressSeeker.Value].EnsureVisible();
            MainFileListView.Select();
            updatePointValueIndicators(fullSaveFile[(int)AddressSeeker.Value + offset]);
        }

        private void updatePointValueIndicators(int value)
        {
            HexValueInput.Value = value;
            IntegerLabel.Text = "Integer Value: " + value.ToString();
            BinaryLabel.Text = "Binary Value: " + Convert.ToString(value, 2).PadLeft(8, '0');
        }
        private void FileEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            fullSaveFile[offset + (int)AddressSeeker.Value] = (byte)HexValueInput.Value;
            fullSaveFile[offset + 0x2000 + (int)AddressSeeker.Value] = (byte)HexValueInput.Value;
            ListViewItem item = new ListViewItem(new string[] { ((int)AddressSeeker.Value).ToString("X4"), ((int)HexValueInput.Value).ToString("X2"), Convert.ToString((int)HexValueInput.Value, 2).PadLeft(8, '0'), HexValueInput.Value.ToString() });
            MainFileListView.Items[offset + (int)AddressSeeker.Value] = item;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "C:\\Program Files(x86)\\Project64 2.3\\Save";
            saveFileDialog.ShowDialog();

            int checksum = calculateChecksum();
            fullSaveFile[offset + 0x100B] = Convert.ToByte(checksum % 256);
            fullSaveFile[offset + 0x300B] = Convert.ToByte(checksum % 256);
            fullSaveFile[offset + 0x100A] = Convert.ToByte((checksum - (checksum % 256)) / 256);
            fullSaveFile[offset + 0x300A] = Convert.ToByte((checksum - (checksum % 256)) / 256);
            fullSaveFile = renumberByteArray(fullSaveFile);

            BinaryWriter binaryWriter = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate));
            binaryWriter.Write(fullSaveFile);
            binaryWriter.Close();
            this.Close();
        }
        private int calculateChecksum()
        {
            int checkSum = 0;
            //start with sum of all registers
            for (int i = offset; i < offset + 0x100A; i++)
            {
                checkSum += fullSaveFile[i];
            }

            return checkSum;
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

        private void HexValueInput_ValueChanged(object sender, EventArgs e)
        {
            updatePointValueIndicators((int)HexValueInput.Value);
        }
    }
}
