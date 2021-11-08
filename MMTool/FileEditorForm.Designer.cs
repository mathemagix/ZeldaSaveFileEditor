
namespace MMTool
{
    partial class FileEditorForm
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
            this.MainFileListView = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HexValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BinaryValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IntegerValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressSeeker = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HexValueInput = new System.Windows.Forms.NumericUpDown();
            this.IntegerLabel = new System.Windows.Forms.Label();
            this.BinaryLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddressSeeker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HexValueInput)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFileListView
            // 
            this.MainFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.HexValue,
            this.BinaryValue,
            this.IntegerValue});
            this.MainFileListView.HideSelection = false;
            this.MainFileListView.Location = new System.Drawing.Point(12, 12);
            this.MainFileListView.MultiSelect = false;
            this.MainFileListView.Name = "MainFileListView";
            this.MainFileListView.Size = new System.Drawing.Size(368, 426);
            this.MainFileListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.MainFileListView.TabIndex = 1;
            this.MainFileListView.UseCompatibleStateImageBehavior = false;
            this.MainFileListView.View = System.Windows.Forms.View.Details;
            this.MainFileListView.SelectedIndexChanged += new System.EventHandler(this.MainFileListView_SelectedIndexChanged);
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 64;
            // 
            // HexValue
            // 
            this.HexValue.Text = "Hex Value";
            this.HexValue.Width = 82;
            // 
            // BinaryValue
            // 
            this.BinaryValue.Text = "Binary Value";
            this.BinaryValue.Width = 122;
            // 
            // IntegerValue
            // 
            this.IntegerValue.Text = "Integer Value";
            this.IntegerValue.Width = 96;
            // 
            // AddressSeeker
            // 
            this.AddressSeeker.Hexadecimal = true;
            this.AddressSeeker.Location = new System.Drawing.Point(474, 11);
            this.AddressSeeker.Maximum = new decimal(new int[] {
            8191,
            0,
            0,
            0});
            this.AddressSeeker.Name = "AddressSeeker";
            this.AddressSeeker.Size = new System.Drawing.Size(120, 20);
            this.AddressSeeker.TabIndex = 2;
            this.AddressSeeker.ValueChanged += new System.EventHandler(this.AddressSeeker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(386, 114);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(208, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update Data Point";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hex Value:";
            // 
            // HexValueInput
            // 
            this.HexValueInput.Hexadecimal = true;
            this.HexValueInput.Location = new System.Drawing.Point(474, 41);
            this.HexValueInput.Maximum = new decimal(new int[] {
            8191,
            0,
            0,
            0});
            this.HexValueInput.Name = "HexValueInput";
            this.HexValueInput.Size = new System.Drawing.Size(120, 20);
            this.HexValueInput.TabIndex = 6;
            this.HexValueInput.ValueChanged += new System.EventHandler(this.HexValueInput_ValueChanged);
            // 
            // IntegerLabel
            // 
            this.IntegerLabel.AutoSize = true;
            this.IntegerLabel.Location = new System.Drawing.Point(386, 74);
            this.IntegerLabel.Name = "IntegerLabel";
            this.IntegerLabel.Size = new System.Drawing.Size(73, 13);
            this.IntegerLabel.TabIndex = 7;
            this.IntegerLabel.Text = "Integer Value:";
            // 
            // BinaryLabel
            // 
            this.BinaryLabel.AutoSize = true;
            this.BinaryLabel.Location = new System.Drawing.Point(386, 98);
            this.BinaryLabel.Name = "BinaryLabel";
            this.BinaryLabel.Size = new System.Drawing.Size(69, 13);
            this.BinaryLabel.TabIndex = 8;
            this.BinaryLabel.Text = "Binary Value:";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(390, 415);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(208, 23);
            this.ExportButton.TabIndex = 9;
            this.ExportButton.Text = "Export Save File";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // FileEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.BinaryLabel);
            this.Controls.Add(this.IntegerLabel);
            this.Controls.Add(this.HexValueInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressSeeker);
            this.Controls.Add(this.MainFileListView);
            this.Name = "FileEditorForm";
            this.Text = "FileEditorForm";
            this.Load += new System.EventHandler(this.FileEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddressSeeker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HexValueInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MainFileListView;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader HexValue;
        private System.Windows.Forms.ColumnHeader BinaryValue;
        private System.Windows.Forms.ColumnHeader IntegerValue;
        private System.Windows.Forms.NumericUpDown AddressSeeker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown HexValueInput;
        private System.Windows.Forms.Label IntegerLabel;
        private System.Windows.Forms.Label BinaryLabel;
        private System.Windows.Forms.Button ExportButton;
    }
}