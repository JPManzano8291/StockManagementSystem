using System.Text;
using MySql.Data.MySqlClient;

namespace StockManagementSystem
{
    public partial class loginForm : Form
    {

        //Creating your connection
        //Initialize your connection
        string conString = "server = 127.0.0.1; user = root; database = stockmanagement; password = ";

        public loginForm()
        {
            InitializeComponent();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            //This is for the check box that if checked, the password will show the text
            tbPassword.UseSystemPasswordChar = !cbShowPass.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Getting the username and password from the textboxes
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text;

            //This will check the text boxes if empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                //This will display when one of the textboxes are empty
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //This will retrieve the password associated with the provided username
            string query = "SELECT password FROM tbl_login WHERE username = @username";

            // Establish MySQL connection
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    //It will open the connection
                    conn.Open();

                    //Creating MySql Command
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        //This will add Username Parameter to query to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@username", username);

                        //Execute the command and get the result (Password)
                        object result = cmd.ExecuteScalar();

                        //This will check if the password was found for the provided username
                        if (result != null)
                        {
                            //This will retrieve the password that was stored in database
                            string storedPassword = result.ToString();

                            //Compare stored password with the provided password
                            if (storedPassword == password)
                            {
                                //If the password was match, the main form will be open
                                frmMain main = new frmMain();
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                //This will be displayed if theres wrong in the input
                                MessageBox.Show("Incorrect Username or Password. Please try again");
                            }
                        }
                        else
                        {
                            //This will be displayed if the user is not found
                            MessageBox.Show("Invalid Username or Password. Please Try Again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //This will display when exception is occured
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //This will exit the application if the X button is pressed.
            Application.Exit();
        }

        private void btnAdd(object sender, EventArgs e)
        {
            //Getting data for Textbox of username and password
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text;

            // Query to check if the username already exists in the database
            string checkQuery = "SELECT COUNT(*) FROM tbl_login WHERE username = @username";

            //Establishing MySQL Connection
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                //Opening the connection
                con.Open();

                //Creating MySQL command to check for exisitng username
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                {
                    //Adding paramaeter to preven SQL Injection
                    checkCmd.Parameters.AddWithValue("@username", username);

                    //This will execute the command will get the result
                    int existingUserCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    //Will check if the username already exist
                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose different username.");
                        //This will exit the method to prevent adding duplicate users
                        return;
                    }
                }
            }

            //MySQL Command in inserting new user to the database
            string query = "INSERT INTO tbl_login (username, password) VALUES (@username, @password)";

            //Establish MySQL connection
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                //This will open the connection
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    //Adding Parameter to prevent MySQL Injection
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    //This will execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //This will show if the user have been created
                        MessageBox.Show("User Added Successfully!");
                        //This will clear the username and password textbox
                        tbUsername.Text = "";
                        tbPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the user. Please Try Again", "Create Account Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
