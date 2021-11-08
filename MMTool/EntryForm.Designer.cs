
namespace MMTool
{
    partial class EntryForm
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
            this.compareButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.graphicalEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(12, 12);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(291, 50);
            this.compareButton.TabIndex = 0;
            this.compareButton.Text = "Compare Two Binary Save Files";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(12, 68);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(291, 50);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit A Binary Save File";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // graphicalEditor
            // 
            this.graphicalEditor.Location = new System.Drawing.Point(12, 124);
            this.graphicalEditor.Name = "graphicalEditor";
            this.graphicalEditor.Size = new System.Drawing.Size(291, 50);
            this.graphicalEditor.TabIndex = 2;
            this.graphicalEditor.Text = "Graphical Editor (Beta)";
            this.graphicalEditor.UseVisualStyleBackColor = true;
            this.graphicalEditor.Click += new System.EventHandler(this.graphicalEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 183);
            this.Controls.Add(this.graphicalEditor);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.compareButton);
            this.Name = "Form1";
            this.Text = "Majora\'s Mask Save File Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button graphicalEditor;
    }
}

