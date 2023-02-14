using System;
using System.Windows.Forms;

namespace DelegateGUIs
{
    public class SendViaEmail
    {
        private string email;
        private bool isSubscribed;


        public SendViaEmail(string email)
        {
            this.email = email;
            this.isSubscribed = false;
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public bool IsSubscribed
        {
            get { return this.isSubscribed; }
        }

        public void SendNotification(string message)
        {

            MessageBox.Show(message, $"Notification {email}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public event EventHandler Unsubcribe;

        public void Unsubscribe()
        {
            Unsubcribe?.Invoke(this, EventArgs.Empty);
        }
    }
}