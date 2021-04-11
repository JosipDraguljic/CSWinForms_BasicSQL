
namespace ConnectToDB
{
    partial class Fm_connect
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_connect = new System.Windows.Forms.Button();
            this.tB_ServerName = new System.Windows.Forms.TextBox();
            this.tB_DB_Name = new System.Windows.Forms.TextBox();
            this.tB_UserName = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.lbl_ServerName = new System.Windows.Forms.Label();
            this.lbl_DBName = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 293);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(194, 29);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect to Database";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tB_ServerName
            // 
            this.tB_ServerName.AccessibleDescription = "";
            this.tB_ServerName.AccessibleName = "";
            this.tB_ServerName.Location = new System.Drawing.Point(11, 32);
            this.tB_ServerName.Name = "tB_ServerName";
            this.tB_ServerName.Size = new System.Drawing.Size(195, 27);
            this.tB_ServerName.TabIndex = 1;
            // 
            // tB_DB_Name
            // 
            this.tB_DB_Name.Location = new System.Drawing.Point(12, 97);
            this.tB_DB_Name.Name = "tB_DB_Name";
            this.tB_DB_Name.Size = new System.Drawing.Size(194, 27);
            this.tB_DB_Name.TabIndex = 2;
            // 
            // tB_UserName
            // 
            this.tB_UserName.Location = new System.Drawing.Point(11, 173);
            this.tB_UserName.Name = "tB_UserName";
            this.tB_UserName.Size = new System.Drawing.Size(195, 27);
            this.tB_UserName.TabIndex = 3;
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(12, 251);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(194, 27);
            this.tB_Password.TabIndex = 4;
            // 
            // lbl_ServerName
            // 
            this.lbl_ServerName.AutoSize = true;
            this.lbl_ServerName.Location = new System.Drawing.Point(11, 9);
            this.lbl_ServerName.Name = "lbl_ServerName";
            this.lbl_ServerName.Size = new System.Drawing.Size(295, 20);
            this.lbl_ServerName.TabIndex = 5;
            this.lbl_ServerName.Text = "Data Source(Computer name\\Server name)";
            // 
            // lbl_DBName
            // 
            this.lbl_DBName.AutoSize = true;
            this.lbl_DBName.Location = new System.Drawing.Point(11, 74);
            this.lbl_DBName.Name = "lbl_DBName";
            this.lbl_DBName.Size = new System.Drawing.Size(113, 20);
            this.lbl_DBName.TabIndex = 6;
            this.lbl_DBName.Text = "Database name";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(11, 150);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(75, 20);
            this.lbl_Username.TabIndex = 7;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(11, 228);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(70, 20);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Password";
            // 
            // Fm_connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 333);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_DBName);
            this.Controls.Add(this.lbl_ServerName);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_UserName);
            this.Controls.Add(this.tB_DB_Name);
            this.Controls.Add(this.tB_ServerName);
            this.Controls.Add(this.btn_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Fm_connect";
            this.Text = "Connect To Your existing Database ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tB_ServerName;
        private System.Windows.Forms.TextBox tB_DB_Name;
        private System.Windows.Forms.TextBox tB_UserName;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.Label lbl_ServerName;
        private System.Windows.Forms.Label lbl_DBName;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
    }
}

