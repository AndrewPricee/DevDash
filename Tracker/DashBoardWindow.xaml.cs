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
    /// Interaction logic for DashBoardWindow.xaml
    /// </summary>
    public partial class DashBoardWindow : Window
    {
        DevDashContext _db;
        List<Project> Projects;
        UserInfo LoggedInUser;

        public DashBoardWindow(DevDashContext _passeddb, UserInfo user)
        {
            InitializeComponent();
            CenterOnScreen();

            SetUp(_passeddb, user);
        }
        
        private void SetUp(DevDashContext _passeddb, UserInfo user)
        {
            _db = _passeddb;
            int HotCount = 0;
            GreetingLabel.Content = "Welcome, " + user.FirstName;

            if(_db.Projects.Where(x => x.UserID == user.UserID).Count() > 0)
            {
                Projects = _db.Projects.Where(x => x.UserID == user.UserID).ToList();
            }
            else
            {
                Projects = new List<Project>();
            }

            CurrentProjectsCount.Content = Projects.Where(x => x.ProjectComplete == false).ToList().Count();
            CompletedProjectsCount.Content = Projects.Where(x => x.ProjectComplete == true).ToList().Count();

            foreach(var project in Projects.Where(x => (x.ProjectDueDate - DateTime.Today).TotalDays < 14 && x.ProjectComplete == false).ToList())
            {
                HotCount++;
            }

            HotProjectsCount.Content = HotCount;


            LoggedInUser = user;
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

        private void CreateProjectButton_Click(object sender, RoutedEventArgs e)
        {
            string ProjectNameString = ProjectNameTextBox.Text;
            DateTime DueDate = DueDatePicker.SelectedDate.Value;
            DateTime StartDate = StartDatePicker.SelectedDate.Value;
            string ProjectDescriptionString = ProjectDescriptionBox.Text;
            bool Completed = CompletedCheckBox.IsChecked.Value;

            Project project = new Project()
            {
                ProjectComplete = Completed,
                ProjectDescription = ProjectDescriptionString,
                ProjectDueDate = DueDate,
                ProjectStartDate = StartDate,
                ProjectName = ProjectNameString,
                ProjectType = 0,
                UserID = LoggedInUser.UserID
            };
            Projects.Add(project);

            _db.Projects.Add(project);
            _db.SaveChanges();

            Dialog dialog = new Dialog("Project Has Been Added", "okay", "", false);
            dialog.ShowDialog();

            ProjectNameTextBox.Text = "";
            DueDatePicker.Text = "";
            StartDatePicker.Text = "";
            ProjectDescriptionBox.Text = "";
            CompletedCheckBox.IsChecked = false;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetUp(_db, LoggedInUser);
        }
    }
}
