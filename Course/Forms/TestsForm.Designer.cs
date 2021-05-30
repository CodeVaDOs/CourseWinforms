
namespace Course.Forms
{
    partial class TestsForm
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
            this.tests_list_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tests_list_view)).BeginInit();
            this.SuspendLayout();
            // 
            // tests_list_view
            // 
            this.tests_list_view.AllowUserToAddRows = false;
            this.tests_list_view.AllowUserToDeleteRows = false;
            this.tests_list_view.AllowUserToOrderColumns = true;
            this.tests_list_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tests_list_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tests_list_view.Location = new System.Drawing.Point(0, 0);
            this.tests_list_view.Name = "tests_list_view";
            this.tests_list_view.ReadOnly = true;
            this.tests_list_view.Size = new System.Drawing.Size(524, 441);
            this.tests_list_view.TabIndex = 0;
            this.tests_list_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tests_list_view_CellDoubleClick);
            // 
            // TestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 441);
            this.Controls.Add(this.tests_list_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список тестів";
            this.Load += new System.EventHandler(this.TestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tests_list_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tests_list_view;
    }
}