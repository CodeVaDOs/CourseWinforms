
namespace Course.Forms
{
    partial class StatysticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.count_users = new System.Windows.Forms.Label();
            this.count_admins = new System.Windows.Forms.Label();
            this.count_tests = new System.Windows.Forms.Label();
            this.count_passed_tests = new System.Windows.Forms.Label();
            this.results_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.results_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість користувачів:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість адміністраторів:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(128, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кількість тестів:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кількість пройдених тестів:";
            // 
            // count_users
            // 
            this.count_users.AutoSize = true;
            this.count_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_users.Location = new System.Drawing.Point(313, 50);
            this.count_users.Margin = new System.Windows.Forms.Padding(6);
            this.count_users.Name = "count_users";
            this.count_users.Size = new System.Drawing.Size(24, 25);
            this.count_users.TabIndex = 5;
            this.count_users.Text = "0";
            // 
            // count_admins
            // 
            this.count_admins.AutoSize = true;
            this.count_admins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_admins.Location = new System.Drawing.Point(313, 87);
            this.count_admins.Margin = new System.Windows.Forms.Padding(6);
            this.count_admins.Name = "count_admins";
            this.count_admins.Size = new System.Drawing.Size(24, 25);
            this.count_admins.TabIndex = 6;
            this.count_admins.Text = "0";
            // 
            // count_tests
            // 
            this.count_tests.AutoSize = true;
            this.count_tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_tests.Location = new System.Drawing.Point(313, 124);
            this.count_tests.Margin = new System.Windows.Forms.Padding(6);
            this.count_tests.Name = "count_tests";
            this.count_tests.Size = new System.Drawing.Size(24, 25);
            this.count_tests.TabIndex = 7;
            this.count_tests.Text = "0";
            // 
            // count_passed_tests
            // 
            this.count_passed_tests.AutoSize = true;
            this.count_passed_tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_passed_tests.Location = new System.Drawing.Point(313, 161);
            this.count_passed_tests.Margin = new System.Windows.Forms.Padding(6);
            this.count_passed_tests.Name = "count_passed_tests";
            this.count_passed_tests.Size = new System.Drawing.Size(24, 25);
            this.count_passed_tests.TabIndex = 8;
            this.count_passed_tests.Text = "0";
            // 
            // results_chart
            // 
            this.results_chart.BackColor = System.Drawing.SystemColors.Control;
            this.results_chart.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.results_chart.BorderlineColor = System.Drawing.SystemColors.WindowFrame;
            this.results_chart.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.results_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.results_chart.Legends.Add(legend1);
            this.results_chart.Location = new System.Drawing.Point(12, 226);
            this.results_chart.Name = "results_chart";
            this.results_chart.Size = new System.Drawing.Size(776, 277);
            this.results_chart.TabIndex = 14;
            this.results_chart.Text = "chart1";
            // 
            // StatysticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.results_chart);
            this.Controls.Add(this.count_passed_tests);
            this.Controls.Add(this.count_tests);
            this.Controls.Add(this.count_admins);
            this.Controls.Add(this.count_users);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatysticForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StatysticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.results_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label count_users;
        private System.Windows.Forms.Label count_admins;
        private System.Windows.Forms.Label count_tests;
        private System.Windows.Forms.Label count_passed_tests;
        private System.Windows.Forms.DataVisualization.Charting.Chart results_chart;
    }
}