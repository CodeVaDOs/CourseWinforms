
namespace Course.Forms
{
    partial class CreateTestForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.test_name_field = new System.Windows.Forms.TextBox();
            this.questions_list_view = new System.Windows.Forms.ListView();
            this.add_question_button = new System.Windows.Forms.Button();
            this.save_test_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // test_name_field
            // 
            this.test_name_field.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.test_name_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_name_field.Location = new System.Drawing.Point(24, 48);
            this.test_name_field.Margin = new System.Windows.Forms.Padding(6);
            this.test_name_field.Name = "test_name_field";
            this.test_name_field.Size = new System.Drawing.Size(504, 69);
            this.test_name_field.TabIndex = 10;
            // 
            // questions_list_view
            // 
            this.questions_list_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questions_list_view.FullRowSelect = true;
            this.questions_list_view.GridLines = true;
            this.questions_list_view.HideSelection = false;
            this.questions_list_view.Location = new System.Drawing.Point(578, 48);
            this.questions_list_view.Margin = new System.Windows.Forms.Padding(6);
            this.questions_list_view.Name = "questions_list_view";
            this.questions_list_view.Size = new System.Drawing.Size(504, 519);
            this.questions_list_view.TabIndex = 12;
            this.questions_list_view.UseCompatibleStateImageBehavior = false;
            this.questions_list_view.View = System.Windows.Forms.View.List;
            this.questions_list_view.SelectedIndexChanged += new System.EventHandler(this.questions_list_view_SelectedIndexChanged);
            // 
            // add_question_button
            // 
            this.add_question_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_question_button.Location = new System.Drawing.Point(578, 610);
            this.add_question_button.Margin = new System.Windows.Forms.Padding(6);
            this.add_question_button.Name = "add_question_button";
            this.add_question_button.Size = new System.Drawing.Size(508, 94);
            this.add_question_button.TabIndex = 13;
            this.add_question_button.Text = "Add question";
            this.add_question_button.UseVisualStyleBackColor = true;
            this.add_question_button.Click += new System.EventHandler(this.add_question_button_Click);
            // 
            // save_test_button
            // 
            this.save_test_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save_test_button.Location = new System.Drawing.Point(24, 610);
            this.save_test_button.Margin = new System.Windows.Forms.Padding(6);
            this.save_test_button.Name = "save_test_button";
            this.save_test_button.Size = new System.Drawing.Size(508, 94);
            this.save_test_button.TabIndex = 14;
            this.save_test_button.Text = "Save";
            this.save_test_button.UseVisualStyleBackColor = true;
            this.save_test_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // CreateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 715);
            this.Controls.Add(this.save_test_button);
            this.Controls.Add(this.add_question_button);
            this.Controls.Add(this.questions_list_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.test_name_field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox test_name_field;
        private System.Windows.Forms.ListView questions_list_view;
        private System.Windows.Forms.Button add_question_button;
        private System.Windows.Forms.Button save_test_button;
    }
}