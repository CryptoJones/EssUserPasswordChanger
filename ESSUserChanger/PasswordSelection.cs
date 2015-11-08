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

namespace ESSUserChanger
{
    public partial class PasswordSelection : Form

    {
        string myPasswordSelection;
        string Password1 = "owoSsMfoXjtf2oq1jjtSlg==";
        string Salesforce1 = "zednYeI+eUAFPdpjdGdkIA==";
        string Orthman14 = "SNxRqCgbU6SvLsnRHyNIuQ==";
        string GetToWork54 = "yz8cQkS9aW3Nowbt3eiujw==";
        string GoBigRed1 = "pr37vadgTVMlJueDPNUQ4g==";
        string JohnSentMe1 = "fqqPrGhJDXRbmJvTho1pUA==";

        public PasswordSelection()
        {
            InitializeComponent();
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { 
                myPasswordSelection = Password1;
                try
                {
                    string connectionString = "Data Source=server.domain.local;Initial Catalog=AbraEmployeeSelfService;Integrated Security=False;user=ESSSQLAcct;pwd=MyPassword";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("UPDATE dbo.tUSERS SET UserPassword = '" +myPasswordSelection+"' WHERE LEFT(UserAbraSuiteLogicalPrimaryKey, 4) = '" + GlobalVariable.BadgeNumber + "'", connection))
                        {
                            int status = command.ExecuteNonQuery();
                            if (status == 0)
                            {
                                MessageBox.Show("Nothing Updated! Check Employee Number!");
                            }
                            else if (status == 1)
                            {
                                MessageBox.Show("Password set to Password1!");
                            }
                            connection.Close();

                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                 }
            else if (radioButton2.Checked) { 
                myPasswordSelection = Salesforce1;

                try
                {
                    string connectionString = "Data Source=server.domain.local;Initial Catalog=AbraEmployeeSelfService;Integrated Security=False;user=ESSSQLAcct;pwd=MyPassword";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("UPDATE dbo.tUSERS SET UserPassword = '" + myPasswordSelection + "' WHERE LEFT(UserAbraSuiteLogicalPrimaryKey, 4) = '" + GlobalVariable.BadgeNumber + "'", connection))
                        {
                            int status = command.ExecuteNonQuery();
                            if (status == 0)
                            {
                                MessageBox.Show("Nothing Updated! Check Employee Number!");
                            }
                            else if (status == 1)
                            {
                                MessageBox.Show("Password set to Salesforce1!");
                            }
                            connection.Close();
                            this.Close();

                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButton3.Checked) { 
                myPasswordSelection = Orthman14;
                try
                {
                    string connectionString = "Data Source=server.domain.local;Initial Catalog=AbraEmployeeSelfService;Integrated Security=False;user=ESSSQLAcct;pwd=MyPassword";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("UPDATE dbo.tUSERS SET UserPassword = '" + myPasswordSelection + "' WHERE LEFT(UserAbraSuiteLogicalPrimaryKey, 4) = '" + GlobalVariable.BadgeNumber + "'", connection))
                        {
                            int status = command.ExecuteNonQuery();
                            if (status == 0)
                            {
                                MessageBox.Show("Nothing Updated! Check Employee Number!");
                            }
                            else if (status == 1)
                            {
                                MessageBox.Show("Password set to Orthman14!");
                            }
                            connection.Close();
                            this.Close();

                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            else if (radioButton4.Checked) { 
                myPasswordSelection = GetToWork54;
                try
                {
                    string connectionString = "Data Source=server.domain.local;Initial Catalog=AbraEmployeeSelfService;Integrated Security=False;user=ESSSQLAcct;pwd=MyPassword";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("UPDATE dbo.tUSERS SET UserPassword = '" + myPasswordSelection + "' WHERE LEFT(UserAbraSuiteLogicalPrimaryKey, 4) = '" + GlobalVariable.BadgeNumber + "'", connection))
                        {
                            int status = command.ExecuteNonQuery();
                            if (status == 0)
                            {
                                MessageBox.Show("Nothing Updated! Check Employee Number!");
                            }
                            else if (status == 1)
                            {
                                MessageBox.Show("Password set to GetToWork54!");
                            }
                            connection.Close();
                            this.Close();

                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }; 
            }
            else if (radioButton5.Checked) { 
                myPasswordSelection = GoBigRed1;
                try
                {
                    string connectionString = "Data Source=server.domain.local;Initial Catalog=AbraEmployeeSelfService;Integrated Security=False;user=ESSSQLAcct;pwd=MyPassword";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("UPDATE dbo.tUSERS SET UserPassword = '" + myPasswordSelection + " WHERE LEFT(UserAbraSuiteLogicalPrimaryKey, 4) = '" + GlobalVariable.BadgeNumber + "'", connection))
                        {
                            int status = command.ExecuteNonQuery();
                            if (status == 0)
                            {
                                MessageBox.Show("Nothing Updated! Check Employee Number!");
                            }
                            else if (status == 1)
                            {
                                MessageBox.Show("Password set to GoBigRed1!");
                            }
                            connection.Close();
                            this.Close();

                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButton6.Checked) { 
                myPasswordSelection = JohnSentMe1;
                try
                {
                    string connectionString = "Data Source=server.domain.local;Initial Catalog=AbraEmployeeSelfService;Integrated Security=False;user=ESSSQLAcct;pwd=MyPassword";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("UPDATE dbo.tUSERS SET UserPassword = '" + myPasswordSelection + "' WHERE LEFT(UserAbraSuiteLogicalPrimaryKey, 4) = '" + GlobalVariable.BadgeNumber + "'", connection))
                        {
                            int status = command.ExecuteNonQuery();
                            if (status == 0)
                            {
                                MessageBox.Show("Nothing Updated! Check Employee Number!");
                            }
                            else if (status == 1)
                            {
                                MessageBox.Show("Password set to JohnSentMe1!");
                            }
                            connection.Close();
                            this.Close();

                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
         else { MessageBox.Show("No Value Selected"); }   
        
        }
    }
}
