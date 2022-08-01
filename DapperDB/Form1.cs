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
    }
}