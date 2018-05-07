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
    /// Interaction logic for CandidateEditProfile.xaml
    /// </summary>
    public partial class CandidateEditProfile : Window {

        User user;
        JPDataClassesDataContext dc = new JPDataClassesDataContext();

        public CandidateEditProfile() {
            InitializeComponent();
        }

        public CandidateEditProfile(User u) {
            InitializeComponent();

            user = u;

            populateComboxes();

            setCurrentValues();
            
        }

        void populateComboxes() {

            for (double i = 20; i < 45; i++)
                Age.Items.Add(new ComboBoxItem(i.ToString() + " years", i)); //adding display value, hidden value


            for (double i = 2; i <= 4; i += 0.1) 
                Gpa.Items.Add(new ComboBoxItem(i.ToString(), i)); //adding display value, hidden value

            for (double i = 1; i <= 10; i++)
                Experience.Items.Add(new ComboBoxItem(i + "+ years", i)); //adding display value, hidden value

     
        }

        void setCurrentValues(){

             for (int i = 0; i < Age.Items.Count; i++) {

                Double age = ((ComboBoxItem)Age.Items[i]).HiddenValue;

                if (age == user.Age) 
                    Age.SelectedIndex = i;
            }

             for (int i = 0; i < Experience.Items.Count; i++) {

                 Double exp = ((ComboBoxItem)Experience.Items[i]).HiddenValue;

                 if (exp == user.Experience)
                     Experience.SelectedIndex = i;
             }

             for (int i = 0; i < Gpa.Items.Count; i++) {

                 Double gpa = ((ComboBoxItem)Gpa.Items[i]).HiddenValue;

                 if (gpa.ToString() == user.Gpa.ToString())
                     Gpa.SelectedIndex = i;
             }
        }

        private void Save_Click(object sender, RoutedEventArgs e) {

            var res = (from u in dc.Users
                      where u.UserName == user.UserName
                      select u).FirstOrDefault();

            res.Gpa = ((ComboBoxItem)Gpa.SelectedItem).HiddenValue;
            res.Experience = ((ComboBoxItem)Experience.SelectedItem).HiddenValue;
            res.Age = ((ComboBoxItem)Age.SelectedItem).HiddenValue;

            dc.SubmitChanges();

            CandidateHome ch = new CandidateHome((User)res);
            this.Close();
            ch.Show();

        }

    }


}
