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

namespace Calc
{
    /// <summary>
    /// Interaction logic for Menu1.xaml
    /// </summary>
    public partial class Menu1 : Window
    {
        PatientPage patientPage;
        EligiblePage eligiblePage;
        ClaimPage claimPage;
        public Menu1()
        {
            InitializeComponent();
            patientPage = new PatientPage();
            eligiblePage = new EligiblePage();
            claimPage = new ClaimPage();
            framemain.Content = patientPage;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            framemain.Content = patientPage;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            framemain.Content = eligiblePage;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            framemain.Content = claimPage;
        }
    }
}
