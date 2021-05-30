
namespace Course.Forms
{
    partial class CreateAnswerForm
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
            this.add_answer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.answer_field = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add_answer
            // 
            this.add_answer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_answer.Location = new System.Drawing.Point(12, 78);
            this.add_answer.Name = "add_answer";
            this.add_answer.Size = new System.Drawing.Size(299, 49);
            this.add_answer.TabIndex = 12;
            this.add_answer.Text = "Зберігти";
            this.add_answer.UseVisualStyleBackColor = true;
            this.add_answer.Click += new System.EventHandler(this.add_answer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Відповідь";
            // 
            // answer_field
            // 
            this.answer_field.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_field.Location = new System.Drawing.Point(12, 31);
            this.answer_field.Name = "answer_field";
            this.answer_field.Size = new System.Drawing.Size(299, 38);
            this.answer_field.TabIndex = 13;
            // 
            // CreateAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 139);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answer_field);
            this.Controls.Add(this.add_answer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAnswerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення відповіді";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answer_field;
    }
}