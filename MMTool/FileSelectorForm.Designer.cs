
namespace MMTool
{
    partial class FileSelectorForm
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
            this.ocarinaSave1Button = new System.Windows.Forms.Button();
            this.ocarinaSave2Button = new System.Windows.Forms.Button();
            this.owlSave1Button = new System.Windows.Forms.Button();
            this.owlSave2Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ocarinaSave1Button
            // 
            this.ocarinaSave1Button.Location = new System.Drawing.Point(13, 13);
            this.ocarinaSave1Button.Name = "ocarinaSave1Button";
            this.ocarinaSave1Button.Size = new System.Drawing.Size(290, 50);
            this.ocarinaSave1Button.TabIndex = 0;
            this.ocarinaSave1Button.Text = "Ocarina Save File 1";
            this.ocarinaSave1Button.UseVisualStyleBackColor = true;
            this.ocarinaSave1Button.Click += new System.EventHandler(this.ocarinaSave1Button_Click);
            // 
            // ocarinaSave2Button
            // 
            this.ocarinaSave2Button.Location = new System.Drawing.Point(13, 69);
            this.ocarinaSave2Button.Name = "ocarinaSave2Button";
            this.ocarinaSave2Button.Size = new System.Drawing.Size(290, 50);
            this.ocarinaSave2Button.TabIndex = 1;
            this.ocarinaSave2Button.Text = "Ocarina Save File 2";
            this.ocarinaSave2Button.UseVisualStyleBackColor = true;
            this.ocarinaSave2Button.Click += new System.EventHandler(this.ocarinaSave2Button_Click);
            // 
            // owlSave1Button
            // 
            this.owlSave1Button.Location = new System.Drawing.Point(13, 125);
            this.owlSave1Button.Name = "owlSave1Button";
            this.owlSave1Button.Size = new System.Drawing.Size(290, 50);
            this.owlSave1Button.TabIndex = 2;
            this.owlSave1Button.Text = "Owl Save File 1";
            this.owlSave1Button.UseVisualStyleBackColor = true;
            this.owlSave1Button.Click += new System.EventHandler(this.owlSave1Button_Click);
            // 
            // owlSave2Button
            // 
            this.owlSave2Button.Location = new System.Drawing.Point(13, 181);
            this.owlSave2Button.Name = "owlSave2Button";
            this.owlSave2Button.Size = new System.Drawing.Size(290, 50);
            this.owlSave2Button.TabIndex = 3;
            this.owlSave2Button.Text = "Owl Save File 2";
            this.owlSave2Button.UseVisualStyleBackColor = true;
            this.owlSave2Button.Click += new System.EventHandler(this.owlSave2Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.owlSave2Button);
            this.Controls.Add(this.owlSave1Button);
            this.Controls.Add(this.ocarinaSave2Button);
            this.Controls.Add(this.ocarinaSave1Button);
            this.Name = "FileSelectorForm";
            this.Text = "FileSelectorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ocarinaSave1Button;
        private System.Windows.Forms.Button ocarinaSave2Button;
        private System.Windows.Forms.Button owlSave1Button;
        private System.Windows.Forms.Button owlSave2Button;
        private System.Windows.Forms.Button button1;
    }
}