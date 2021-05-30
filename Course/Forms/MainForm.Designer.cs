
namespace Course.Forms
{
    partial class MainForm
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
            this.WelcomeUser = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.count_tests = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.count_users = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.count_admins = new System.Windows.Forms.Label();
            this.test_select_button = new System.Windows.Forms.Button();
            this.test_select_view = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeUser
            // 
            this.WelcomeUser.AutoSize = true;
            this.WelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeUser.Location = new System.Drawing.Point(13, 46);
            this.WelcomeUser.Name = "WelcomeUser";
            this.WelcomeUser.Size = new System.Drawing.Size(91, 24);
            this.WelcomeUser.TabIndex = 1;
            this.WelcomeUser.Text = "Welcome";
            this.WelcomeUser.Click += new System.EventHandler(this.WelcomeUser_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTestToolStripMenuItem,
            this.analyticToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.adminToolStripMenuItem.Text = "Admin menu";
            this.adminToolStripMenuItem.Visible = false;
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // createTestToolStripMenuItem
            // 
            this.createTestToolStripMenuItem.Name = "createTestToolStripMenuItem";
            this.createTestToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.createTestToolStripMenuItem.Text = "Create test";
            this.createTestToolStripMenuItem.Click += new System.EventHandler(this.createTestToolStripMenuItem_Click);
            // 
            // analyticToolStripMenuItem
            // 
            this.analyticToolStripMenuItem.Name = "analyticToolStripMenuItem";
            this.analyticToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.analyticToolStripMenuItem.Text = "Statistics";
            this.analyticToolStripMenuItem.Click += new System.EventHandler(this.analyticToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.testsToolStripMenuItem.Text = "Tests";
            this.testsToolStripMenuItem.Click += new System.EventHandler(this.testsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // count_tests
            // 
            this.count_tests.AutoSize = true;
            this.count_tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_tests.Location = new System.Drawing.Point(128, 87);
            this.count_tests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count_tests.Name = "count_tests";
            this.count_tests.Size = new System.Drawing.Size(18, 20);
            this.count_tests.TabIndex = 4;
            this.count_tests.Text = "0";
            this.count_tests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count tests: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Count users: ";
            // 
            // count_users
            // 
            this.count_users.AutoSize = true;
            this.count_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_users.Location = new System.Drawing.Point(128, 116);
            this.count_users.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count_users.Name = "count_users";
            this.count_users.Size = new System.Drawing.Size(18, 20);
            this.count_users.TabIndex = 6;
            this.count_users.Text = "0";
            this.count_users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Count admins: ";
            // 
            // count_admins
            // 
            this.count_admins.AutoSize = true;
            this.count_admins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_admins.Location = new System.Drawing.Point(128, 146);
            this.count_admins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count_admins.Name = "count_admins";
            this.count_admins.Size = new System.Drawing.Size(18, 20);
            this.count_admins.TabIndex = 8;
            this.count_admins.Text = "0";
            this.count_admins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // test_select_button
            // 
            this.test_select_button.Location = new System.Drawing.Point(346, 328);
            this.test_select_button.Margin = new System.Windows.Forms.Padding(2);
            this.test_select_button.Name = "test_select_button";
            this.test_select_button.Size = new System.Drawing.Size(240, 45);
            this.test_select_button.TabIndex = 11;
            this.test_select_button.Text = "Start";
            this.test_select_button.UseVisualStyleBackColor = true;
            this.test_select_button.Click += new System.EventHandler(this.test_select_button_Click);
            // 
            // test_select_view
            // 
            this.test_select_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_select_view.FullRowSelect = true;
            this.test_select_view.GridLines = true;
            this.test_select_view.HideSelection = false;
            this.test_select_view.Location = new System.Drawing.Point(346, 46);
            this.test_select_view.Margin = new System.Windows.Forms.Padding(2);
            this.test_select_view.Name = "test_select_view";
            this.test_select_view.Size = new System.Drawing.Size(242, 272);
            this.test_select_view.TabIndex = 12;
            this.test_select_view.UseCompatibleStateImageBehavior = false;
            this.test_select_view.View = System.Windows.Forms.View.List;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 379);
            this.Controls.Add(this.test_select_view);
            this.Controls.Add(this.test_select_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.count_admins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count_users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count_tests);
            this.Controls.Add(this.WelcomeUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label count_tests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label count_users;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label count_admins;
        private System.Windows.Forms.ToolStripMenuItem analyticToolStripMenuItem;
        private System.Windows.Forms.Button test_select_button;
        private System.Windows.Forms.ListView test_select_view;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
    }
}