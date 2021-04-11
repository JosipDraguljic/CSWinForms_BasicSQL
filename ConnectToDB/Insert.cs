using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectToDB
{
    public partial class Insert : Form
    {
        private SqlConnection conn;
        ListView lv1;
        public Insert(string connString, ListView lv)
        {
            InitializeComponent();
            lv1 = lv;
            conn = new SqlConnection(connString);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tbl_Name(Name) VALUES(@Name)", conn);
            cmd.Parameters.AddWithValue("@Name", tB_Insert.Text);
            cmd.ExecuteNonQuery();

            lv1.Items.Clear();
            lv1.Refresh();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.tbl_Name", conn);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                ListViewItem item;
                while (reader.Read())
                {
                    item = new ListViewItem(reader.GetValue(0).ToString());
                    item.SubItems.Add(reader.GetValue(1).ToString());
                    lv1.Items.Add(item);
                }
            }
            conn.Close();
        }
    }
}
