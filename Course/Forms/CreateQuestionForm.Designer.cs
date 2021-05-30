
namespace Course.Forms
{
    partial class CreateQuestionForm
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
            this.question_field = new System.Windows.Forms.TextBox();
            this.save_question_button = new System.Windows.Forms.Button();
            this.add_answer_button = new System.Windows.Forms.Button();
            this.answers_list_view = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Запитання";
            // 
            // question_field
            // 
            this.question_field.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.question_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question_field.Location = new System.Drawing.Point(12, 35);
            this.question_field.Name = "question_field";
            this.question_field.Size = new System.Drawing.Size(299, 38);
            this.question_field.TabIndex = 8;
            // 
            // save_question_button
            // 
            this.save_question_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save_question_button.Location = new System.Drawing.Point(12, 312);
            this.save_question_button.Name = "save_question_button";
            this.save_question_button.Size = new System.Drawing.Size(299, 49);
            this.save_question_button.TabIndex = 11;
            this.save_question_button.Text = "Зберігти";
            this.save_question_button.UseVisualStyleBackColor = true;
            this.save_question_button.Click += new System.EventHandler(this.save_question_button_Click);
            // 
            // add_answer_button
            // 
            this.add_answer_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_answer_button.Location = new System.Drawing.Point(12, 257);
            this.add_answer_button.Name = "add_answer_button";
            this.add_answer_button.Size = new System.Drawing.Size(299, 49);
            this.add_answer_button.TabIndex = 14;
            this.add_answer_button.Text = "Додати відповідь";
            this.add_answer_button.UseVisualStyleBackColor = true;
            this.add_answer_button.Click += new System.EventHandler(this.add_answer_button_Click);
            // 
            // answers_list_view
            // 
            this.answers_list_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answers_list_view.FullRowSelect = true;
            this.answers_list_view.GridLines = true;
            this.answers_list_view.HideSelection = false;
            this.answers_list_view.Location = new System.Drawing.Point(12, 79);
            this.answers_list_view.MultiSelect = false;
            this.answers_list_view.Name = "answers_list_view";
            this.answers_list_view.Size = new System.Drawing.Size(299, 172);
            this.answers_list_view.TabIndex = 15;
            this.answers_list_view.UseCompatibleStateImageBehavior = false;
            this.answers_list_view.View = System.Windows.Forms.View.List;
            this.answers_list_view.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.answers_list_view_ItemCheck);
            // 
            // CreateQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 373);
            this.Controls.Add(this.answers_list_view);
            this.Controls.Add(this.add_answer_button);
            this.Controls.Add(this.save_question_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question_field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateQuestionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення запитання";
            this.Load += new System.EventHandler(this.CreateQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox question_field;
        private System.Windows.Forms.Button save_question_button;
        private System.Windows.Forms.Button add_answer_button;
        private System.Windows.Forms.ListView answers_list_view;
    }
}