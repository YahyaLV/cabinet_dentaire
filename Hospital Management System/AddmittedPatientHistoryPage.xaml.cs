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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System
{
    public class ShowHistory1
    {
        public string Patient_Name { get; set; }
        public string Contact_No { get; set; }
        public string Age { get; set; }
        public string Ward_Name { get; set; }
        public string Bed_No { get; set; }
    }

    
 
    public partial class AddmittedPatientHistoryPage : Page
    {
        public AddmittedPatientHistoryPage()
        {
            InitializeComponent();
            show_all();
        }
        public MySqlConnection conn = DBConnect.connectToDb();

        void show_all()
        {
            try
            {
                string sql = "select patient_name as nom,service,date_rdv as debut_rdv,date_rdv2 as fin_rdv,doc_name as dentiste from dentaire.patient ";
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds);
                Dgrid1.ItemsSource = ds.Tables[0].DefaultView;
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message.ToString() + " Exceptiom");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
           
        }

        private void btnDeleteDoctor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sql = "delete from dentaire.patient where patient_name='" + patient_name.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(sql, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2.Close();
                MessageBox.Show("patient supprimé");
                // txtDocId.Text = "";
                show_all();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message.ToString());
            }
        }

        private void Dgrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)Dgrid1.SelectedItems[0];
                patient_name.Text = row["Nom"].ToString();
            }
            catch { }
        }

        private void txtWard_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtBed_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

     
}
