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
        public CandidateHome() {
            InitializeComponent();
        }

        public CandidateHome(User user) {
            InitializeComponent();

            WelcomeText.Text = "Welcome " + user.UserName;
        }

        
        private void Logout_Click(object sender, RoutedEventArgs e) {

            MainWindow mw = new MainWindow();

            this.Close();
            mw.Show();
        }
    }
}
