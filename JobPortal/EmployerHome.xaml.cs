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

namespace JobPortal {
    /// <summary>
    /// Interaction logic for EmployerHome.xaml
    /// </summary>
    public partial class EmployerHome : Window {

        User user;

        public EmployerHome() {
            InitializeComponent();
        }
        
        public EmployerHome(User u) {
            InitializeComponent();

            user = u;
            WelcomeText.Content = "Welcome " + u.UserName +"!";
        }

        private void Logout_Click(object sender, RoutedEventArgs e) {

            MainWindow mw = new MainWindow();

            this.Close();
            mw.Show();

        }

        private void CreateJobListing_Click(object sender, RoutedEventArgs e) {

            CreateJobListing joblisting = new CreateJobListing(user);

            this.Close();
            joblisting.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            ViewMessages vm = new ViewMessages(user);

            this.Close();
            vm.Show();
        }
    }
}
