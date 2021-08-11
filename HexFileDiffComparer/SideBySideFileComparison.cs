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
            if (!Directory.Exists("Temp"))
                Directory.CreateDirectory("Temp");
            if (File.Exists("Temp/TempManifest.csv"))
                importManifest("Temp/TempManifest.csv");
            else
            {
                initializeKnownDataPoints();
                exportManifest("Temp/TempManifest.csv");
            }
        }

        byte[] leftSideHexArray = new byte[100000];
        byte[] rightSideHexArray = new byte[100000];
        string[] knownDataPoints = new string[8192];


        private void initializeKnownDataPoints()
        {
            knownDataPoints[0x2B] = "Number of times saved";
            knownDataPoints[0x2C] = "File Name Character 1";
            knownDataPoints[0x2D] = "File Name Character 2";
            knownDataPoints[0x2E] = "File Name Character 3";
            knownDataPoints[0x2F] = "File Name Character 4";
            knownDataPoints[0x30] = "File Name Character 5";
            knownDataPoints[0x31] = "File Name Character 6";
            knownDataPoints[0x32] = "File Name Character 7";
            knownDataPoints[0x33] = "File Name Character 8";
            knownDataPoints[0x34] = "Unknown save delta. Changes appear random";
            knownDataPoints[0xFFB] = "Bomber's Password Digit 1";
            knownDataPoints[0xFFC] = "Bomber's Password Digit 2";
            knownDataPoints[0xFFD] = "Bomber's Password Digit 3";
            knownDataPoints[0xFFE] = "Bomber's Password Digit 4";
            knownDataPoints[0xFFF] = "Bomber's Password Digit 5";
            knownDataPoints[0x100B] = "Unknown save delta. Changes appear random";

        }

        private void importManifest(string filename)
        {
            StreamReader streamReader;
            try
            {
                streamReader = new StreamReader(filename);
                while (!streamReader.EndOfStream)
                {
                    addLineToInteralArray(streamReader.ReadLine());
                }
                streamReader.Close();
            }
            catch
            {
                //error handling
            }
        }

        private void addLineToInteralArray(string line)
        {
            if (line.Length > 5)
            {
                string addressString = line.Substring(0, 4);
                string descriptionString = line.Substring(5, line.Length - 5);
                knownDataPoints[int.Parse(addressString)] = descriptionString;
            }
        }

        private void exportManifest(string filename)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filename);
                for (int i = 0; i < 8192; i++)
                {
                    if (knownDataPoints[i] != null)
                    streamWriter.WriteLine(i.ToString().PadLeft(4, '0') + "," + knownDataPoints[i]);
                }
                streamWriter.Close();
            }
            catch
            {
                //error handling
            }
        }

        private void loadLeftSideFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            try
            {
                File.Copy(openFileDialog.FileName, "Temp/LeftSideTemp.fla",true);
                BinaryReader binaryReader = new BinaryReader(File.Open("Temp/LeftSideTemp.fla", FileMode.Open));
                leftSideHexArray = binaryReader.ReadBytes(99999);
                binaryReader.Close();
                //renumber hex array
                leftSideHexArray = renumberByteArray(leftSideHexArray);
            }
            catch(Exception exception)
            {
                //error catching
            }

            MainFileGroupBox.Text = "Main File - " + DateTime.Now.ToString("HH-mm-ss");
            if (rightSideHexArray != null) updateListViews();
        }

        private void loadRightSideFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            try
            {
                File.Copy(openFileDialog.FileName, "Temp/RightSideTemp.fla",true);
                BinaryReader binaryReader = new BinaryReader(File.Open("Temp/RightSideTemp.fla", FileMode.Open));
                rightSideHexArray = binaryReader.ReadBytes(99999);
                binaryReader.Close();
                //renumber hex array
                rightSideHexArray = renumberByteArray(rightSideHexArray);
            }
            catch
            {
                //error catching
            }

            SecondaryFileGroupBox.Text = "Secondary File - " + DateTime.Now.ToString("HH-mm-ss"); 
            if (leftSideHexArray != null) updateListViews();
        }


        private void updateListViews()
        {
            MainFileListView.Items.Clear();
            SecondaryFileListView.Items.Clear();
            
            for (int i=0;i<0x2000;i++)
            {
                if (leftSideHexArray[i] != rightSideHexArray[i] && knownDataPoints[i % 8192] == null)
                {
                    MainFileListView.Items.Add(new ListViewItem(new string[] { i.ToString("X4"), leftSideHexArray[i].ToString("X2"), Convert.ToString(leftSideHexArray[i], 2).PadLeft(8, '0'), leftSideHexArray[i].ToString() }));
                    SecondaryFileListView.Items.Add(new ListViewItem(new string[] { i.ToString("X4"), rightSideHexArray[i].ToString("X2"), Convert.ToString(rightSideHexArray[i], 2).PadLeft(8, '0'), rightSideHexArray[i].ToString() }));
                }
            }
            
            
            for (int i = 0x9000; i < 0xA000; i++)
            {
                if (leftSideHexArray[i] != rightSideHexArray[i] && knownDataPoints[i % 8192] == null)
                {
                    MainFileListView.Items.Add(new ListViewItem(new string[] { i.ToString("X4"), leftSideHexArray[i].ToString("X2"), Convert.ToString(leftSideHexArray[i], 2).PadLeft(8, '0'), leftSideHexArray[i].ToString() }));
                    SecondaryFileListView.Items.Add(new ListViewItem(new string[] { i.ToString("X4"), rightSideHexArray[i].ToString("X2"), Convert.ToString(rightSideHexArray[i], 2).PadLeft(8, '0'), rightSideHexArray[i].ToString() }));
                }
            }
        }

        private int calculateChecksum()
        {
            int checkSum = 0;
            //start with sum of all registers
            for (int i = 0; i < 0x100A; i++)
            {
                checkSum += leftSideHexArray[i];
            }

            //divide by two
            //TO-DO we should really be looking at a chunk of 8192 registers at a time and copying things. will save a lot of PITA
            //checkSum = checkSum / 2;
            
            return checkSum;
        }

        private void saveLeftSideFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            //File.Delete(saveFileDialog.FileName);
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate));
            byte[] saveFileArray = leftSideHexArray;
            int checksum = calculateChecksum();
            saveFileArray[0x100B] = Convert.ToByte(checksum % 256);
            saveFileArray[0x300B] = Convert.ToByte(checksum % 256);
            saveFileArray[0x100A] = Convert.ToByte((checksum - (checksum%256) )/256);
            saveFileArray[0x300A] = Convert.ToByte((checksum - (checksum % 256)) / 256);

            saveFileArray = renumberByteArray(saveFileArray);
            binaryWriter.Write(saveFileArray);
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
            byte[] renumberedArray = new byte[byteArray.Length];
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

        private void knownDataPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataPointOverviewForm knownDataPointsForm = new DataPointOverviewForm(leftSideHexArray,knownDataPoints);
            knownDataPointsForm.Show();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            importManifest(openFileDialog.FileName);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            exportManifest(saveFileDialog.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateChecksum();
        }
    }
}
