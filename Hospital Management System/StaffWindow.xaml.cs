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

namespace Hospital_Management_System
{
    /// <summary>
    /// Interaction logic for StaffWindow.xaml
    /// </summary>
    public partial class StaffWindow : Window
    {
        public StaffWindow()
        {
            InitializeComponent();
        }

        public static string ward = "";
        public static string bed = "";
        public static string bed_type = ""; 



        private void btnAdmitPatient_Click(object sender, RoutedEventArgs e)
        {
            AdmitPatientPage objAdmitPatient = new AdmitPatientPage();
            staffFrame.NavigationService.Navigate(objAdmitPatient);
        }

        private void btnReleasePatient_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            objMainWindow.Show();
            this.Close();
        }

        private void btnUpdateInfo_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void btnTakeAppointment_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void btnBloodBank_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnAppointmentStatus_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnAddView_Click(object sender, RoutedEventArgs e)
        {
            SupplierPage objSupplier = new SupplierPage();
            staffFrame.NavigationService.Navigate(objSupplier);
        }

        private void btnDispensary_Click(object sender, RoutedEventArgs e)
        {
            
        }

        
        private void btnViewSchedule_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnPatientDetails_Click(object sender, RoutedEventArgs e)
        {
            AddmittedPatientHistoryPage obj = new AddmittedPatientHistoryPage();
            staffFrame.NavigationService.Navigate(obj);           
        }

        private void loginAsStaff_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
