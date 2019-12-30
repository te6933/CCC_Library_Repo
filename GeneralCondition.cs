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
    public partial class GeneralCondition : Form
    {
        public GeneralCondition()
        {
            InitializeComponent();
        }

        /* Clear Condition Screen */
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_method();
        } //end clear

        private void clear_method()
        {
            txtCondCode.Clear();
            txtDescription.Clear();
        }

        /* Add Condition record */
        private void btnAdd_Click(object sender, EventArgs e)
        {//Set up and run stored procedure only if Customer Name is present.
            if (isDesc())
            {
                string cmdString = "INSERT INTO GeneralConditionTable (ConditionDescription) VALUES (@val1)";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtDescription.Text);

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

        /* Delete Condition record */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are You Sure You Want To Delete This Record?",
               "Important Question",
               MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "DELETE FROM GeneralConditionTable WHERE GeneralConditionCode = " + "@val1";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtCondCode.Text);
                    string condCode = txtCondCode.Text;

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
                        MessageBox.Show("Condition Code " + condCode + " was deleted.");
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

        /* Save Changes to Condition record */
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Save Changes?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "UPDATE GeneralConditionTable SET ConditionDescription = @val1 " +
                                   " WHERE GeneralConditionCode = @val2";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtDescription.Text);
                    comm.Parameters.AddWithValue("@val2", txtCondCode.Text);
                    string condCode = txtCondCode.Text;

                    // try-catch-finally
                    try
                    {
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Refill Lookup dropdown.
                        screen_Load();
                        MessageBox.Show("Condition code " + condCode + " has been saved.");
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
        }//end previous

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneralCondition_Load(object sender, EventArgs e)
        {
            screen_Load();
        }

        private void screen_Load()
        {
            // TODO: This line of code loads data into the 'teamLibraryConditionDatabaseDataSet.GeneralConditionTable' table. You can move, or remove it, as needed.
            this.generalConditionTableTableAdapter.Fill(this.teamLibraryConditionDatabaseDataSet.GeneralConditionTable);
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

        private void txtCondCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void GeneralCondition_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamLibraryConditionDatabaseDataSet.GeneralConditionTable' table. You can move, or remove it, as needed.
            this.generalConditionTableTableAdapter.Fill(this.teamLibraryConditionDatabaseDataSet.GeneralConditionTable);

        }
    }
}