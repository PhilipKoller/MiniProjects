
namespace DataConnector
{
    partial class DataConnectorForm
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.saveTypeLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.textFileCheckBox = new System.Windows.Forms.CheckBox();
            this.sqlTextBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(133, 37);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(764, 93);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Text = "Username";
            // 
            // submitButton
            // 
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.submitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Black;
            this.submitButton.Location = new System.Drawing.Point(163, 594);
            this.submitButton.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(654, 154);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // saveTypeLabel
            // 
            this.saveTypeLabel.AutoSize = true;
            this.saveTypeLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTypeLabel.Location = new System.Drawing.Point(269, 464);
            this.saveTypeLabel.Name = "saveTypeLabel";
            this.saveTypeLabel.Size = new System.Drawing.Size(245, 65);
            this.saveTypeLabel.TabIndex = 22;
            this.saveTypeLabel.Text = "Save Type:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(133, 182);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(764, 93);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(133, 322);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(764, 93);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Text = "Email";
            // 
            // textFileCheckBox
            // 
            this.textFileCheckBox.AutoSize = true;
            this.textFileCheckBox.Checked = true;
            this.textFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.textFileCheckBox.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFileCheckBox.Location = new System.Drawing.Point(537, 432);
            this.textFileCheckBox.Name = "textFileCheckBox";
            this.textFileCheckBox.Size = new System.Drawing.Size(211, 69);
            this.textFileCheckBox.TabIndex = 23;
            this.textFileCheckBox.Text = "Text File";
            this.textFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // sqlTextBox
            // 
            this.sqlTextBox.AutoSize = true;
            this.sqlTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlTextBox.Location = new System.Drawing.Point(537, 490);
            this.sqlTextBox.Name = "sqlTextBox";
            this.sqlTextBox.Size = new System.Drawing.Size(335, 69);
            this.sqlTextBox.TabIndex = 24;
            this.sqlTextBox.Text = "SQL Database";
            this.sqlTextBox.UseVisualStyleBackColor = true;
            // 
            // DataConnectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 65F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 802);
            this.Controls.Add(this.sqlTextBox);
            this.Controls.Add(this.textFileCheckBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.saveTypeLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.usernameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.Name = "DataConnectorForm";
            this.Text = "DataConnectorDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label saveTypeLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox textFileCheckBox;
        private System.Windows.Forms.CheckBox sqlTextBox;
    }
}

