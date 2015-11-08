using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace ESSUserChanger
{
 

    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            Thread PThread = new Thread(new ThreadStart(ShowSplash));
            PThread.Start();
            Thread.Sleep(3000);
            PThread.Abort();
            Thread.Sleep(1000);


        }

        private void ShowSplash()
        {
            SpaceScreen sc = new SpaceScreen();
            sc.ShowDialog();
        }

       public void UnlockAccount()
        {
            try
            {
                string connectionString = "Data Source=OMIW2310.orthman.local;Initial Catalog=AbraEmployeeSelfService;Integrated Security=False;user=sa;pwd=2000";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE dbo.tUSERS SET UserUnsuccessfulLoginCount = 0, UserLockoutInd = 0 WHERE LEFT(UserAbraSuiteLogicalPrimaryKey, 4) = '" + GlobalVariable.BadgeNumber + "'", connection))
                    {
                        int status = command.ExecuteNonQuery();
                        if (status == 0)
                        {
                        MessageBox.Show("Nothing Updated! Check Employee Number!");
                        } 
                        else if (status == 1){
                        MessageBox.Show("Account Unlocked!");
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
        private void ChangePassword()
        {
            PasswordSelection PS = new PasswordSelection();
            PS.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       public void button1_Click(object sender, EventArgs e)
        {
            GlobalVariable.BadgeNumber = textBox1.Text;
            
           
            if (GlobalVariable.BadgeNumber == "")
            {
                 MessageBox.Show("Badge number cannot be empty!");
                 
            }
            else if (radioButton1.Checked || radioButton2.Checked)
            {
                
               if (radioButton2.Checked)
               {
                   
                   ChangePassword();
                   
               } 
               else
               {
                   
                   UnlockAccount();
                   
               }
            } 
            else 
            {
                MessageBox.Show("You must choose a function!");
                
            }
        }
    }

    public class GlobalVariable
    {
        static public string BadgeNumber = null;

    }
    
}
