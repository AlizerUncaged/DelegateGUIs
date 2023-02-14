using System.ComponentModel;

namespace DelegateGUIs
{
    partial class PublishNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublishNotification));
            this.button1 = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messageArea = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExitClicked);
            // 
            // button2asdasdasdasdqwadqwedqwdqwdqwd
            // 
            this.publishButton.Location = new System.Drawing.Point(200, 185);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(124, 41);
            this.publishButton.TabIndex = 2;
            this.publishButton.Text = "Publish";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.PublishClicked);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notification Content";
            // 
            // richTextBox1
            // 
            this.messageArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageArea.Location = new System.Drawing.Point(12, 35);
            this.messageArea.Name = "richTextBox1";
            this.messageArea.Size = new System.Drawing.Size(442, 144);
            this.messageArea.TabIndex = 4;
            this.messageArea.Text = "";
            // 
            // PublishNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 238);
            this.Controls.Add(this.messageArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PublishNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Publish Notification";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox messageArea;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button publishButton;

        #endregion
    }
}