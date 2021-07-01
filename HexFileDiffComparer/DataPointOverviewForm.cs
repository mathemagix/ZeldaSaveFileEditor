using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        public DataPointOverviewForm(byte[] saveFileBytes, string[] knownDataPoints)
        {
            InitializeComponent();

            for (int i = 0; i < 8192; i++)
            {
                if (knownDataPoints[i] != null)
                {
                    MainFileListView.Items.Add(new ListViewItem(new string[] { i.ToString("X4"), saveFileBytes[i].ToString("X2"), knownDataPoints[i].ToString() })); ;
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
