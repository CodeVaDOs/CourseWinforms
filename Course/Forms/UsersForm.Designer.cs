
namespace Course.Forms
{
    partial class UsersForm
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
            this.users_list_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.users_list_view)).BeginInit();
            this.SuspendLayout();
            // 
            // users_list_view
            // 
            this.users_list_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_list_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_list_view.Location = new System.Drawing.Point(0, 0);
            this.users_list_view.Name = "users_list_view";
            this.users_list_view.RowHeadersWidth = 82;
            this.users_list_view.RowTemplate.Height = 33;
            this.users_list_view.Size = new System.Drawing.Size(1047, 849);
            this.users_list_view.TabIndex = 0;
            this.users_list_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.users_list_view.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.users_list_view_UserAddedRow);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 849);
            this.Controls.Add(this.users_list_view);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users_list_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView users_list_view;
    }
}