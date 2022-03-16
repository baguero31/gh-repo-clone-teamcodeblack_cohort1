using Dapper;
using System.Data;
using System.Data.SqlClient;
using PostmanWebApi.DataModels;

namespace PostmanWebApi.DAO
{

    public interface IDataAccess
    {
        IEnumerable<QueryModel> GetAuthors();
        IEnumerable<QueryModel> GetAuthorById(string id);
        bool CreateNewAuthor(AuthorModel model);
        bool DeleteAuthor(string id);
    }

    public class DataAccess : IDataAccess
    {
        private readonly string _connString;
        public DataAccess(string connString)
        {
            _connString = connString;
        }

        public IEnumerable<QueryModel> GetAuthors()
        {
            var retModels = new List<QueryModel>();

            try
            {
                using (IDbConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();

                    var sql = @"
                        SELECT au_fname firstName, au_lname lastName, title, price bookPrice
	                        FROM authors A
                        INNER JOIN titleauthor TA ON TA.au_id = A.au_id
                        INNER JOIN titles TI ON TA.title_id = TI.title_id
                        WHERE price IS NOT NULL
                        ORDER BY price desc
                        ";

                    retModels = conn.Query<QueryModel>(sql).ToList();


                }
            }
            catch (Exception authEx)
            {

            }
            return retModels;
        }

        public IEnumerable<QueryModel> GetAuthorById(string id)
        {
            var retModels = new List<QueryModel>();

            try
            {
                using (IDbConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();

                    var sql = @"
                        SELECT au_fname firstName, au_lname lastName, title, price bookPrice
	                        FROM authors A
                        INNER JOIN titleauthor TA ON TA.au_id = A.au_id
                        INNER JOIN titles TI ON TA.title_id = TI.title_id
                        WHERE price IS NOT NULL
                        and A.au_id = @id
                        ORDER BY price desc
                        ";

                    retModels = conn.Query<QueryModel>(sql, new { id = id }).ToList();


                }
            }
            catch (Exception authEx)
            {

            }
            return retModels;
        }

        public bool CreateNewAuthor(AuthorModel model)
        {
            var intRet = 0;
            try
            {
                using (IDbConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();

                    var sql = @"
                     INSERT INTO [dbo].[authors]
                           ([au_id],[au_fname],[au_lname],[address],[city],[state],[zip],[phone],[contract])
                     VALUES
                           (@AuthorId,@FirstName,@LastName,@Address,@City,@State,@Zip,@Phone,@HasContract)
                    ";

                    intRet = conn.Execute(sql, new AuthorModel()
                    {
                        AuthorId = model.SetNewAuthorID(),
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Address = model.Address,
                        City = model.City,
                        State = model.State,
                        Zip = model.Zip,
                        Phone = model.Phone,
                        HasContract = model.HasContract
                    });
                }
            }
            catch (Exception ex)
            {

            }
            return intRet > 0;
        }

        public bool DeleteAuthor(string id)
        {
            int isDeleted = 0;

            try
            {
                using (IDbConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();

                    var sql = @"DELETE FROM authors WHERE au_id = @id";

                    isDeleted = conn.Execute(sql, new { id = id });
                }
            }
            catch (Exception authEx)
            {

            }
            return isDeleted > 0;
        }


    }
}
