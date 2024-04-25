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
    /// Interaction logic for Bill.xaml
    /// </summary>
    public partial class Bill : Window
    {
        PatientPage patientPage;
        EligiblePage eligiblePage;
        ClaimPage claimPage;
        public Bill()
        {
            InitializeComponent();
            patientPage=new PatientPage();
            eligiblePage=new EligiblePage();
            claimPage=new ClaimPage();
            framemain.Content=patientPage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            framemain.Content = patientPage;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            framemain.Content = eligiblePage;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            framemain.Content = claimPage;
        }

        private void btnlog_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
