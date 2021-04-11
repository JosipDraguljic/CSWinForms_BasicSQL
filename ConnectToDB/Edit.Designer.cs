
namespace ConnectToDB
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Edit = new System.Windows.Forms.Button();
            this.tB_Edit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(289, 10);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(149, 29);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // tB_Edit
            // 
            this.tB_Edit.Location = new System.Drawing.Point(12, 12);
            this.tB_Edit.Name = "tB_Edit";
            this.tB_Edit.Size = new System.Drawing.Size(271, 27);
            this.tB_Edit.TabIndex = 2;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 52);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.tB_Edit);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.TextBox tB_Edit;
    }
}