
namespace Course.Forms
{
    partial class TestingForm
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
            this.test_answers_view = new System.Windows.Forms.ListView();
            this.answer_button = new System.Windows.Forms.Button();
            this.question_title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // test_answers_view
            // 
            this.test_answers_view.BackColor = System.Drawing.SystemColors.Control;
            this.test_answers_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.test_answers_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_answers_view.FullRowSelect = true;
            this.test_answers_view.GridLines = true;
            this.test_answers_view.HideSelection = false;
            this.test_answers_view.Location = new System.Drawing.Point(6, 85);
            this.test_answers_view.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.test_answers_view.Name = "test_answers_view";
            this.test_answers_view.Size = new System.Drawing.Size(350, 232);
            this.test_answers_view.TabIndex = 0;
            this.test_answers_view.UseCompatibleStateImageBehavior = false;
            this.test_answers_view.View = System.Windows.Forms.View.List;
            // 
            // answer_button
            // 
            this.answer_button.Location = new System.Drawing.Point(6, 332);
            this.answer_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answer_button.Name = "answer_button";
            this.answer_button.Size = new System.Drawing.Size(350, 55);
            this.answer_button.TabIndex = 1;
            this.answer_button.Text = "Відповісти";
            this.answer_button.UseVisualStyleBackColor = true;
            this.answer_button.Click += new System.EventHandler(this.answer_button_Click);
            // 
            // question_title
            // 
            this.question_title.BackColor = System.Drawing.SystemColors.Control;
            this.question_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.question_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question_title.Location = new System.Drawing.Point(6, 10);
            this.question_title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.question_title.Multiline = true;
            this.question_title.Name = "question_title";
            this.question_title.Size = new System.Drawing.Size(356, 64);
            this.question_title.TabIndex = 2;
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 394);
            this.Controls.Add(this.question_title);
            this.Controls.Add(this.answer_button);
            this.Controls.Add(this.test_answers_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестування";
            this.Load += new System.EventHandler(this.TestingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView test_answers_view;
        private System.Windows.Forms.Button answer_button;
        private System.Windows.Forms.TextBox question_title;
    }
}