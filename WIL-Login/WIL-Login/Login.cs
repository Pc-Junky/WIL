using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WIL_Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //**********************************************************************************************************************************
        private void btnRegister_Click(object sender, EventArgs e)              //Register user button
        {
            this.Hide();                                                        //Hides current form
            //RegisterFormName RegisterForm = new RegisterFormName();           //Create a new instance of the Form class

            //RegisterForm.Show();                                              //Will open Register form
        }
        //**********************************************************************************************************************************
        private void btnSubmit_Click(object sender, EventArgs e)                //Submit button
        {
            bool Valid = false;

            //not tested - reading from the database
            //
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //using (SqlCommand command = new SqlCommand("select * from databaseName where Complete = 0", connection))
            //{
            //    connection.Open();
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            string Name = reader.GetString(0);
            //            string Password = reader.GetString(1);
            //  
            //            if((Name == txtName.Text && Password == txtPassword.Text)
            //            {
            //              Valid = true;      
            //              break;
            //            }
            //        }
            //    }
            //}

            if (Valid)
            {
                MessageBox.Show("Login succesfull");                             //message login worked

                this.Hide();                                                     //hides current form

                //if we add splash screen 
                //
                //Creating thread for BeginSplash Method so it can start and stop   //when successfully logged in, it will start the splash screen
                //Thread thrd = new Thread(new ThreadStart(BeginSplash));
                //thrd.Start();
                //Thread.Sleep(8500);

                //thrd.Abort();                                                    //when timer stops, so will the splash screen

                //HomeFormName HomeForm = new HomeFormName();                    // Create a new instance of the Form class

                //HomeForm.Show();                                             // Shows the Home form
            }
            else
            {
                MessageBox.Show("Login failed /n Please make sure you entered the correct credentials, and try again");   //message if login failed
            }
        }
        //**********************************************************************************************************************************
        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            //new form allowing user to enter his email, and position
            //checks to see if email and position matches
            //then randomize a code
            //send towards his email
            //let him enter matching code
            //if matches allows for editing his password
        }
        //**********************************************************************************************************************************
    }
}
