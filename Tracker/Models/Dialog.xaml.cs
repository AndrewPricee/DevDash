using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tracker.Models
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        public Dialog(string Msg, string ConfirmButtonText, string RejectButtonText, bool Choice)
        {
            InitializeComponent();
            SetUp(Msg,ConfirmButtonText, RejectButtonText, Choice);
        }

        public void SetUp(string Msg, string ConfirmButtonText, string RejectButtonText, bool Choice)
        {
            MessageText.Content = Msg;

            if (Choice)
            {
                ConfirmButton.Visibility = Visibility.Visible;
                RejectButton.Visibility = Visibility.Visible;

                ConfirmButton.Content = ConfirmButtonText;
                RejectButton.Content = RejectButtonText;
            }
            else
            {
                ContinueButton.Visibility = Visibility.Visible;
                ContinueButton.Content = ConfirmButtonText;
            }
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
