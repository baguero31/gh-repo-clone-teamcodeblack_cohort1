using Microsoft.Extensions.Configuration;
using PNPDoggyEmporium.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace PNPDoggyEmporium.Dao
{
    public interface IPNPDoggyDao 
    {
        Task<IEnumerable<DupCustomers>> GetDuplicateCustomers();
        Task<IEnumerable<TPPCustomers>> GetCustomerByName(string firstName, string lastName);
        Task<IEnumerable<Customers>> GetLoyaltyInfo();
        Task<IEnumerable<TPPCustomers>> GetLoyaltyInfoSorted();
        Task<IEnumerable<APPCustomers>> GetLoyaltyAverages();
    }

    public interface IConnectionStringProvider
    {
        public string DefaultConnectionString { get; }
    }

    public class PNPDoggyDao : IPNPDoggyDao, IConnectionStringProvider
    {
        private readonly IConfiguration _configuration;
        public string DefaultConnectionString => _configuration.GetConnectionString("DevDB1");

        public PNPDoggyDao(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public async Task<IEnumerable<DupCustomers>> GetDuplicateCustomers()
        {
            using (SqlConnection conn = new SqlConnection(DefaultConnectionString))
            {
                await conn.OpenAsync();

                var returnCusts = await conn.QueryAsync<DupCustomers>($@"
                    SELECT CountNum, LastName, FirstName FROM (
	                    SELECT ROW_NUMBER() OVER(PARTITION BY LastName, 
                                FirstName ORDER BY LastName, FirstName) CountNum,
	                    LastName, FirstName 
		                    FROM Customers
                    ) subQ
                    where CountNum > 1
                ");

                return returnCusts;
            }
        }

        public async Task<IEnumerable<TPPCustomers>> GetCustomerByName(string firstName, string lastName)
        {
            using (SqlConnection conn = new SqlConnection(DefaultConnectionString))
            {
                await conn.OpenAsync();

                var returnCusts = await conn.QueryAsync<TPPCustomers>($@"
                    SELECT TotalPoints, LastName, FirstName FROM (
	                    SELECT SUM(transactionpoints) TotalPoints, FirstName, LastName 
		                    FROM Customers
	                    GROUP BY TransactionPoints, LastName, FirstName
                    ) subQ
                    where LastName = @LastName and FirstName = @FirstName
                    ORDER BY LastName ASC, TotalPoints DESC
                ", new {LastName = lastName, FirstName = firstName}).ConfigureAwait(false);

                var retCusts = returnCusts;

                return retCusts;
            }
        }

        public async Task<IEnumerable<APPCustomers>> GetLoyaltyAverages()
        {
            using (SqlConnection conn = new SqlConnection(DefaultConnectionString))
            {
                await conn.OpenAsync();

                var returnCusts = await conn.QueryAsync<APPCustomers>($@"
                    SELECT AvgPoints, LastName, FirstName FROM (
	                    SELECT AVG(transactionpoints) AvgPoints, FirstName, LastName 
		                    FROM Customers
	                    GROUP BY TransactionPoints, LastName, FirstName
                    ) subQ
                    ORDER BY AvgPoints desc, LastName
                ");

                return returnCusts;
            }
        }

        public async Task<IEnumerable<TPPCustomers>> GetLoyaltyInfoSorted()
        {           
            using (SqlConnection conn = new SqlConnection(DefaultConnectionString))
            {
                await conn.OpenAsync();

                var returnCusts = await conn.QueryAsync<TPPCustomers>($@"
                    SELECT LoyaltyType, TotalPoints, LastName, FirstName FROM (
	                    SELECT SUM(transactionpoints) TotalPoints, FirstName, LastName 
		                    FROM Customers
	                    GROUP BY TransactionPoints, LastName, FirstName
                    ) subQ
                    OUTER APPLY (
	                    SELECT CASE WHEN LoyaltyID = 1 THEN 'SILVER' 
	                    WHEN LoyaltyID = 2 THEN 'GOLD'
	                    WHEN LoyaltyID = 3 THEN 'PLATINUM' ELSE NULL END AS LoyaltyType 
	                    FROM LoyalRanges WHERE TotalPoints BETWEEN LowRange AND HiRange
                    ) sub2
                    ORDER BY TotalPoints desc, LastName, FirstName asc
                ");

                return returnCusts;
            }           
        }

        public async Task<IEnumerable<Customers>> GetLoyaltyInfo()
        {
            using (SqlConnection conn = new SqlConnection(DefaultConnectionString))
            {
                await conn.OpenAsync();

                var returnCusts = await conn.QueryAsync<Customers>($@"
                        SELECT TransactionDate, FirstName, LastName, TransactionPoints FROM Customers");

                return returnCusts;
            }
        }

    }
}
