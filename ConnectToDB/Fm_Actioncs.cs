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
    public partial class Fm_Actioncs : Form
    {
        private Fm_connect fmConnect;
        private SqlConnection conn;
        string conString;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            fmConnect.Show();
        }
        public Fm_Actioncs(Fm_connect fm_Connect, string connectionString)
        {
            InitializeComponent();
            fmConnect = new Fm_connect();
            fmConnect = fm_Connect;
            conString = connectionString;

            conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.tbl_Name", conn);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                ListViewItem item;
                while (reader.Read())
                {
                    item = new ListViewItem(reader.GetValue(0).ToString());
                    item.SubItems.Add(reader.GetValue(1).ToString());
                    listView1.Items.Add(item);
                }
            }

            conn.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach  (int i in listView1.SelectedIndices)
            {
                string test = listView1.Items[i].Text;
                listView1.Items.Remove(listView1.Items[i]);
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.tbl_Name WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(test));
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert(conString, listView1);
            insert.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(listView1, conString);
            edit.ShowDialog();
        }
    }

}
