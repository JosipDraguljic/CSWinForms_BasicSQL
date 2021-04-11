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

namespace ConnectToDB
{
    public partial class Fm_connect : Form
    {
        private string connectionString;
        public Fm_connect()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //DataSource = @"LAPTOP-DNBB2GN8\SQLEXPRESS";
            //DBName = "test";
            //UserName = "sa";
            //UserPassword = "Kristo4ever+";

            connectionString = "Data Source=" + tB_ServerName.Text + ";Initial Catalog=" + tB_DB_Name.Text + ";User ID=" + tB_UserName.Text + ";Password=" + tB_Password.Text;
           
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                Fm_Actioncs fmActions;
                try
                {
                    cnn.Open();
                    fmActions = new Fm_Actioncs(this, connectionString);
                    fmActions.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("failed: " + ex.ToString());
                }
                finally
                {
                    cnn.Close();
                }
            }
        }
    }
}
