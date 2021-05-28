
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
            this.add_question = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Question";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.question_field.TextChanged += new System.EventHandler(this.login_field_TextChanged);
            // 
            // add_question
            // 
            this.add_question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_question.Location = new System.Drawing.Point(12, 312);
            this.add_question.Name = "add_question";
            this.add_question.Size = new System.Drawing.Size(299, 49);
            this.add_question.TabIndex = 11;
            this.add_question.Text = "Save";
            this.add_question.UseVisualStyleBackColor = true;
            this.add_question.Click += new System.EventHandler(this.add_question_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(299, 172);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CreateQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 373);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question_field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create question";
            this.Load += new System.EventHandler(this.CreateTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox question_field;
        private System.Windows.Forms.Button add_question;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}