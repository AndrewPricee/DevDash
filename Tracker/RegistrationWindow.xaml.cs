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
using Tracker.Data;
using Tracker.Models;

namespace Tracker
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        List<UserInfo> Users;
        DevDashContext _db;

        public RegistrationWindow(DevDashContext _passeddb)
        {
            InitializeComponent();
            CenterOnScreen();

            _db = _passeddb;

            Users = _db.Users.ToList();
            Users = Users.OrderBy(o => o.UserID).ToList();
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
            catch (Exception)
            {
                throw;
            }
        }


        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string UserName = UserEmail.Text;
            string UserFirstname = UserFirstName.Text;
            string Usersurname = UserSurname.Text;
            string ConfirmPassword = "";

            int NewUserID = 0;

            if(Users.Count > 0)
            {
                NewUserID = Users[Users.Count - 1].UserID + 1;
            }
            else
            {
                NewUserID = 1;
            }

            if (UserPassword.Password.Equals(UserConfirmPassword.Password))
            {
                ConfirmPassword = UserPassword.Password;
            }
            else
            {
                //Message messageBox = new Message(this, "Passwords Do Not Match", "Okay" , "", false);
                //messageBox.ShowDialog();
            }

            if(UserName != "" && UserFirstname != "" && Usersurname != "" && ConfirmPassword != "" && NewUserID != 0)
            {
                if(Users.Where(x => x.Username.Equals(UserName)).Count() == 0)
                {
                    UserInfo userInfo = new UserInfo()
                    {
                        FirstName = UserFirstname,
                        LastName = Usersurname,
                        Username = UserName,
                        Password = ConfirmPassword,
                        UserID = NewUserID
                    };

                    _db.Users.Add(userInfo);
                    _db.SaveChanges();

                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
            }


        }
    }
}
