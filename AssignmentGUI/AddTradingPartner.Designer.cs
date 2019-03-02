namespace AssignmentGUI
{
    partial class AddTradingPartner
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
            this.newTradingPartnerLbl = new System.Windows.Forms.Label();
            this.newTradingPartnerBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTradingPartnerLbl
            // 
            this.newTradingPartnerLbl.AutoSize = true;
            this.newTradingPartnerLbl.Location = new System.Drawing.Point(12, 9);
            this.newTradingPartnerLbl.Name = "newTradingPartnerLbl";
            this.newTradingPartnerLbl.Size = new System.Drawing.Size(135, 13);
            this.newTradingPartnerLbl.TabIndex = 1;
            this.newTradingPartnerLbl.Text = "Enter name of new partner:";
            // 
            // newTradingPartnerBox
            // 
            this.newTradingPartnerBox.Location = new System.Drawing.Point(155, 9);
            this.newTradingPartnerBox.Name = "newTradingPartnerBox";
            this.newTradingPartnerBox.Size = new System.Drawing.Size(92, 20);
            this.newTradingPartnerBox.TabIndex = 2;
            this.newTradingPartnerBox.TextChanged += new System.EventHandler(this.newTradingPartnerBox_TextChanged);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(173, 39);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 39);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddTradingPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 74);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.newTradingPartnerBox);
            this.Controls.Add(this.newTradingPartnerLbl);
            this.Name = "AddTradingPartner";
            this.Text = "AddTradingPartner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newTradingPartnerLbl;
        private System.Windows.Forms.TextBox newTradingPartnerBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}