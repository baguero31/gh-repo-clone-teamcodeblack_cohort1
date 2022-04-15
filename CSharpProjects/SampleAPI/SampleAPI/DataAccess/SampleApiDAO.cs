using System;
using Microsoft.Extensions.Configuration;
using SampleAPI.Models;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.DataAccess
{
    public interface ISampleApiDAO
    {
        Task<IEnumerable<SampleApiModel>> GetAllModels();
        Task<IEnumerable<SampleApiModel>> GetModelsByID(int tableID);
        Task<IEnumerable<SampleApiModel>> InsertNewModel(SampleApiModel model);
        Task<IEnumerable<SampleApiModel>> UpdateModel(int tableID, DateTime uDate,
            string uTColumn1 = null, string uTColumn2 = null, bool? uIsGetBool = null);
        Task<int> DeleteModel(int tableID, DateTime dDate);
    }

    public class SampleApiDAO : ISampleApiDAO
    {
        private string _connString;

        public SampleApiDAO(string ConnString)
        {
            this._connString = ConnString;
        }

        public async Task<IEnumerable<SampleApiModel>> GetAllModels()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();

                    string sql = @"
                            SELECT TableID, GetTableDate, GetTableColumn1, GetTableColumn2,
                                IsGetTableBoolean
                            FROM [dbo].[GetTable]
                            ORDER BY TableID
                    ";
                    var ret = await conn.QueryAsync<SampleApiModel>(sql);
                    return ret;
                }
            }
            catch 
            {
                return null;
            }
        }

        public async Task<IEnumerable<SampleApiModel>> GetModelsByID(int tableID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    string sql = @"SELECT TableID, GetTableDate, GetTableColumn1, GetTableColumn2,
                                IsGetTableBoolean
                            FROM [dbo].[GetTable]
                            WHERE TableID = @TableID";

                    var retList = await conn.QueryAsync<SampleApiModel>(sql, new {TableID = tableID});
                    return retList;
                }
            }
            catch
            {
                return null;
            }
        }

        private IEnumerable<SampleApiModel> GetLastModelByID()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    string sql = @"SELECT TOP 1 TableID, GetTableDate, GetTableColumn1, GetTableColumn2,
                                IsGetTableBoolean
                            FROM [dbo].[GetTable]
                            ORDER BY TableID DESC
                    ";

                    var retList = conn.Query<SampleApiModel>(sql);
                    return retList;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<SampleApiModel>> InsertNewModel(SampleApiModel model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO [dbo].[GetTable]
                            ([GetTableDate],[GetTableColumn1],[GetTableColumn2],[IsGetTableBoolean])
                        VALUES
                            (@GetTableDate, @GetTableColumn1, @GetTableColumn2, @IsGetTableBoolean)
                    ";

                    var retInsert = await conn.QueryAsync<SampleApiModel>
                        (sql, 
                        new 
                        { 
                            GetTableDate = Extensions.GetDate(model.GetTableDate).ToString(),
                            GetTableColumn1 = model.GetTableColumn1,
                            GetTableColumn2 = model.GetTableColumn2,
                            IsGetTableBoolean = model.IsGetTableColumnBoolean
                        });

                    var retModel = GetLastModelByID();
                    return retModel;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<SampleApiModel>> UpdateModel(int tableID, DateTime uDate, 
            string uTColumn1 = null, string uTColumn2 = null, bool? uIsGetBool = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();

                    var updateList = string.Empty;

                    if (!string.IsNullOrEmpty(uTColumn1))
                        updateList += " [GetTableColumn1] = @GetTableColumn1";

                    if (!string.IsNullOrEmpty(uTColumn2))
                        updateList += " ,[GetTableColumn2] = @GetTableColumn2";

                    if (uIsGetBool.Value)
                        updateList += " ,[IsGetTableBoolean] = @IsGetTableBoolean";

                    string sql = $@"
                        UPDATE [dbo].[GetTable]
                            SET {updateList}
                        WHERE
                            TableID = @TableID AND
                            GetTableDate = @GetTableDate
                    ";

                    var retUpdate = await conn.QueryAsync<SampleApiModel>
                        (sql,
                        new
                        {
                            TableID = tableID,
                            GetTableDate = uDate,
                            GetTableColumn1 = uTColumn1,
                            GetTableColumn2 = uTColumn2,
                            IsGetTableBoolean = uIsGetBool
                        });

                    var retModel = await GetModelsByID(tableID);
                    return retModel;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> DeleteModel(int tableID, DateTime dDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();

                    string sql = @"
                            DELETE FROM [dbo].[GetTable]
                            WHERE TableID = @TableID AND GetTableDate = @GetTableDate
                    ";

                    var ret = await conn.ExecuteScalarAsync<int>(sql, new {TableID = tableID, GetTableDate = dDate}).ConfigureAwait(false);

                    return ret;
                }
            }
            catch
            {
                return -1;
            }
        }
    }
}
