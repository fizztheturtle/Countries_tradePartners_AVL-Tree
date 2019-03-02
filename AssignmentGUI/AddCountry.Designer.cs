namespace AssignmentGUI
{
    partial class AddCountry
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
            this.newCountryLbl = new System.Windows.Forms.Label();
            this.newCountryBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCountryLbl
            // 
            this.newCountryLbl.AutoSize = true;
            this.newCountryLbl.Location = new System.Drawing.Point(12, 9);
            this.newCountryLbl.Name = "newCountryLbl";
            this.newCountryLbl.Size = new System.Drawing.Size(137, 13);
            this.newCountryLbl.TabIndex = 0;
            this.newCountryLbl.Text = "Enter name of new country:";
            // 
            // newCountryBox
            // 
            this.newCountryBox.Location = new System.Drawing.Point(156, 9);
            this.newCountryBox.Name = "newCountryBox";
            this.newCountryBox.Size = new System.Drawing.Size(92, 20);
            this.newCountryBox.TabIndex = 1;
            this.newCountryBox.TextChanged += new System.EventHandler(this.newCountryBox_TextChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 39);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(173, 39);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // AddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 74);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.newCountryBox);
            this.Controls.Add(this.newCountryLbl);
            this.Name = "AddCountry";
            this.Text = "Add new country";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newCountryLbl;
        private System.Windows.Forms.TextBox newCountryBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
    }
}