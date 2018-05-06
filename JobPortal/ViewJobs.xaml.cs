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

        public ViewJobs() {
            InitializeComponent();

            var res = from r in dc.Listings
                      select r;

            dg.ItemsSource = res;

        }
    }
}
