
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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.count_tests = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.count_users = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.count_admins = new System.Windows.Forms.Label();
            this.test_select_button = new System.Windows.Forms.Button();
            this.test_select_view = new System.Windows.Forms.ListView();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeUser
            // 
            this.WelcomeUser.AutoSize = true;
            this.WelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeUser.Location = new System.Drawing.Point(26, 88);
            this.WelcomeUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WelcomeUser.Name = "WelcomeUser";
            this.WelcomeUser.Size = new System.Drawing.Size(173, 42);
            this.WelcomeUser.TabIndex = 1;
            this.WelcomeUser.Text = "Welcome";
            this.WelcomeUser.Click += new System.EventHandler(this.WelcomeUser_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 42);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTestToolStripMenuItem,
            this.analyticToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.adminToolStripMenuItem.Text = "Admin menu";
            this.adminToolStripMenuItem.Visible = false;
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // createTestToolStripMenuItem
            // 
            this.createTestToolStripMenuItem.Name = "createTestToolStripMenuItem";
            this.createTestToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.createTestToolStripMenuItem.Text = "Create test";
            this.createTestToolStripMenuItem.Click += new System.EventHandler(this.createTestToolStripMenuItem_Click);
            // 
            // analyticToolStripMenuItem
            // 
            this.analyticToolStripMenuItem.Name = "analyticToolStripMenuItem";
            this.analyticToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.analyticToolStripMenuItem.Text = "Statistics";
            this.analyticToolStripMenuItem.Click += new System.EventHandler(this.analyticToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // count_tests
            // 
            this.count_tests.AutoSize = true;
            this.count_tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_tests.Location = new System.Drawing.Point(257, 168);
            this.count_tests.Name = "count_tests";
            this.count_tests.Size = new System.Drawing.Size(35, 37);
            this.count_tests.TabIndex = 4;
            this.count_tests.Text = "0";
            this.count_tests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count tests: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Count users: ";
            // 
            // count_users
            // 
            this.count_users.AutoSize = true;
            this.count_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_users.Location = new System.Drawing.Point(257, 224);
            this.count_users.Name = "count_users";
            this.count_users.Size = new System.Drawing.Size(35, 37);
            this.count_users.TabIndex = 6;
            this.count_users.Text = "0";
            this.count_users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Count admins: ";
            // 
            // count_admins
            // 
            this.count_admins.AutoSize = true;
            this.count_admins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_admins.Location = new System.Drawing.Point(257, 281);
            this.count_admins.Name = "count_admins";
            this.count_admins.Size = new System.Drawing.Size(35, 37);
            this.count_admins.TabIndex = 8;
            this.count_admins.Text = "0";
            this.count_admins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // test_select_button
            // 
            this.test_select_button.Location = new System.Drawing.Point(693, 630);
            this.test_select_button.Name = "test_select_button";
            this.test_select_button.Size = new System.Drawing.Size(481, 87);
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
            this.test_select_view.Location = new System.Drawing.Point(693, 88);
            this.test_select_view.Name = "test_select_view";
            this.test_select_view.Size = new System.Drawing.Size(481, 520);
            this.test_select_view.TabIndex = 12;
            this.test_select_view.UseCompatibleStateImageBehavior = false;
            this.test_select_view.View = System.Windows.Forms.View.List;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 729);
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
            this.Margin = new System.Windows.Forms.Padding(6);
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
    }
}