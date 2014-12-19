namespace House
{
    partial class Form1
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
            this.setGoToBtn = new System.Windows.Forms.Button();
            this.goToBtn = new System.Windows.Forms.Button();
            this.exitsComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // setGoToBtn
            // 
            this.setGoToBtn.Location = new System.Drawing.Point(12, 237);
            this.setGoToBtn.Name = "setGoToBtn";
            this.setGoToBtn.Size = new System.Drawing.Size(75, 23);
            this.setGoToBtn.TabIndex = 0;
            this.setGoToBtn.Text = "Go here:";
            this.setGoToBtn.UseVisualStyleBackColor = true;
            // 
            // goToBtn
            // 
            this.goToBtn.Location = new System.Drawing.Point(13, 267);
            this.goToBtn.Name = "goToBtn";
            this.goToBtn.Size = new System.Drawing.Size(327, 23);
            this.goToBtn.TabIndex = 1;
            this.goToBtn.Text = "Go through the door";
            this.goToBtn.UseVisualStyleBackColor = true;
            // 
            // exitsComboBox
            // 
            this.exitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitsComboBox.FormattingEnabled = true;
            this.exitsComboBox.Location = new System.Drawing.Point(103, 238);
            this.exitsComboBox.Name = "exitsComboBox";
            this.exitsComboBox.Size = new System.Drawing.Size(237, 21);
            this.exitsComboBox.TabIndex = 2;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(12, 13);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(328, 218);
            this.descriptionTxt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 299);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.exitsComboBox);
            this.Controls.Add(this.goToBtn);
            this.Controls.Add(this.setGoToBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setGoToBtn;
        private System.Windows.Forms.Button goToBtn;
        private System.Windows.Forms.ComboBox exitsComboBox;
        private System.Windows.Forms.TextBox descriptionTxt;
    }
}

