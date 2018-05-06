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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JobPortal {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        JPDataClassesDataContext dc = new JPDataClassesDataContext();


        public MainWindow() {
            InitializeComponent();
        }

        private void SignupClick_Click(object sender, RoutedEventArgs e) {

            SignUp su = new SignUp();

            this.Close();

            su.Show();



        }

        private void LoginClick_Click(object sender, RoutedEventArgs e) {

            if (UserName.Text != "" && Password.ToString() != "") {

                var res = from r in dc.Users
                          where r.UserName == UserName.Text && r.Password == Password.ToString()
                          select r;

                if (res != null) {

                    User user = (User)res;

                    if (user.UserType == "employer") {

                        EmployerHome eh = new EmployerHome(user);

                        this.Close();
                        eh.Show();

                    }

                    else {

                        //EmployerHome eh = new EmployerHome(user);

                        //this.Close();
                        //eh.Show();
                    }

                }


            }

            else {

                if (UserName.Text == "" && Password.ToString() != "")
                    MessageBox.Show("Enter username and password");

                else if (UserName.Text == "")
                    MessageBox.Show("Enter username");
                else
                    MessageBox.Show("Enter Password");

            }

        }

        
    }
}
