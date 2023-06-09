﻿using System;
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
    /// Interaction logic for AdmitPatientPage.xaml
    /// </summary>
    public partial class AdmitPatientPage : Page
    {

        public AdmitPatientPage()
        {
            InitializeComponent();
            load_blood_group();
            load_doctor_name();
            load_disease();

            DateTime dt1;
            dt1 = DateTime.Now.Date;
        }

        public string docDept = "";
        public string docId = "";

        public MySqlConnection conn = DBConnect.connectToDb();

        void load_disease()
        {
            try
            {
                string Query = "select etape from dentaire.etape_rdv;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    string name = MyReader2.GetString(0);
                    comboboxDisease.Items.Add(name);
                }
                MyReader2.Close();
            }
            catch { }
        }

        void load_blood_group()
        {
            try
            {
                string Query = "select * from dentaire.traitement;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    string name = MyReader2.GetString(0);
                    comboboxBloodGroup.Items.Add(name);
                }
                MyReader2.Close();
            }
            catch { }
        }

        void load_doctor_name()
        {
            try
            {
                string Query = "select name from dentaire.dentist;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    string name = MyReader2.GetString(0);
                    this.comboboxDoctorName.Items.Add(name);
                }
                MyReader2.Close();
            }
            catch { }
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void comboboxDoctorName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ///////Loading Doctor Department Value
            try
            {
                // string Query = "select id,department from user.doctor where name='" + comboboxDoctorName.SelectedItem.ToString() + "';";
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);

                // MyReader2 = MyCommand2.ExecuteReader();

                /*   while (MyReader2.Read())
                   {

                       docId = MyReader2.GetString(0);
                       docDept = MyReader2.GetString(1);
                       //textboxDoctorDept.Text = docDept;
                   }
                   MyReader2.Close();*/

                /* string Query1 = "select department from user.doctor where name='" + comboboxDoctorName.SelectedItem.ToString() + "';";
                 MySqlCommand MyCommand = new MySqlCommand(Query, conn);
                 MySqlDataReader MyReader;
                 MyReader = MyCommand.ExecuteReader();
                 MyReader.Close();
                 //assd.IsEnabled = true;
                */
            }
            catch { }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Check if the selected date and doctor are already in the database
                string checkQuery = "SELECT COUNT(*) FROM dentaire.patient WHERE date_rdv = '" + datepicker.SelectedDate + "'AND date_rdv2 = '" + datepicker_Copy + "' AND doc_name = '" + comboboxDoctorName.SelectedItem.ToString() + "'";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, conn);
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    // Show an error message if the selected date and doctor are already in the database
                    MessageBox.Show("Cette date et ce dentist sont déjà réservés. Veuillez sélectionner une date ou un dentist différent.");
                }
                else
                {
                    string Query = "insert into dentaire.patient values('" + patient_name.Text + "','" + patient_age.Text + "','" + patient_contact_no.Text + "','" + comboboxBloodGroup.SelectedItem.ToString() + "','" + comboboxDisease.SelectedItem.ToString() + "','" + comboboxDoctorName.SelectedItem.ToString() + "','" + datepicker + "','" + datepicker_Copy + "');";
                    MySqlCommand MyCommand = new MySqlCommand(Query, conn);
                    MySqlDataReader MyReader;
                    MyReader = MyCommand.ExecuteReader();
                    MyReader.Close();



                    MessageBox.Show("Patient ajouté!");

                    patient_name.Text = ""; patient_contact_no.Text = "";
                    comboboxBloodGroup.Items.Clear(); comboboxDoctorName.Items.Clear(); comboboxDisease.Items.Clear();
                    //  textboxDoctorDept.Text = "";
                    load_blood_group(); load_disease(); load_doctor_name();

                    patient_name.IsEnabled = false; patient_contact_no.IsEnabled = false;
                    comboboxBloodGroup.IsEnabled = false; comboboxDoctorName.IsEnabled = false; comboboxDisease.IsEnabled = false;
                    //      textboxDoctorDept.IsEnabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } 

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void patient_age_TextChanged(object sender, TextChangedEventArgs e)
        {
            comboboxBloodGroup.IsEnabled = true;
        }

        private void patient_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            //patient_age.IsEnabled = true;
        }

        private void comboboxBloodGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //patient_address.IsEnabled = true;
        }

        private void patient_address_TextChanged(object sender, TextChangedEventArgs e)
        {
            comboboxDisease.IsEnabled = true;
        }

        private void patient_contact_no_TextChanged(object sender, TextChangedEventArgs e)
        {
            patient_name.IsEnabled = true;
        }

        private void comboboxDisease_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboboxDoctorName.IsEnabled = true;
        }
    }
}
