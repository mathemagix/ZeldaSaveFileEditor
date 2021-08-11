
namespace HexFileDiffComparer
{
    partial class DataPointOverviewForm
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
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Decription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DescriptionEntry = new System.Windows.Forms.TextBox();
            this.AddressEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainFileListView
            // 
            this.MainFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.Value,
            this.Decription});
            this.MainFileListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainFileListView.HideSelection = false;
            this.MainFileListView.Location = new System.Drawing.Point(0, 0);
            this.MainFileListView.Name = "MainFileListView";
            this.MainFileListView.Size = new System.Drawing.Size(398, 367);
            this.MainFileListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.MainFileListView.TabIndex = 1;
            this.MainFileListView.UseCompatibleStateImageBehavior = false;
            this.MainFileListView.View = System.Windows.Forms.View.Details;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 49;
            // 
            // Decription
            // 
            this.Decription.Text = "Description";
            this.Decription.Width = 200;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(286, 411);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Save Changes";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(286, 382);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Update Manifest";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DescriptionEntry
            // 
            this.DescriptionEntry.Location = new System.Drawing.Point(88, 413);
            this.DescriptionEntry.Name = "DescriptionEntry";
            this.DescriptionEntry.Size = new System.Drawing.Size(192, 20);
            this.DescriptionEntry.TabIndex = 4;
            // 
            // AddressEntry
            // 
            this.AddressEntry.Location = new System.Drawing.Point(88, 384);
            this.AddressEntry.Name = "AddressEntry";
            this.AddressEntry.Size = new System.Drawing.Size(192, 20);
            this.AddressEntry.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // DataPointOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressEntry);
            this.Controls.Add(this.DescriptionEntry);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainFileListView);
            this.Name = "DataPointOverviewForm";
            this.Text = "Known Data Points";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListView MainFileListView;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Decription;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressEntry;
        private System.Windows.Forms.TextBox DescriptionEntry;
        private System.Windows.Forms.Button AddButton;
    }
}