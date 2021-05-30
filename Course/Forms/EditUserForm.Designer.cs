
namespace Course.Forms
{
    partial class EditUserForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roleField = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Login";
            // 
            // loginField
            // 
            this.loginField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(12, 68);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(232, 38);
            this.loginField.TabIndex = 18;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(12, 109);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(53, 13);
            this.pass_label.TabIndex = 17;
            this.pass_label.Text = "Password";
            // 
            // passwordField
            // 
            this.passwordField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(12, 125);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(232, 38);
            this.passwordField.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(79, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Edit user";
            // 
            // roleField
            // 
            this.roleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleField.FormattingEnabled = true;
            this.roleField.Location = new System.Drawing.Point(12, 182);
            this.roleField.Name = "roleField";
            this.roleField.Size = new System.Drawing.Size(232, 39);
            this.roleField.TabIndex = 21;
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save_button.Location = new System.Drawing.Point(12, 236);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(232, 49);
            this.save_button.TabIndex = 22;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 290);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.roleField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roleField;
        private System.Windows.Forms.Button save_button;
    }
}