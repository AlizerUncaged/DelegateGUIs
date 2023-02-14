using System.ComponentModel;

namespace DelegateGUIs
{
    partial class ManageSubcriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubcriptionForm));
            this.emailNotif = new System.Windows.Forms.CheckBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.numField = new System.Windows.Forms.TextBox();
            this.mobileNotif = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.invalidNotif = new System.Windows.Forms.Label();
            this.invlN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailNotif
            // 
            this.emailNotif.Checked = true;
            this.emailNotif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.emailNotif.Location = new System.Drawing.Point(49, 64);
            this.emailNotif.Name = "emailNotif";
            this.emailNotif.Size = new System.Drawing.Size(104, 24);
            this.emailNotif.TabIndex = 0;
            this.emailNotif.Text = "Notification Sent by Email";
            this.emailNotif.UseVisualStyleBackColor = true;
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(185, 66);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(249, 20);
            this.emailField.TabIndex = 1;
            // 
            // numField
            // 
            this.numField.Location = new System.Drawing.Point(185, 132);
            this.numField.Name = "numField";
            this.numField.Size = new System.Drawing.Size(249, 20);
            this.numField.TabIndex = 3;
            this.numField.Text = "xxx-xxx-xxx";
            // 
            // mobileNotif
            // 
            this.mobileNotif.Location = new System.Drawing.Point(49, 130);
            this.mobileNotif.Name = "mobileNotif";
            this.mobileNotif.Size = new System.Drawing.Size(104, 24);
            this.mobileNotif.TabIndex = 2;
            this.mobileNotif.Text = "Notification Sent by SMS";
            this.mobileNotif.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(360, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Unsubcribe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "Subscribe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SubscribeClicked);
            // 
            // invalidNotif
            // 
            this.invalidNotif.ForeColor = System.Drawing.Color.Red;
            this.invalidNotif.Location = new System.Drawing.Point(185, 89);
            this.invalidNotif.Name = "invalidNotif";
            this.invalidNotif.Size = new System.Drawing.Size(249, 23);
            this.invalidNotif.TabIndex = 7;
            this.invalidNotif.Text = "Invalid Email Address";
            // 
            // invlN
            // 
            this.invlN.ForeColor = System.Drawing.Color.Red;
            this.invlN.Location = new System.Drawing.Point(185, 155);
            this.invlN.Name = "invlN";
            this.invlN.Size = new System.Drawing.Size(249, 23);
            this.invlN.TabIndex = 8;
            this.invlN.Text = "Invalid Mobile Number";
            // 
            // ManageSubcriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 254);
            this.Controls.Add(this.invlN);
            this.Controls.Add(this.invalidNotif);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numField);
            this.Controls.Add(this.mobileNotif);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.emailNotif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageSubcriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Subcription Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label invlN;

        private System.Windows.Forms.Label invalidNotif;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.TextBox numField;
        private System.Windows.Forms.CheckBox mobileNotif;

        private System.Windows.Forms.TextBox emailField;

        private System.Windows.Forms.CheckBox emailNotif;

        #endregion
    }
}