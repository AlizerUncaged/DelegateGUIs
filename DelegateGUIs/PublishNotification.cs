using System;
using System.Windows.Forms;

namespace DelegateGUIs
{
    public partial class PublishNotification : Form
    {
        public string PublishText = null;
        public PublishNotification()
        {
            InitializeComponent();
        }

        private void ExitClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PublishClicked(object sender, EventArgs e)
        {
            PublishText = messageArea.Text;
            this.Close();
        }
    }
}