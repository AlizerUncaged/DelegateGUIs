using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateGUIs
{
    public partial class MainForm : Form
    {
        public delegate void Notify(string text);

        private List<SendViaEmail> _sendViaEmails =
            new List<SendViaEmail>();

        private List<SendViaMobile> _sendViaMobile =
            new List<SendViaMobile>();

        private IEnumerable<Notify> notificationDelegates
        {
            get
            {
                List<Notify> notifyList = new List<Notify>();

                foreach (var i in _sendViaEmails)
                {
                    notifyList.Add(i.SendNotification);
                }

                foreach (var i in _sendViaMobile)
                {
                    notifyList.Add(i.SendNotification);
                }

                return notifyList;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitClicked(object sender, EventArgs e)
        {
            this.Close();
        }


        private void NotifyError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ManageSubscriptionClicked(object sender, EventArgs e)
        {
            var manageSubForm = new ManageSubcriptionForm();

            manageSubForm.ShowDialog();

            if (manageSubForm.Subscribe)
            {
                if (manageSubForm.SendViaEmail != null &&
                    _sendViaEmails.All(x => x.Email != manageSubForm.SendViaEmail.Email))
                {
                    _sendViaEmails.Add(manageSubForm.SendViaEmail);
                }

                if (manageSubForm.SendViaMobile != null &&
                    _sendViaMobile.All(x => x.MobileNumber != manageSubForm.SendViaMobile.MobileNumber))
                {
                    _sendViaMobile.Add(manageSubForm.SendViaMobile);
                }
            }
            else
            {
                if (manageSubForm.SendViaEmail != null &&
                    _sendViaEmails.RemoveAll(x => x.Email == manageSubForm.SendViaEmail.Email) > 0)
                {
                    MessageBox.Show(
                        $"Successfully removed {manageSubForm.SendViaEmail.Email} from email notifications.",
                        "Removed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        $"{manageSubForm.SendViaEmail.Email} does not exist in the subscribers list.",
                        "Email does not exist!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (manageSubForm.SendViaMobile != null &&
                    _sendViaMobile.RemoveAll(x => x.MobileNumber == manageSubForm.SendViaMobile.MobileNumber) > 0)
                {
                    MessageBox.Show(
                        $"Successfully removed {manageSubForm.SendViaEmail.Email} from phone notifications.",
                        "Removed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        $"{manageSubForm.SendViaEmail.Email} does not exist in the subscribers list.",
                        "Mobile number does not exist!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            publishButton.Enabled = _sendViaEmails.Any() || _sendViaMobile.Any();

        }

        private void SendNotif(object sender, EventArgs e)
        {
            var notifForm = new PublishNotification();
            notifForm.ShowDialog();

            if (!string.IsNullOrWhiteSpace(notifForm.PublishText))
                foreach (var notifMethod in notificationDelegates)
                {
                    notifMethod?.Invoke(notifForm.PublishText);
                }
        }
    }
}