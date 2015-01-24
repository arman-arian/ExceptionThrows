using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using SilverlightApplicationTest.TestServiceReference;

namespace SilverlightApplicationTest
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnThrows_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var client = new TestServiceClient();
                client.DoWorkCompleted += client_DoWorkCompleted;
                client.DoWorkAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void client_DoWorkCompleted(object sender, DoWorkCompletedEventArgs e)
        {

            LblErrorMsg.Content = e.Error.Message;
        }

    }
}
