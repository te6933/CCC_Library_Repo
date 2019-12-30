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
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class State_Code : Form
    {
        public State_Code()
        {
            InitializeComponent();
        }

        /* Clear State Record */
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_method();
        }//end clear button

        private void clear_method()
        {
            txtStateCode.Clear();
            txtDescription.Clear();
        }//end clear 

        /* Add State Record */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Set up and run stored procedure only if Customer Name is present.
            if (isDesc())
            {
                string cmdString = "INSERT INTO StateCodeTable (StateCode, StateDescription) VALUES (@val1, @val2)";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtStateCode.Text);
                    comm.Parameters.AddWithValue("@val2", txtDescription.Text);

                    // try-catch-finally
                    try
                    {
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Clear Screen Fields.
                        clear_method();
                        // Refill Lookup dropdown.
                        screen_Load();
                    }//end try
                    catch
                    {
                        //A simple catch.
                        MessageBox.Show("Record could not be created. Please try again");
                    }//end catch
                    finally
                    {
                        //Close the connection.
                        conn.Close();
                    }//end finally
                }
            }//end card id if
        }

        /* Delete State Record */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are You Sure You Want To Delete This Record?",
               "Important Question",
               MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "DELETE FROM StateCodeTable WHERE StateCode = " + "@val1";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtStateCode.Text);
                    string stateCd = txtStateCode.Text;

                    // try-catch-finally
                    try
                    {
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Clear Screen Fields.
                        clear_method();
                        // Refill Lookup dropdown.
                        screen_Load();
                        MessageBox.Show("State Code " + stateCd + " was deleted.");
                    }//end try
                    catch
                    {
                        //A simple catch.
                        MessageBox.Show("Record could not be deleted. Please try again");
                    } //end catch
                    finally
                    {
                        //Close the connection.
                        conn.Close();
                    } // end finally
                }
            } //end if
            else
            {
                MessageBox.Show("Record Not Deleted!");
            } //end else
        }

        /* Save State Record */
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Save Changes?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "UPDATE StateCodeTable SET StateDescription = @val1 " +
                                   " WHERE StateCode = @val2";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtDescription.Text);
                    comm.Parameters.AddWithValue("@val2", txtStateCode.Text);
                    string StateCd = txtStateCode.Text;

                    // try-catch-finally
                    try
                    {
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Refill Lookup dropdown.
                        screen_Load();
                        MessageBox.Show("State code " + StateCd + " has been saved.");
                    }//end try
                    catch
                    {
                        //A simple catch.
                        MessageBox.Show("Record could not be saved. Please try again");
                    } //end catch
                    finally
                    {
                        //Close the connection.
                        conn.Close();
                    } // end finally
                }
            } //end if
            else
            {
                MessageBox.Show("Record Not Saved!");
            } //end else
        }

        /* Return to previous screen */
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void State_Code_Load_1(object sender, EventArgs e)
        {
            screen_Load();
        }

        private void screen_Load()
        {
            // TODO: This line of code loads data into the 'teamLibraryDatabaseDataSet1.StateCodeTable' table. You can move, or remove it, as needed.
            this.stateCodeTableTableAdapter.Fill(this.teamLibraryDatabaseDataSet3.StateCodeTable);

        }

        //Verify that a Description is present.
        private bool isDesc()
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Please enter a Descriptioin.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }

        private void txtStateCode_TextChanged(object sender, EventArgs e)
        {
            //if (txtDescription.Text != cbStateLookup.SelectedItem.ToString())
            //{
            //    btnDelete.Enabled = false;
            //    btnSave.Enabled = false;
            //    btnAdd.Enabled = true;
            //}
            //else
            //{
            //    btnDelete.Enabled = true;
            //    btnSave.Enabled = true;
            //    btnAdd.Enabled = false;
            //}
        }

        //private void State_Code_Load_1(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'teamLibraryDatabaseDataSet3.StateCodeTable' table. You can move, or remove it, as needed.
        //    this.stateCodeTableTableAdapter.Fill(this.teamLibraryDatabaseDataSet3.StateCodeTable);

        //}
    }
}