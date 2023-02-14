using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System;

namespace DelegateGUIs
{
    public class SendViaMobile
    {
        private string mobileNumber;
        private bool isSubscribed;


        public SendViaMobile(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
            this.isSubscribed = false;
        }

        public string MobileNumber
        {
            get { return this.mobileNumber; }
            set { this.mobileNumber = value; }
        }

        public bool IsSubscribed
        {
            get { return this.isSubscribed; }
        }

        public void SendNotification(string message)
        {

            MessageBox.Show(message, $"Notification {mobileNumber}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public event EventHandler Unsubcribe;

        public void Unsubscribe()
        {
            Unsubcribe?.Invoke(this, EventArgs.Empty);
        }

    }
}