using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using Tracker.Data;

namespace Tracker
{
    public partial class MainWindow : Window
    {
        private DevDashContext _db;

        public MainWindow()
        {
            InitializeComponent();
            CenterOnScreen();
            StartUp();
        }

        private void StartUp()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            _db = new DevDashContext();

            if (!_db.Users.Any())
            {

            }
        }

        private void CenterOnScreen()
        {
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;

            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Application.Current.Shutdown();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (_db.Users.Where(x => x.Username.Equals(UserName.Text)).Count() > 0)
            {
                if (_db.Users.First(x => x.Username.Equals(UserName.Text)).Password.Equals(Password.Password))
                {

                }

            }
        }

        private void RegisterAccountButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registration = new RegistrationWindow(_db);
            registration.Show();
            this.Close();
        }
    }
}
