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
    /// Interaction logic for SendMessage.xaml
    /// </summary>
    public partial class SendMessage : Window {

        User user;
        int reciever;
        
        JPDataClassesDataContext dc = new JPDataClassesDataContext();

        public SendMessage() {
            InitializeComponent();
        }

        public SendMessage(string messageTitle, User sender, int r) {
            InitializeComponent();
            user = sender;

            MessageBox.Show(r.ToString());

            MessageTitle.Text = messageTitle;

            reciever = r;
        }

        private void Send_Click(object sender, RoutedEventArgs e) {

            if (MessageBody.Text != "") {

                Message newMessage = new Message() {
                    Sender = user.UserId,
                    Receiver = reciever,
                    MessageTitle = MessageTitle.Text,
                    MessageBody = MessageBody.Text,
                    MessageTime = System.DateTime.Now
                };

                dc.Messages.InsertOnSubmit(newMessage);

                dc.SubmitChanges();

                if (user.UserType == "employer") {
                    EmployerHome eh= new EmployerHome(user);

                    this.Close();
                    eh.Show();
                }

                else {
                    CandidateHome eh = new CandidateHome(user);

                    this.Close();
                    eh.Show();
                }

                


            }

            else {
                MessageBox.Show("Message body can't be empty");
            }

        }

        private void Cancel_Click(object sender, RoutedEventArgs e) {

            if (user.UserType == "employer") {
                EmployerHome eh = new EmployerHome(user);

                this.Close();
                eh.Show();
            }

            else {
                CandidateHome eh = new CandidateHome(user);

                this.Close();
                eh.Show();
            }

        }

       


    }
}
