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
    /// Interaction logic for CandidateHome.xaml
    /// </summary>
    public partial class CandidateHome : Window {
        User user;

        public CandidateHome() {
            InitializeComponent();
        }

        public CandidateHome(User u) {
            InitializeComponent();

            user = u;

            WelcomeText.Content = "Welcome " + user.UserName + "!";
        }

        
        private void Logout_Click(object sender, RoutedEventArgs e) {

            MainWindow mw = new MainWindow();

            this.Close();
            mw.Show();
        }

        private void ViewJobs_Click(object sender, RoutedEventArgs e) {

            ViewJobs vj = new ViewJobs(user);

            this.Close();
            vj.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            CandidateEditProfile cep = new CandidateEditProfile(user);

            this.Close();
            cep.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            ViewMessages vm = new ViewMessages(user);

            this.Close();
            vm.Show();
        }

       
    }
}
