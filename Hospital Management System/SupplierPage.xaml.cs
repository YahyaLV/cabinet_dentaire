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
using System.Drawing;

namespace Hospital_Management_System
{
    /// <summary>
    /// Interaction logic for SupplierPage.xaml
    /// </summary>
    public partial class SupplierPage : Page
    {
        public SupplierPage()
        {
            InitializeComponent();
            load_table();
            fill_combo();
            combo_patient();
        }

        void load_table()
        {
            try
            {
                string sql = "select id,patient,trait,medicament,doze,date from dentaire.ordonance;";
                MySqlConnection con = DBConnect.connectToDb();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(ds);
                datagridSupplier.ItemsSource = ds.Tables[0].DefaultView;
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message.ToString());
            }
            
            
        }

        void fill_combo()
        {
            MySqlConnection conn = DBConnect.connectToDb();
            try
            {
                string Query = "select * from dentaire.traitement;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    string name = MyReader2.GetString(0);
                    comboBox.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //patient
        void combo_patient()
        {
            MySqlConnection conn = DBConnect.connectToDb();
            try
            {
                string Query = "select * from dentaire.patient;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    string name = MyReader2.GetString(0);
                    combopatient.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void btnAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            if (combopatient.SelectedItem.ToString().Equals("") || textBox1.Text.Equals("") || textBox2.Text.Equals("") || comboBox.SelectedItem.ToString().Equals("")
               ) { MessageBox.Show("Merci de compléter tous les champs"); }
            else
            {
                MySqlConnection conn = DBConnect.connectToDb();
                try
                {
                    string Query = "insert into dentaire.ordonance(patient,trait,medicament,doze,date) values('" + combopatient.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + comboBox.Text + "', '" + datepicker.Text + "');";

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                    MySqlDataReader MyReader2;

                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("ordonance ajouté . . .");

                    combopatient.Text = ""; textBox1.Text = ""; textBox2.Text = "";
                    datepicker.Text = "";
                 

                    load_table();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
       
        private void Refresh_Click_1(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = DBConnect.connectToDb();

            try
            {
                string sql = "delete from dentaire.ordonance where id='" + ID.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(sql , conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2.Close();
                MessageBox.Show("ordonnance Suprimé");
                ID.Text = "";
                load_table();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message.ToString());
            }
        }

        private void datagridSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)datagridSupplier.SelectedItems[0];
                ID.Text = row["id"].ToString();
            }
            catch { }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}