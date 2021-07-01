
namespace HexFileDiffComparer
{
    partial class SideBySideFileComparison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainFileListView = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HexValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BinaryValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IntegerValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SecondaryFileListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLeftSideFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRightSideFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRightSideFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFileGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueEntry = new System.Windows.Forms.TextBox();
            this.TrackAddressButton = new System.Windows.Forms.Button();
            this.SecondaryFileGroupBox = new System.Windows.Forms.GroupBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.WriteValueButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ultraTabbedMdiManager1 = new Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knownDataPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MainFileGroupBox.SuspendLayout();
            this.SecondaryFileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = "C:\\Program Files (x86)\\Project64 2.3\\Save";
            // 
            // MainFileListView
            // 
            this.MainFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.HexValue,
            this.BinaryValue,
            this.IntegerValue});
            this.MainFileListView.HideSelection = false;
            this.MainFileListView.Location = new System.Drawing.Point(6, 19);
            this.MainFileListView.Name = "MainFileListView";
            this.MainFileListView.Size = new System.Drawing.Size(368, 367);
            this.MainFileListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.MainFileListView.TabIndex = 0;
            this.MainFileListView.UseCompatibleStateImageBehavior = false;
            this.MainFileListView.View = System.Windows.Forms.View.Details;
            this.MainFileListView.SelectedIndexChanged += new System.EventHandler(this.MainFileListView_SelectedIndexChanged);
            // 
            // Address
            // 
            this.Address.Text = "Address";
            // 
            // HexValue
            // 
            this.HexValue.Text = "Hex Value";
            this.HexValue.Width = 63;
            // 
            // BinaryValue
            // 
            this.BinaryValue.Text = "Binary Value";
            this.BinaryValue.Width = 75;
            // 
            // IntegerValue
            // 
            this.IntegerValue.Text = "Integer Value";
            this.IntegerValue.Width = 78;
            // 
            // SecondaryFileListView
            // 
            this.SecondaryFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.SecondaryFileListView.HideSelection = false;
            this.SecondaryFileListView.Location = new System.Drawing.Point(6, 19);
            this.SecondaryFileListView.Name = "SecondaryFileListView";
            this.SecondaryFileListView.Size = new System.Drawing.Size(368, 367);
            this.SecondaryFileListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.SecondaryFileListView.TabIndex = 1;
            this.SecondaryFileListView.UseCompatibleStateImageBehavior = false;
            this.SecondaryFileListView.View = System.Windows.Forms.View.Details;
            this.SecondaryFileListView.SelectedIndexChanged += new System.EventHandler(this.SecondaryFileListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Address";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hex Value";
            this.columnHeader2.Width = 63;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Binary Value";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Integer Value";
            this.columnHeader4.Width = 78;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadLeftSideFileToolStripMenuItem,
            this.loadRightSideFileToolStripMenuItem,
            this.loadRightSideFileToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadLeftSideFileToolStripMenuItem
            // 
            this.loadLeftSideFileToolStripMenuItem.Name = "loadLeftSideFileToolStripMenuItem";
            this.loadLeftSideFileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadLeftSideFileToolStripMenuItem.Text = "Load Left-Side File";
            this.loadLeftSideFileToolStripMenuItem.Click += new System.EventHandler(this.loadLeftSideFileToolStripMenuItem_Click);
            // 
            // loadRightSideFileToolStripMenuItem
            // 
            this.loadRightSideFileToolStripMenuItem.Name = "loadRightSideFileToolStripMenuItem";
            this.loadRightSideFileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadRightSideFileToolStripMenuItem.Text = "Save Left-Side File";
            this.loadRightSideFileToolStripMenuItem.Click += new System.EventHandler(this.saveLeftSideFileToolStripMenuItem_Click);
            // 
            // loadRightSideFileToolStripMenuItem1
            // 
            this.loadRightSideFileToolStripMenuItem1.Name = "loadRightSideFileToolStripMenuItem1";
            this.loadRightSideFileToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.loadRightSideFileToolStripMenuItem1.Text = "Load Right-Side File";
            this.loadRightSideFileToolStripMenuItem1.Click += new System.EventHandler(this.loadRightSideFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MainFileGroupBox
            // 
            this.MainFileGroupBox.Controls.Add(this.MainFileListView);
            this.MainFileGroupBox.Location = new System.Drawing.Point(12, 27);
            this.MainFileGroupBox.Name = "MainFileGroupBox";
            this.MainFileGroupBox.Size = new System.Drawing.Size(380, 392);
            this.MainFileGroupBox.TabIndex = 4;
            this.MainFileGroupBox.TabStop = false;
            this.MainFileGroupBox.Text = "Main File";
            // 
            // AddressEntry
            // 
            this.AddressEntry.Location = new System.Drawing.Point(63, 425);
            this.AddressEntry.Name = "AddressEntry";
            this.AddressEntry.Size = new System.Drawing.Size(100, 20);
            this.AddressEntry.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Value";
            // 
            // ValueEntry
            // 
            this.ValueEntry.Location = new System.Drawing.Point(310, 425);
            this.ValueEntry.Name = "ValueEntry";
            this.ValueEntry.Size = new System.Drawing.Size(100, 20);
            this.ValueEntry.TabIndex = 2;
            // 
            // TrackAddressButton
            // 
            this.TrackAddressButton.Location = new System.Drawing.Point(169, 423);
            this.TrackAddressButton.Name = "TrackAddressButton";
            this.TrackAddressButton.Size = new System.Drawing.Size(95, 23);
            this.TrackAddressButton.TabIndex = 1;
            this.TrackAddressButton.Text = "Track Address";
            this.TrackAddressButton.UseVisualStyleBackColor = true;
            this.TrackAddressButton.Click += new System.EventHandler(this.TrackAddressButton_Click);
            // 
            // SecondaryFileGroupBox
            // 
            this.SecondaryFileGroupBox.Controls.Add(this.SecondaryFileListView);
            this.SecondaryFileGroupBox.Location = new System.Drawing.Point(403, 27);
            this.SecondaryFileGroupBox.Name = "SecondaryFileGroupBox";
            this.SecondaryFileGroupBox.Size = new System.Drawing.Size(380, 392);
            this.SecondaryFileGroupBox.TabIndex = 5;
            this.SecondaryFileGroupBox.TabStop = false;
            this.SecondaryFileGroupBox.Text = "Secondary File";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.InitialDirectory = "C:\\Program Files (x86)\\Project64 2.3\\Save";
            // 
            // WriteValueButton
            // 
            this.WriteValueButton.Location = new System.Drawing.Point(416, 423);
            this.WriteValueButton.Name = "WriteValueButton";
            this.WriteValueButton.Size = new System.Drawing.Size(95, 23);
            this.WriteValueButton.TabIndex = 6;
            this.WriteValueButton.Text = "Write Value";
            this.WriteValueButton.UseVisualStyleBackColor = true;
            this.WriteValueButton.Click += new System.EventHandler(this.WriteValueButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "© Mathemagix Software Consulting 2021";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ultraTabbedMdiManager1
            // 
            this.ultraTabbedMdiManager1.MdiParent = this;
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knownDataPointsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // knownDataPointsToolStripMenuItem
            // 
            this.knownDataPointsToolStripMenuItem.Name = "knownDataPointsToolStripMenuItem";
            this.knownDataPointsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.knownDataPointsToolStripMenuItem.Text = "Known Data Points";
            this.knownDataPointsToolStripMenuItem.Click += new System.EventHandler(this.knownDataPointsToolStripMenuItem_Click);
            // 
            // SideBySideFileComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WriteValueButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddressEntry);
            this.Controls.Add(this.TrackAddressButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondaryFileGroupBox);
            this.Controls.Add(this.ValueEntry);
            this.Controls.Add(this.MainFileGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SideBySideFileComparison";
            this.Text = "ByteCompare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainFileGroupBox.ResumeLayout(false);
            this.SecondaryFileGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListView MainFileListView;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader HexValue;
        private System.Windows.Forms.ColumnHeader BinaryValue;
        private System.Windows.Forms.ColumnHeader IntegerValue;
        private System.Windows.Forms.ListView SecondaryFileListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLeftSideFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRightSideFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRightSideFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox MainFileGroupBox;
        private System.Windows.Forms.GroupBox SecondaryFileGroupBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox AddressEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValueEntry;
        private System.Windows.Forms.Button TrackAddressButton;
        private System.Windows.Forms.Button WriteValueButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager ultraTabbedMdiManager1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knownDataPointsToolStripMenuItem;
    }
}

