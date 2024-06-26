namespace MusicMaster2._0
{
    partial class LicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
            richTextBoxLicense = new RichTextBox();
            Cancel = new Button();
            Ok = new Button();
            SuspendLayout();
            // 
            // richTextBoxLicense
            // 
            richTextBoxLicense.Location = new Point(0, 0);
            richTextBoxLicense.MinimumSize = new Size(532, 411);
            richTextBoxLicense.Name = "richTextBoxLicense";
            richTextBoxLicense.ReadOnly = true;
            richTextBoxLicense.Size = new Size(722, 411);
            richTextBoxLicense.TabIndex = 0;
            richTextBoxLicense.Text = "";
            // 
            // Cancel
            // 
            Cancel.Location = new Point(365, 417);
            Cancel.MinimumSize = new Size(348, 74);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(354, 74);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Ok
            // 
            Ok.Location = new Point(2, 416);
            Ok.MinimumSize = new Size(348, 74);
            Ok.Name = "Ok";
            Ok.Size = new Size(354, 76);
            Ok.TabIndex = 1;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // LicenseForm
            // 
            AcceptButton = Ok;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Cancel;
            ClientSize = new Size(722, 495);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Controls.Add(richTextBoxLicense);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(0, 551);
            Name = "LicenseForm";
            Text = "LicenseAgreement - MusicMaster Radio";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxLicense;
        private Button Cancel;
        private Button Ok;
    }
}