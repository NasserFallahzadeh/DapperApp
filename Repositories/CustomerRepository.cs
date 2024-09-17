using System.Data.SqlClient;
using Dapper;

namespace Repositories
{
    public interface ICustomerRepository
    {
        int Add();
    }

    public class CustomerRepository:ICustomerRepository
    {
        private readonly string connectionString = @"Data Source=.\MSSQLSERVER2022;Initial Catalog=DapperDb;Integrated Security=True";

        public int Add()
        {
            var sql = "insert into Customers(Name,LastName) values(N'Ehsan', N'Babaei')";
            var connection=new SqlConnection(connectionString);

            var result=connection.Execute(sql);

            return result;
        }
    }

    public class CustomerDto
    {

    }
}
