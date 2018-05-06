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
    /// Interaction logic for CreateJobListing.xaml
    /// </summary>
    public partial class CreateJobListing : Window {

        JPDataClassesDataContext dc = new JPDataClassesDataContext();

        Boolean alreadyPopulated = false;

        User user;

        public CreateJobListing() {
            InitializeComponent();
        }

        public CreateJobListing(User u) {
            InitializeComponent();
            user = u;
        }

        private void SelectedRequirementsChecked(object sender, RoutedEventArgs e) {

            if (!alreadyPopulated)
                populateComboxes();

            Requirements.Visibility = Visibility.Visible;


        }

        private void SelectedRequirementsUnchecked(object sender, RoutedEventArgs e) {
            Requirements.Visibility = Visibility.Hidden;
        }

        void populateComboxes() {

            alreadyPopulated = true;

            for (double i = 24; i < 45; i = i + 2) 
                Age.Items.Add(new ComboBoxItem("Less than " + i + " years", i)); //adding display value, hidden value
            

            for (double i = 2; i <= 4; i += 0.2) //adding 0.2 
                Gpa.Items.Add(new ComboBoxItem(i + "+", i)); //adding display value, hidden value

            

            for (double i = 1; i <= 10; i++) 
                Experience.Items.Add(new ComboBoxItem(i + "+ years", i)); //adding display value, hidden value
            
        }

        private void CreateListing_Click(object sender, RoutedEventArgs e) {

            if(listingTitle.Text != "" && listingDescription.Text != ""){

                if (SelectedRequirements.IsChecked == true) {

                    if (Age.SelectedItem != null && Gpa.SelectedItem != null & Experience.SelectedItem != null) {

                        Double age = ((ComboBoxItem)Age.SelectedItem).HiddenValue;
                        Double gpa = ((ComboBoxItem)Gpa.SelectedItem).HiddenValue;
                        Double exp = ((ComboBoxItem)Experience.SelectedItem).HiddenValue;

                        Listing listing = new Listing() {
                            ListingTitle = listingTitle.Text,
                            ListingDescription = listingDescription.Text,
                            UserId = user.UserId,
                            OpenToAll = 0,
                            GpaRequirement = gpa,
                            AgeRequirement = age,
                            ExperienceRequirement = exp,
                            ListedDate = System.DateTime.Now

                        };

                        dc.Listings.InsertOnSubmit(listing);
                        dc.SubmitChanges();

                        MessageBox.Show("Listing Created");

                    }

                    else {
                        MessageBox.Show("Selected all requirements");
                    }

                }

                else {

                    Listing listing = new Listing(){
                        ListingTitle = listingTitle.Text,
                        ListingDescription = listingDescription.Text,
                        UserId = user.UserId,
                        OpenToAll = 1,
                        ListedDate = System.DateTime.Now

                    };

                    dc.Listings.InsertOnSubmit(listing);
                    dc.SubmitChanges();

                    MessageBox.Show("Listing Created");

                }

            }

            



        }

        private void Cancel_Click(object sender, RoutedEventArgs e) {

            EmployerHome eh = new EmployerHome();

            this.Close();
            eh.Show();


        }

    }


    public class ComboBoxItem { //will use this class to store a value with each item


        string displayValue;
        double hiddenValue;

        public ComboBoxItem(string d, double h) {
            displayValue = d;
            hiddenValue = h;
        }

        //Accessor
        public double HiddenValue {
            get {
                return hiddenValue;
            }
        }

        public override string ToString() {
            return displayValue;
        }

    }

    

}
