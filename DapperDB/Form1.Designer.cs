namespace DapperDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnAddRole2 = new System.Windows.Forms.Button();
            this.btnFindRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(12, 12);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(162, 23);
            this.btnAddRole.TabIndex = 0;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnAddRole2
            // 
            this.btnAddRole2.Location = new System.Drawing.Point(12, 41);
            this.btnAddRole2.Name = "btnAddRole2";
            this.btnAddRole2.Size = new System.Drawing.Size(162, 23);
            this.btnAddRole2.TabIndex = 1;
            this.btnAddRole2.Text = "Add Role 2";
            this.btnAddRole2.UseVisualStyleBackColor = true;
            this.btnAddRole2.Click += new System.EventHandler(this.btnAddRole2_Click);
            // 
            // btnFindRole
            // 
            this.btnFindRole.Location = new System.Drawing.Point(12, 70);
            this.btnFindRole.Name = "btnFindRole";
            this.btnFindRole.Size = new System.Drawing.Size(162, 23);
            this.btnFindRole.TabIndex = 2;
            this.btnFindRole.Text = "Find Role";
            this.btnFindRole.UseVisualStyleBackColor = true;
            this.btnFindRole.Click += new System.EventHandler(this.btnFindRole_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFindRole);
            this.Controls.Add(this.btnAddRole2);
            this.Controls.Add(this.btnAddRole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddRole;
        private Button btnAddRole2;
        private Button btnFindRole;
    }
}