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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window {

        Boolean UserNameError;

        JPDataClassesDataContext dc = new JPDataClassesDataContext();


        public SignUp() {
            InitializeComponent();
        }

        private void CheckUserName(object sender, TextChangedEventArgs e) {


            int res = (from r in dc.Users
                      where r.UserName == UserName.Text
                      select r).Count();

            if (res != 0) {
                UserNameError = true;
                UsernameError.Visibility = Visibility.Visible;
            }

            else {
                UserNameError = false;
                UsernameError.Visibility = Visibility.Hidden;
            }




        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e) {

            if (UserName.Text != "" && Password.Password.ToString() != "" && CPassword.Password.ToString() != "") {

                if (Password.Password.ToString() == CPassword.Password.ToString()) {

                    if (!UserNameError) {

                        String userType;

                        if (Employer.IsChecked == true)
                            userType = "employer";
                        else
                            userType = "candidate";

                        User newUser = new User() {

                            UserName = UserName.Text,
                            Password = Password.Password.ToString(),
                            UserType = userType

                        };

                        dc.Users.InsertOnSubmit(newUser);
                        dc.SubmitChanges();

                        MainWindow mw = new MainWindow();

                        this.Close();
                        mw.Show();

                    }

                    else {
                        MessageBox.Show("Username taken!");
                    }

                }

                else {
                    MessageBox.Show("Passwords don't match");
                }
                

            }

            else{
                MessageBox.Show("Fill all fields");
            }

        }

        private void Cancel_Click(object sender, RoutedEventArgs e) {
            MainWindow mw = new MainWindow();

            this.Close();
            mw.Show();
        }
    }
}
