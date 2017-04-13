namespace Ex2
{
    partial class GradeForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.marksTextbox = new System.Windows.Forms.TextBox();
            this.marksLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(81, 39);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 59);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Letter Grade to Memory";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // marksTextbox
            // 
            this.marksTextbox.Location = new System.Drawing.Point(115, 134);
            this.marksTextbox.Name = "marksTextbox";
            this.marksTextbox.Size = new System.Drawing.Size(100, 20);
            this.marksTextbox.TabIndex = 1;
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Location = new System.Drawing.Point(46, 137);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(36, 13);
            this.marksLabel.TabIndex = 2;
            this.marksLabel.Text = "Marks";
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.marksLabel);
            this.Controls.Add(this.marksTextbox);
            this.Controls.Add(this.addButton);
            this.Name = "GradeForm";
            this.Text = "Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox marksTextbox;
        private System.Windows.Forms.Label marksLabel;
    }
}

