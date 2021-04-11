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
    public partial class Edit : Form
    {
        private ListView lv1;
        private SqlConnection conn;
        public Edit(ListView _lv1, string _connString)
        {
            InitializeComponent();
            conn = new SqlConnection(_connString);
            lv1 = _lv1;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            foreach (int i in lv1.SelectedIndices)
            {
                string test = lv1.Items[i].Text;
                lv1.Items.Remove(lv1.Items[i]);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE dbo.tbl_Name SET Name = @Name WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@Name", tB_Edit.Text);
                cmd.Parameters.AddWithValue("@ID", int.Parse(test));
                cmd.ExecuteNonQuery();
            }

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
            this.Close();
        }
    }
}
