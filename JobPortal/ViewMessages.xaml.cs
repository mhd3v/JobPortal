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
    /// Interaction logic for ViewMessages.xaml
    /// </summary>
    public partial class ViewMessages : Window {

        JPDataClassesDataContext dc = new JPDataClassesDataContext();
        User user;
        

        public ViewMessages() {
            InitializeComponent();
        }

        public ViewMessages(User u) {
            InitializeComponent();

            user = u;

            var senders = (from m in dc.Messages
                          where m.Receiver == user.UserId
                          orderby m.MessageTime ascending
                          select new Sender{
                              SenderName = m.User.UserName,
                              SenderId = m.User.UserId
                          }).Distinct();

            


            if (senders.Count() > 0) {
                SendersList.ItemsSource = senders;
                SendersList.SelectedIndex = 0;
            }

            else {
                ListingBody.Visibility = Visibility.Hidden;
                SideBar.Visibility = Visibility.Hidden;
                Error.Visibility = Visibility.Visible;
            }

            

        }

        private void NewSenderSelected(object sender, SelectionChangedEventArgs e) {

            Sender s = (Sender)SendersList.SelectedItem;

            var res1 = from n in dc.Messages
                       where ( n.Sender == s.SenderId && n.Receiver == user.UserId) || (n.Sender == user.UserId && n.Receiver == s.SenderId)
                       orderby n.MessageTime descending
                       select n;

            Messages.ItemsSource = res1;

        }

       

        private void Back_Click(object sender, RoutedEventArgs e) {
            
            CandidateHome ch;
            EmployerHome eh;

            if (user.UserType == "candidate") {
                ch = new CandidateHome(user);
                this.Close();
                ch.Show();
            }

            else {
                eh = new EmployerHome(user);
                this.Close();
                eh.Show();
            }
                
        }


    }

    public class Sender {
        public string SenderName { get; set; }
        public int SenderId { get; set; }
    }

    

}
