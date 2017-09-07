using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTest1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //// Authenticate againts the list stored in web.config
            //if (FormsAuthentication.Authenticate(txtUserName.Text, txtPassword.Text))
            //{
            //    // Create the authentication cookie and redirect the user to welcome page
            //    FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, chkBoxRememberMe.Checked);
            //}
            //else
            //{
            //    lblMessage.Text = "Invalid UserName and/or password";
            //}

            //if (AuthenticateUser(txtUserName.Text, txtPassword.Text))
            //{
            //    FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, chkBoxRememberMe.Checked);
            //}
            //else
            //{
            //    lblMessage.Text = "Invalid User Name and/or Password";
            //}

            AuthenticateUser(txtUserName.Text, txtPassword.Text);
        }
        //private bool AuthenticateUser(string username, string password)
        //{
        //    // ConfigurationManager class is in System.Configuration namespace
        //    string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //    // SqlConnection is in System.Data.SqlClient namespace
        //    using (SqlConnection con = new SqlConnection(CS))
        //    {
        //        SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        // FormsAuthentication is in System.Web.Security
        //        string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
        //        // SqlParameter is in System.Data namespace
        //        SqlParameter paramUsername = new SqlParameter("@UserName", username);
        //        SqlParameter paramPassword = new SqlParameter("@Password", EncryptedPassword);

        //        cmd.Parameters.Add(paramUsername);
        //        cmd.Parameters.Add(paramPassword);

        //        con.Open();
        //        int ReturnCode = (int)cmd.ExecuteScalar();
        //        return ReturnCode == 1;
        //    }
        //}
        private void AuthenticateUser(string username, string password)
        {
            // ConfigurationManager class is in System.Configuration namespace
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            // SqlConnection is in System.Data.SqlClient namespace
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Formsauthentication is in system.web.security
                string encryptedpassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");

                //sqlparameter is in System.Data namespace
                SqlParameter paramUsername = new SqlParameter("@UserName", username);
                SqlParameter paramPassword = new SqlParameter("@Password", encryptedpassword);

                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int RetryAttempts = Convert.ToInt32(rdr["RetryAttempts"]);
                    if (Convert.ToBoolean(rdr["AccountLocked"]))
                    {
                        lblMessage.Text = "Account locked. Please contact administrator";
                    }
                    else if (RetryAttempts > 0)
                    {
                        int AttemptsLeft = (4 - RetryAttempts);
                        lblMessage.Text = "Invalid user name and/or password. " +
                            AttemptsLeft.ToString() + "attempt(s) left";
                    }
                    else if (Convert.ToBoolean(rdr["Authenticated"]))
                    {
                        FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, chkBoxRememberMe.Checked);
                    }
                }
            }
        }
    }
}