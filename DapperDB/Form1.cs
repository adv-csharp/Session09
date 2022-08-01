using System.Data.SqlClient;
using Dapper;

namespace DapperDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string connString = "data source=.;initial catalog=140102ef2;integrated security=True;multipleactiveresultsets=True;application name=Session09";
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            /*
            * 1. new SQLConnection       
            */

            using var connection = new SqlConnection(connString);
            var parameters = new DynamicParameters(new { Name = "Test Ba Dapper" });
            connection.Execute("INSERT INTO [dbo].[Roles] ([Name]) VALUES (@NAME)", parameters);
            MessageBox.Show("OK");

        }

        private void btnAddRole2_Click(object sender, EventArgs e)
        {
            var role = new Role { Name = "Test ba Dapper MODEL" };

            using var connection = new SqlConnection(connString);
            connection.Execute("INSERT INTO [dbo].[Roles] ([Name]) VALUES (@NAME)", role);
            MessageBox.Show("OK");
        }

        private void btnFindRole_Click(object sender, EventArgs e)
        {
            using var connection = new SqlConnection(connString);
            var role = connection.QueryFirstOrDefault<Role>("SELECT * FROM [dbo].[Roles] WHERE id = @id", new { id = 1 });

            MessageBox.Show(role.Name);
        }

        private void btnFindRoles_Click(object sender, EventArgs e)
        {
            using var connection = new SqlConnection(connString);
            var roles = connection.Query<Role>("SELECT * FROM [dbo].[Roles] ");
            dataGridView1.DataSource = roles;
        }

        private void btnFindRolesAndUsers_Click(object sender, EventArgs e)
        {
            using var connection = new SqlConnection(connString);
            var result = connection.QueryMultiple("SELECT * FROM [dbo].[Roles];  SELECT * FROM [dbo].[Users]; ");

            dataGridView1.DataSource = result.Read<Role>();
            dataGridView2.DataSource = result.Read<User>();
        }

        private void sendEMail_Click(object sender, EventArgs e)
        {
            //Thread
            var thread = new Thread(() => SendEMail());
            thread.Start();


        }

        private static void SendEMail()
        {
            // I/O : Input/Output -> e.g. File, Email, Network, DB

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
            }
        }
    }
}