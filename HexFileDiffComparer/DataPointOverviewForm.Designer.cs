
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
            this.components = new System.ComponentModel.Container();
            this.ultraTabbedMdiManager1 = new Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(this.components);
            this.MainFileListView = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Decription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraTabbedMdiManager1
            // 
            this.ultraTabbedMdiManager1.MdiParent = this;
            // 
            // MainFileListView
            // 
            this.MainFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.Value,
            this.Decription});
            this.MainFileListView.HideSelection = false;
            this.MainFileListView.Location = new System.Drawing.Point(12, 12);
            this.MainFileListView.Name = "MainFileListView";
            this.MainFileListView.Size = new System.Drawing.Size(374, 367);
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
            this.ExitButton.Location = new System.Drawing.Point(311, 385);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DataPointOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 412);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainFileListView);
            this.Name = "DataPointOverviewForm";
            this.Text = "Known Data Points";
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager ultraTabbedMdiManager1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListView MainFileListView;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Decription;
        private System.Windows.Forms.ColumnHeader Value;
    }
}