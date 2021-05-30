
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.WelcomeUser = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test_select_button = new System.Windows.Forms.Button();
            this.test_select_view = new System.Windows.Forms.ListView();
            this.results_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeUser
            // 
            this.WelcomeUser.AutoSize = true;
            this.WelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeUser.Location = new System.Drawing.Point(13, 46);
            this.WelcomeUser.Name = "WelcomeUser";
            this.WelcomeUser.Size = new System.Drawing.Size(122, 24);
            this.WelcomeUser.TabIndex = 1;
            this.WelcomeUser.Text = "Привіт, user!";
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
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.adminToolStripMenuItem.Text = "Меню адміністратора";
            this.adminToolStripMenuItem.Visible = false;
            // 
            // createTestToolStripMenuItem
            // 
            this.createTestToolStripMenuItem.Name = "createTestToolStripMenuItem";
            this.createTestToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.createTestToolStripMenuItem.Text = "Створити тест";
            this.createTestToolStripMenuItem.Click += new System.EventHandler(this.createTestToolStripMenuItem_Click);
            // 
            // analyticToolStripMenuItem
            // 
            this.analyticToolStripMenuItem.Name = "analyticToolStripMenuItem";
            this.analyticToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.analyticToolStripMenuItem.Text = "Статистика";
            this.analyticToolStripMenuItem.Click += new System.EventHandler(this.analyticToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.usersToolStripMenuItem.Text = "Користувачі";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.testsToolStripMenuItem.Text = "Тести";
            this.testsToolStripMenuItem.Click += new System.EventHandler(this.testsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.helpToolStripMenuItem.Text = "Обліковий запиc";
            // 
            // test_select_button
            // 
            this.test_select_button.BackColor = System.Drawing.Color.White;
            this.test_select_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.test_select_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.test_select_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test_select_button.Location = new System.Drawing.Point(346, 328);
            this.test_select_button.Margin = new System.Windows.Forms.Padding(2);
            this.test_select_button.Name = "test_select_button";
            this.test_select_button.Size = new System.Drawing.Size(242, 45);
            this.test_select_button.TabIndex = 11;
            this.test_select_button.Text = "Розпочати тестування";
            this.test_select_button.UseVisualStyleBackColor = false;
            this.test_select_button.Click += new System.EventHandler(this.test_select_button_Click);
            // 
            // test_select_view
            // 
            this.test_select_view.BackColor = System.Drawing.SystemColors.Window;
            this.test_select_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // results_chart
            // 
            this.results_chart.BackColor = System.Drawing.SystemColors.Control;
            this.results_chart.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.results_chart.BorderlineColor = System.Drawing.SystemColors.WindowFrame;
            this.results_chart.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.results_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.results_chart.Legends.Add(legend2);
            this.results_chart.Location = new System.Drawing.Point(17, 148);
            this.results_chart.Name = "results_chart";
            this.results_chart.Size = new System.Drawing.Size(315, 225);
            this.results_chart.TabIndex = 13;
            this.results_chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Результати:";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Редагування";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.results_chart);
            this.Controls.Add(this.test_select_view);
            this.Controls.Add(this.test_select_button);
            this.Controls.Add(this.WelcomeUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyticToolStripMenuItem;
        private System.Windows.Forms.Button test_select_button;
        private System.Windows.Forms.ListView test_select_view;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart results_chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}