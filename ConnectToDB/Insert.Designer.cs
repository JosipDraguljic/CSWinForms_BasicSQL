
namespace ConnectToDB
{
    partial class Insert
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
            this.tB_Insert = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_Insert
            // 
            this.tB_Insert.Location = new System.Drawing.Point(12, 12);
            this.tB_Insert.Name = "tB_Insert";
            this.tB_Insert.Size = new System.Drawing.Size(271, 27);
            this.tB_Insert.TabIndex = 0;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(289, 10);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(149, 29);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 65);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.tB_Insert);
            this.Name = "Insert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Insert;
        private System.Windows.Forms.Button btn_Insert;
    }
}