using System;
using System.Windows.Forms;
using WinFormTest.TestServiceReference;

namespace WinFormTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new TestServiceClient();
                client.DoWork();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
