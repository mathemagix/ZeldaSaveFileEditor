using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMTool
{
    public partial class FileSelectorForm : Form
    {
        public FileSelectorForm()
        {
            InitializeComponent();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Program Files (x86)\\Project64 2.3\\Save";
            openFileDialog.ShowDialog();

        }

        public int Offset = 0x0000;
        public byte[] saveFile = new byte[0x2000];

        public FileSelectorForm(string fileName)
        {
            InitializeComponent();
        }

        public FileSelectorForm(byte[] fullFileArray)
        {
            InitializeComponent();
            //custom code here to pull a few overview points to label the files
        }

        private void ocarinaSave1Button_Click(object sender, EventArgs e)
        {
            Offset = 0x0000;
            closeForm();
        }

        private void ocarinaSave2Button_Click(object sender, EventArgs e)
        {
            Offset = 0x4000;
            closeForm();
        }

        private void owlSave1Button_Click(object sender, EventArgs e)
        {
            Offset = 0x8000;
            closeForm();
        }

        private void owlSave2Button_Click(object sender, EventArgs e)
        {
            Offset = 0xC000;
            closeForm();
        }

        private void closeForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
