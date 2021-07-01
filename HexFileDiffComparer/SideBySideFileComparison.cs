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

namespace HexFileDiffComparer
{
    public partial class SideBySideFileComparison : Form
    {
        public SideBySideFileComparison()
        {
            InitializeComponent();
            MainFileListView.FullRowSelect = true;
            SecondaryFileListView.FullRowSelect = true;
        }

        byte[] leftSideHexArray = new byte[65536];
        byte[] rightSideHexArray = new byte[65536];

        private void loadLeftSideFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            try
            {
                File.Copy(openFileDialog.FileName, "Temp/LeftSideTemp.fla",true);
                BinaryReader binaryReader = new BinaryReader(File.Open("Temp/LeftSideTemp.fla", FileMode.Open));
                leftSideHexArray = binaryReader.ReadBytes(65536);
                binaryReader.Close();
                //renumber hex array
                leftSideHexArray = renumberByteArray(leftSideHexArray);
            }
            catch(Exception exception)
            {
                //error catching
            }

            if (rightSideHexArray != null) updateListViews();
        }

        private void loadRightSideFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            try
            {
                File.Copy(openFileDialog.FileName, "Temp/RightSideTemp.fla",true);
                BinaryReader binaryReader = new BinaryReader(File.Open("Temp/RightSideTemp.fla", FileMode.Open));
                rightSideHexArray = binaryReader.ReadBytes(65536);
                binaryReader.Close();
                //renumber hex array
                rightSideHexArray = renumberByteArray(rightSideHexArray);
            }
            catch
            {
                //error catching
            }

            if (leftSideHexArray != null) updateListViews();
        }


        private void updateListViews()
        {
            MainFileListView.Items.Clear();
            SecondaryFileListView.Items.Clear();
            for (int i=0;i<leftSideHexArray.Length;i++)
            {
                if (leftSideHexArray[i] != rightSideHexArray[i])
                {
                    MainFileListView.Items.Add(new ListViewItem(new string[] { i.ToString("X4"), leftSideHexArray[i].ToString("X2"), Convert.ToString(leftSideHexArray[i], 2).PadLeft(8, '0'), leftSideHexArray[i].ToString() }));
                    SecondaryFileListView.Items.Add(new ListViewItem(new string[] { i.ToString("X4"), rightSideHexArray[i].ToString("X2"), Convert.ToString(rightSideHexArray[i], 2).PadLeft(8, '0'), rightSideHexArray[i].ToString() }));
                }
            }
        }

        private void saveLeftSideFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate));
            binaryWriter.Write(leftSideHexArray);
            binaryWriter.Close();
        }

        private void TrackAddressButton_Click(object sender, EventArgs e)
        {
            int address = 0;
            try
            {
                address = Int16.Parse(AddressEntry.Text, System.Globalization.NumberStyles.HexNumber);
            }
            catch
            {
                //error dialog
            }
            MainFileListView.Items.Add(new ListViewItem(new string[] { address.ToString("X4"), leftSideHexArray[address].ToString("X2"), Convert.ToString(leftSideHexArray[address], 2).PadLeft(8, '0'), leftSideHexArray[address].ToString() }));
            SecondaryFileListView.Items.Add(new ListViewItem(new string[] { address.ToString("X4"), rightSideHexArray[address].ToString("X2"), Convert.ToString(rightSideHexArray[address], 2).PadLeft(8, '0'), rightSideHexArray[address].ToString() }));

            MainFileListView.Sort();
            SecondaryFileListView.Sort();
        }

        private void WriteValueButton_Click(object sender, EventArgs e)
        {
            int address = 0;
            try
            {
                address = Int16.Parse(AddressEntry.Text, System.Globalization.NumberStyles.HexNumber);
            }
            catch
            {
                //error dialog
            }

            byte value = 0;
            try
            {
                value = byte.Parse(ValueEntry.Text, System.Globalization.NumberStyles.HexNumber);
            }
            catch
            {
                //error dialog
            }

            leftSideHexArray[address] = value;

            MainFileListView.Items.Add(new ListViewItem(new string[] { address.ToString("X4"), leftSideHexArray[address].ToString("X2"), Convert.ToString(leftSideHexArray[address], 2).PadLeft(8, '0'), leftSideHexArray[address].ToString() }));
            SecondaryFileListView.Items.Add(new ListViewItem(new string[] { address.ToString("X4"), rightSideHexArray[address].ToString("X2"), Convert.ToString(rightSideHexArray[address], 2).PadLeft(8, '0'), rightSideHexArray[address].ToString() }));


            MainFileListView.Sort();
            SecondaryFileListView.Sort();
        }

        private byte[] renumberByteArray(byte[] byteArray)
        {
            byte[] renumberedArray = new byte[65536];
            for (int i=0; i<byteArray.Length/4; i++)
            {
                renumberedArray[4 * i] = byteArray[(4 * i) + 3];
                renumberedArray[(4 * i) + 1] = byteArray[(4 * i) + 2];
                renumberedArray[(4 * i) + 2] = byteArray[(4 * i) + 1];
                renumberedArray[(4 * i) + 3] = byteArray[4 * i];
            }
            return renumberedArray;
        }

        private void MainFileListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i=0;i<MainFileListView.Items.Count;i++)
            {
                SecondaryFileListView.Items[i].Selected = MainFileListView.Items[i].Selected;
            }
        }

        private void SecondaryFileListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < MainFileListView.Items.Count; i++)
            {
                MainFileListView.Items[i].Selected = SecondaryFileListView.Items[i].Selected;
            }
        }
    }
}
