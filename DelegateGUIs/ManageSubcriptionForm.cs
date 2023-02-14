using System;
using System.Windows.Forms;

namespace DelegateGUIs
{
    public partial class ManageSubcriptionForm : Form
    {
        public SendViaEmail SendViaEmail = null;
        public SendViaMobile SendViaMobile = null;

        public bool Subscribe = true;

        public ManageSubcriptionForm()
        {
            InitializeComponent();

            invlN.Visible = false;
            invalidNotif.Visible = false;
        }

        private void SubscribeClicked(object sender, EventArgs e)
        {
            invlN.Visible = false;
            invalidNotif.Visible = false;

            if (emailNotif.Checked)
            {
                if (!Utilities.IsValidEmail(emailField.Text))
                {
                    invalidNotif.Visible = true;
                    return;
                }
                else
                    SendViaEmail = new SendViaEmail(emailField.Text);
            }

            if (mobileNotif.Checked)
            {
                if (Utilities.IsValidMobileNumber(numField.Text))
                {
                    invlN.Visible = true;
                    return;
                }
                else
                    SendViaMobile = new SendViaMobile(numField.Text);
            }

            this.Close();
        }

        private void UnsubClick(object sender, EventArgs e)
        {
            Subscribe = false;
            
            
            invlN.Visible = false;
            invalidNotif.Visible = false;

            if (emailNotif.Checked)
            {
                if (!Utilities.IsValidEmail(emailField.Text))
                {
                    invalidNotif.Visible = true;
                    return;
                }
                else
                    SendViaEmail = new SendViaEmail(emailField.Text);
            }

            if (mobileNotif.Checked)
            {
                if (Utilities.IsValidMobileNumber(numField.Text))
                {
                    invlN.Visible = true;
                    return;
                }
                else
                    SendViaMobile = new SendViaMobile(numField.Text);
            }


            this.Close();
        }
    }
}