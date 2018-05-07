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
    /// Interaction logic for ViewJobs.xaml
    /// </summary>
    public partial class ViewJobs : Window {

        JPDataClassesDataContext dc = new JPDataClassesDataContext();

        User user;

        public ViewJobs(User u) {
            InitializeComponent();

            user = u;

            var res = from r in dc.Listings
                      where r.OpenToAll == 1 || (u.Gpa >= r.GpaRequirement && u.Age >= r.AgeRequirement && u.Experience >= r.ExperienceRequirement)
                      select r;


            ListingsList.ItemsSource = res;

        }

        private void ListBoxSelectionChanged(object sender, SelectionChangedEventArgs e){

            Listing d = (Listing)ListingsList.SelectedItem;

            if(d.OpenToAll == 1){
                RequirementsPanel.Visibility = Visibility.Hidden;
            }
            else {

                RequirementsPanel.Visibility = Visibility.Visible;
            }

        }

        private void Back_Click(object sender, RoutedEventArgs e) {

            CandidateHome ch = new CandidateHome(user);

            this.Close();
            ch.Show();
        }
    }
}
