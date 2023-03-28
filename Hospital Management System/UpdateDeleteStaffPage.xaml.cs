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
using MySql.Data.MySqlClient;
using System.Data;

namespace Hospital_Management_System
{
    /// <summary>
    /// Interaction logic for UpdateDeleteStaffPage.xaml
    /// </summary>
    public partial class UpdateDeleteStaffPage : Page
    {
        public UpdateDeleteStaffPage()
        {
            InitializeComponent();
            load();
        }

        public MySqlConnection con = DBConnect.connectToDb();

        public void load()
        {
            try
            {
                string sql = "SELECT personnel_id as ID,name as nom ,age,address as email FROM dentaire.infermier;";                
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(ds);
                DataGridStaff.ItemsSource = ds.Tables[0].DefaultView;
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message.ToString());
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void DataGridStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)DataGridStaff.SelectedItems[0];
                txtStaffId.Text = row["ID"].ToString();
            }
            catch { }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sql = "update dentaire.infermier set name='" + txtStaffName.Text+ "' where personnel_id='" + txtStaffId.Text+"';";
                MySqlCommand MyCommand2 = new MySqlCommand(sql, con);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2.Close();
                MessageBox.Show("modification avec succès");
                txtStaffName.Text = "";
                load();  
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message.ToString());
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sql = "update dentaire.infermier set age='" + txtStaffAge.Text + "' where personnel_id='" + txtStaffId.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(sql, con);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2.Close();
                MessageBox.Show("modification avec succès");
                txtStaffAge.Text = "";
                load();  
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message.ToString());
            }
        }

       

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sql = "update dentaire.infermier set address='" + email.Text + "' where personnel_id='" + txtStaffId.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(sql, con);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2.Close();
                MessageBox.Show("modification avec succès");
                email.Text = "";
                load();  
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message.ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtStaffId.Text = "";
            load();           
        }

        private void btnDeleteStaff_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sql = "delete from dentaire.infermier where personnel_id='" + txtStaffId.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(sql, con);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2.Close();
                MessageBox.Show("infermier suprimé");
                load();  
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message.ToString());
            }
        }

        private void txtStaffId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string sql = "update dentaire.infermier set address='" + email.Text + "' where personnel_id='" + txtStaffId.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(sql, con);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2.Close();
                MessageBox.Show("modification avec succès");
                email.Text = "";
                load();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message.ToString());
            }
        }
    }
}