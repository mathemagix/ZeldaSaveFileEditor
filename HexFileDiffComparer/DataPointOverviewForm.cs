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
    public partial class DataPointOverviewForm : Form
    {
        public DataPointOverviewForm()
        {
            InitializeComponent();
            importManifest();

        }

        byte[] byteArray;
        string[] stringArray;

        public DataPointOverviewForm(byte[] saveFileBytes, string[] knownDataPoints)
        {
            InitializeComponent();

            byteArray = saveFileBytes;
            stringArray = knownDataPoints;

            updateListView();
        }

        private void updateListView()
        {
            MainFileListView.Items.Clear();
            for (int i = 0; i < 8192; i++)
            {
                if (stringArray[i] != null)
                {
                    MainFileListView.Items.Add(new ListViewItem(new string[] { i.ToString("X4"), byteArray[i].ToString("X2"), stringArray[i].ToString() })); ;
                }
            }
        }
        private void importManifest()
        {
            StreamReader streamReader;
            try
            {
                streamReader = new StreamReader("Temp/TempManifest.csv");
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
                stringArray[int.Parse(addressString)] = descriptionString;
            }
        }

        private void exportManifest()
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("Temp/TempManifest.csv");
                for (int i = 0; i<8192; i++)
                {
                    if (stringArray[i] != null)
                    streamWriter.WriteLine(i.ToString().PadLeft(4, '0') + "," + stringArray[i]);
                }
                streamWriter.Close();
            }
            catch
            {
                //error handling
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            exportManifest();
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int address = 0;
            try
            {
                address = int.Parse(AddressEntry.Text);
            }
            catch
            {
                return;
            }

            stringArray[address] = DescriptionEntry.Text;
            updateListView();
        }
    }
}
