using System.Data;
using MySql.Data.MySqlClient;


namespace StockManagementSystem
{
    public partial class frmMain : Form
    {
        //Creating your connection
        //Initialize your connection
        string conString = "server = 127.0.0.1; user = root; database = stockmanagement; password = ";

        int saveFlag = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        public void showData()
        {
            // View/content string
            string query = "SELECT * FROM tblstocks";
            // Connecting to MySql
            MySqlConnection con = new MySqlConnection(conString);
            // Establishing command
            MySqlCommand cmd = new MySqlCommand(query, con);
            // Establish Execution
            MySqlDataAdapter DA = new MySqlDataAdapter();
            // Execute
            DA.SelectCommand = cmd;
            // Display
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dgvList.DataSource = DT;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void validation(bool code, bool name, bool srp, bool cost, bool quantity, bool date, bool add, bool edit, bool delete, bool cancel, bool save, bool viewStocks)
        {
            //Clear and disable textboxes
            tbProdCode.Enabled = code;
            tbProdName.Enabled = name;
            tbProdSRP.Enabled = srp;
            tbProdCost.Enabled = cost;
            tbProdQuantity.Enabled = quantity;
            tbProdDate.Enabled = date;

            //Disable or Enable Button
            btnAdd.Enabled = add;
            btnEdit.Enabled = edit;
            btnDelete.Enabled = delete;
            btnCancel.Enabled = cancel;
            btnSave.Enabled = save;

            //Table
            dgvList.Enabled = viewStocks;
        }

        public void clearText()
        {
            //This will Clear all of the text in textbox
            tbProdCode.Clear();
            tbProdName.Clear();
            tbProdSRP.Clear();
            tbProdCost.Clear();
            tbProdQuantity.Clear();
            tbProdDate.Clear();
        }

        // ClearText will call to clear all the text box
        // Validation will return the boolean true or false to know if the button, textbox, or datagridview
        // Show Data will be called to show the data in data grid view from database
        private void frmMain_Load(object sender, EventArgs e)
        {
            clearText();
            validation(false, false, false, false, false, false, true, false, false, false, false, true);
            showData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            saveFlag = 0;
            clearText();
            validation(true, true, true, true, true, true, false, false, false, true, true, false);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            saveFlag = 1;
            validation(true, true, true, true, true, true, false, false, false, true, true, true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearText();
            validation(false, false, false, false, false, false, true, false, false, false, false, true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                try
                {
                    if (saveFlag == 0) // Insert operation
                    {
                        string insertQuery = "INSERT INTO tblstocks(product_code, product_name, product_srp, product_cost, product_quantity, product_date) values (@pcode, @pname, @psrp, @pcost, @pquantity, @pdate)";

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                        {
                            // Set parameters for insertion
                            cmd.Parameters.AddWithValue("@pcode", tbProdCode.Text);
                            cmd.Parameters.AddWithValue("@pname", tbProdName.Text);
                            cmd.Parameters.AddWithValue("@psrp", float.Parse(tbProdSRP.Text));
                            cmd.Parameters.AddWithValue("@pcost", float.Parse(tbProdCost.Text));
                            cmd.Parameters.AddWithValue("@pquantity", int.Parse(tbProdQuantity.Text));
                            cmd.Parameters.AddWithValue("@pdate", tbProdDate.Text);

                            int resultset = cmd.ExecuteNonQuery();

                            if (resultset > 0)
                            {
                                MessageBox.Show("Success, Stock has been Created");
                            }
                            else
                            {
                                MessageBox.Show("No Records inserted");
                            }
                        }
                    }
                    else if (saveFlag == 1) // Update operation
                    {
                        string updateQuery = "UPDATE tblstocks SET product_code = @pcode, product_name = @pname, product_srp = @psrp, product_cost = @pcost, product_quantity = @pquantity, product_date = @pdate WHERE product_id = @pid";

                        try
                        {
                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, con))
                            {
                                // Set parameters for update
                                cmd.Parameters.AddWithValue("@pid", lblID.Text);
                                cmd.Parameters.AddWithValue("@pcode", tbProdCode.Text);
                                cmd.Parameters.AddWithValue("@pname", tbProdName.Text);
                                cmd.Parameters.AddWithValue("@psrp", float.Parse(tbProdSRP.Text));
                                cmd.Parameters.AddWithValue("@pcost", float.Parse(tbProdCost.Text));
                                cmd.Parameters.AddWithValue("@pquantity", int.Parse(tbProdQuantity.Text));
                                cmd.Parameters.AddWithValue("@pdate", tbProdDate.Text);

                                int resultset = cmd.ExecuteNonQuery();

                                if (resultset > 0)
                                {
                                    MessageBox.Show("Success, Stock has been Changed");
                                }
                                else
                                {
                                    MessageBox.Show("No records updated");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Log the exception message
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }

            clearText();
            validation(false, false, false, false, false, false, true, false, false, false, false, true);
            showData();
            saveFlag = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //This will define the delete query
            string deleteQuery = "DELETE FROM tblstocks WHERE product_id = @pid";

            // Create a MySqlConnection object and open the connection
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // Create a MySqlCommand object with the delete query and connection
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, con))
                {
                    // Set the parameter for product_id
                    cmd.Parameters.AddWithValue("@pid", lblID.Text);

                    // Execute the delete command and get the number of rows affected
                    int resultset = cmd.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (resultset > 0)
                    {
                        MessageBox.Show("Product Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Deletion Failed");
                    }
                }

                //This will close the connection
                con.Close();
                //Clear text fields, refresh DataGridView, and adjust UI
                clearText();
                showData();
                validation(false, false, false, false, false, false, true, false, false, false, false, true);
            }
        }

        private void dgvList_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                // Assuming columns are in the order: ID, ProdCode, ProdName, ProdSRP, ProdCost, ProdQuantity, ProdDate

                //This will set the product ID, product code, and product name from the selected row
                lblID.Text = dgvList.SelectedRows[0].Cells[0].Value?.ToString() ?? string.Empty;
                tbProdCode.Text = dgvList.SelectedRows[0].Cells[1].Value?.ToString() ?? string.Empty;
                tbProdName.Text = dgvList.SelectedRows[0].Cells[2].Value?.ToString() ?? string.Empty;

                // Handle conversion for float and int fields
                //Product_srp, product_cost, and product_quantity
                float srp;
                if (float.TryParse(dgvList.SelectedRows[0].Cells[3].Value?.ToString(), out srp))
                {
                    tbProdSRP.Text = srp.ToString();
                }
                else
                {
                    tbProdSRP.Text = string.Empty;
                }

                float cost;
                if (float.TryParse(dgvList.SelectedRows[0].Cells[4].Value?.ToString(), out cost))
                {
                    tbProdCost.Text = cost.ToString();
                }
                else
                {
                    tbProdCost.Text = string.Empty;
                }

                int quantity;
                if (int.TryParse(dgvList.SelectedRows[0].Cells[5].Value?.ToString(), out quantity))
                {
                    tbProdQuantity.Text = quantity.ToString();
                }
                else
                {
                    tbProdQuantity.Text = string.Empty;
                }

                //This will set the product date from the selected row
                tbProdDate.Text = dgvList.SelectedRows[0].Cells[6].Value?.ToString() ?? string.Empty;

                //Adjust UI to enable/disable appropriate buttons and text fields
                validation(false, false, false, false, false, false, true, true, true, false, false, true);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Variable for textbox Search
            string searchProduct = tbSearch.Text.Trim();

            // Check if the search text is empty
            if (string.IsNullOrEmpty(searchProduct))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            // SQL query to search for product_name
            string query = "SELECT * FROM tblstocks WHERE product_name LIKE @pname";

            //Creating MySqlConnection
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // Parameterized query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@pname", "%" +  searchProduct + "%");

                    try
                    {
                        //This will open the database connection
                        con.Open();

                        //This will create datatable to store the result
                        DataTable DT = new DataTable();

                        //This will execute the query and will fill the DataTable
                        using (MySqlDataAdapter DA = new MySqlDataAdapter(cmd))
                        {
                            DA.Fill(DT);
                        }

                        //This will bind the DataTable to the DataGridView to display the results
                        dgvList.DataSource = DT;

                    }
                    catch (Exception ex)
                    {
                        // Log the error message for debugging
                        Console.WriteLine("Error executing search query: " + ex.Message);
                        MessageBox.Show("An error occurred while searching. Please try again.");
                    }
                }
            }
        }
    }
}
