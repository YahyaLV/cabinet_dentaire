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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            combobox.Items.Add("Adminstrateur");
            combobox.Items.Add("personnel(infermier)");
            combobox.Items.Add("personnel(dentiste)");
        }
        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (combobox.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une option");
            }
            else if (combobox.SelectedItem.Equals("personnel(infermier)"))
            {
                /*StaffWindow objStaffWindow = new StaffWindow();
                objStaffWindow.Show();
                this.Close();*/

                MySqlConnection conn = DBConnect.connectToDb();
                try
                {
                    string q = "select * from dentaire.infermier where name='" + textboxUsername.Text + "' and personnel_password='" + textboxPassword.Password + "';";
                    MySqlCommand MyCommand2 = new MySqlCommand(q, conn);
                    MySqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    if (MyReader2.Read())
                    {
                        MessageBox.Show("connecté avec succès");
                        StaffWindow objStaffWindow = new StaffWindow();
                        objStaffWindow.Show();
                        objStaffWindow.loginAsStaff.Text = textboxUsername.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le nom d'utilisateur ou le mot de passe ne correspondent pas");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           
               
            }
            //dentiste
            else if (combobox.SelectedItem.Equals("personnel(dentiste)"))
            {
                /*StaffWindow objStaffWindow = new StaffWindow();
                objStaffWindow.Show();
                this.Close();*/

                MySqlConnection conn = DBConnect.connectToDb();
                try
                {
                    string q = "select * from dentaire.dentist where name='" + textboxUsername.Text + "' and password='" + textboxPassword.Password + "';";
                    MySqlCommand MyCommand2 = new MySqlCommand(q, conn);
                    MySqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    if (MyReader2.Read())
                    {
                        MessageBox.Show("connecté avec succès");
                        StaffWindow objStaffWindow = new StaffWindow();
                        objStaffWindow.Show();
                        objStaffWindow.loginAsStaff.Text = textboxUsername.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le nom d'utilisateur ou le mot de passe ne correspondent pas");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }



            else if (combobox.SelectedItem.Equals("Adminstrateur"))
            {
                MySqlConnection conn = DBConnect.connectToDb();
                try
                {
                    string q = "select * from dentaire.admin where username='" + textboxUsername.Text + "' and password='" + textboxPassword.Password + "';";
                    MySqlCommand MyCommand2 = new MySqlCommand(q, conn);
                    MySqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();
                    if (MyReader2.Read())
                    {
                        MessageBox.Show("connecté avec succès");
                        AdminWindow objAdminWindow = new AdminWindow();
                        objAdminWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le nom d'utilisateur ou le mot de passe ne correspondent pas");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
          
        }

        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
