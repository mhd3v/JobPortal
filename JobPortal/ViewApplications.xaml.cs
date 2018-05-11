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
    /// Interaction logic for ViewApplications.xaml
    /// </summary>
    public partial class ViewApplications : Window {

        User user;
        JPDataClassesDataContext dc = new JPDataClassesDataContext();

        public ViewApplications() {
            InitializeComponent();
        }

        public ViewApplications(User u) {
            InitializeComponent();

            user = u;

            var res = from ja in dc.JobApplications
                      where ja.Listing.UserId == user.UserId
                      select new Candidate{
                          CandidateId = ja.Candidate,
                          CandidateName = ja.User.UserName,
                          CandidateGPA = ja.User.Gpa,
                          CandidateExperience = ja.User.Experience,
                          CandidateAge = ja.User.Age,
                          AppliedFor = ja.Listing.ListingTitle
                            
                      };


            if (res.Count() > 0) {
                CandidateList.ItemsSource = res;
                CandidateList.SelectedIndex = 0;
            }

            else {
                SideBar.Visibility = Visibility.Hidden;
                CandidateProfile.Visibility = Visibility.Hidden;
                Error.Visibility = Visibility.Visible;
            }
           

        }

        private void Back_Click(object sender, RoutedEventArgs e) {

            EmployerHome eh = new EmployerHome(user);
            this.Close();
            eh.Show();
            
        }

        private void NewCandidateSelected(object sender, SelectionChangedEventArgs e) {

        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            Candidate selectedItem = (Candidate)CandidateList.SelectedItem;

            SendMessage sm = new SendMessage("You've been called for an interview by "+ user.UserName ,user, selectedItem.CandidateId);

            this.Close();
            sm.Show();

        }

    }

    public class Candidate {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public double? CandidateGPA { get; set; }
        public double? CandidateExperience { get; set; }
        public double? CandidateAge { get; set; }
        public string AppliedFor { get; set; }

    }

    
}
