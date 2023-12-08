namespace WinFormsApp2
{
    partial class frm_color
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_color));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.choicesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreboardListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            resources.ApplyResources(this.scoreLabel, "scoreLabel");
            this.scoreLabel.Name = "scoreLabel";
            // 
            // colorLabel
            // 
            resources.ApplyResources(this.colorLabel, "colorLabel");
            this.colorLabel.Name = "colorLabel";
            // 
            // choicesListBox
            // 
            resources.ApplyResources(this.choicesListBox, "choicesListBox");
            this.choicesListBox.FormattingEnabled = true;
            this.choicesListBox.Name = "choicesListBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // scoreboardListBox
            // 
            resources.ApplyResources(this.scoreboardListBox, "scoreboardListBox");
            this.scoreboardListBox.FormattingEnabled = true;
            this.scoreboardListBox.Name = "scoreboardListBox";
            // 
            // inputTextBox
            // 
            resources.ApplyResources(this.inputTextBox, "inputTextBox");
            this.inputTextBox.Name = "inputTextBox";
            // 
            // frm_color
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(180)))), ((int)(((byte)(124)))));
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreboardListBox);
            this.Controls.Add(this.choicesListBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.scoreLabel);
            this.Name = "frm_color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ListBox choicesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox scoreboardListBox;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}