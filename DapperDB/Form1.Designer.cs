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
            this.btnFindRoles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnFindRolesAndUsers = new System.Windows.Forms.Button();
            this.sendEMail = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRaceCondition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
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
            // btnFindRoles
            // 
            this.btnFindRoles.Location = new System.Drawing.Point(12, 99);
            this.btnFindRoles.Name = "btnFindRoles";
            this.btnFindRoles.Size = new System.Drawing.Size(162, 23);
            this.btnFindRoles.TabIndex = 3;
            this.btnFindRoles.Text = "Find Roles";
            this.btnFindRoles.UseVisualStyleBackColor = true;
            this.btnFindRoles.Click += new System.EventHandler(this.btnFindRoles_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(417, 212);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(212, 230);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(417, 212);
            this.dataGridView2.TabIndex = 5;
            // 
            // btnFindRolesAndUsers
            // 
            this.btnFindRolesAndUsers.Location = new System.Drawing.Point(12, 128);
            this.btnFindRolesAndUsers.Name = "btnFindRolesAndUsers";
            this.btnFindRolesAndUsers.Size = new System.Drawing.Size(162, 23);
            this.btnFindRolesAndUsers.TabIndex = 6;
            this.btnFindRolesAndUsers.Text = "Find Roles And Users";
            this.btnFindRolesAndUsers.UseVisualStyleBackColor = true;
            this.btnFindRolesAndUsers.Click += new System.EventHandler(this.btnFindRolesAndUsers_Click);
            // 
            // sendEMail
            // 
            this.sendEMail.Location = new System.Drawing.Point(16, 15);
            this.sendEMail.Name = "sendEMail";
            this.sendEMail.Size = new System.Drawing.Size(162, 23);
            this.sendEMail.TabIndex = 7;
            this.sendEMail.Text = "Send EMail";
            this.sendEMail.UseVisualStyleBackColor = true;
            this.sendEMail.Click += new System.EventHandler(this.sendEMail_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 44);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(162, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBalance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnRaceCondition);
            this.panel1.Controls.Add(this.sendEMail);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(635, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 430);
            this.panel1.TabIndex = 9;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(76, 113);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(13, 15);
            this.labelBalance.TabIndex = 12;
            this.labelBalance.Text = "0";
            this.labelBalance.Click += new System.EventHandler(this.labelBalance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Balance: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(16, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(580, 199);
            this.listBox1.TabIndex = 10;
            // 
            // btnRaceCondition
            // 
            this.btnRaceCondition.Location = new System.Drawing.Point(16, 87);
            this.btnRaceCondition.Name = "btnRaceCondition";
            this.btnRaceCondition.Size = new System.Drawing.Size(401, 23);
            this.btnRaceCondition.TabIndex = 9;
            this.btnRaceCondition.Text = "Race Condition";
            this.btnRaceCondition.UseVisualStyleBackColor = true;
            this.btnRaceCondition.Click += new System.EventHandler(this.btnRaceCondition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFindRolesAndUsers);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFindRoles);
            this.Controls.Add(this.btnFindRole);
            this.Controls.Add(this.btnAddRole2);
            this.Controls.Add(this.btnAddRole);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddRole;
        private Button btnAddRole2;
        private Button btnFindRole;
        private Button btnFindRoles;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btnFindRolesAndUsers;
        private Button sendEMail;
        private ProgressBar progressBar1;
        private Panel panel1;
        private Label labelBalance;
        private Label label1;
        private ListBox listBox1;
        private Button btnRaceCondition;
    }
}