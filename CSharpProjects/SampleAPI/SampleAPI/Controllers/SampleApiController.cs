using Microsoft.Extensions.Logging;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SampleAPI.Models;
using System.Collections.Generic;
using SampleAPI.DataAccess;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    [Produces("application/json")]
    public class SampleApiController : ControllerBase
    {
        private IConfiguration Configuration; //interface for getting connection string
        private ISampleApiDAO DAO;
        private static string connString;

        public SampleApiController(IConfiguration _config)
        {
            Configuration = _config;
            connString = _config.GetConnectionString("Default");
            this.DAO = new SampleApiDAO(connString);
        }

        // POST: v1/SampleApiController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SampleApiModel>>> Get()
        {
            try
            {
                var retmodels = await DAO.GetAllModels();
                return Ok(retmodels);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        // POST: v1/SampleApiController/{id}
        [HttpGet("{tableID}")]
        public async Task<ActionResult<IEnumerable<SampleApiModel>>> Get(int tableID)
        {
            try
            {
                var retmodels = await DAO.GetModelsByID(tableID);
                return Ok(retmodels);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        // POST: v1/SampleApiController
        [HttpPost()]
        public async Task<ActionResult<IEnumerable<SampleApiModel>>> Post([FromBody] SampleApiModel model)
        {
            try
            {
                var retmodels = await DAO.InsertNewModel(model);
                return Ok(retmodels);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        // PUT: v1/SampleApiController?tableID={id}&date={date}&column1={column1}&column2={column2}&isBool={isBool}
        [HttpPut()]
        public async Task<ActionResult<IEnumerable<SampleApiModel>>> Put(int id, string date, string column1, string column2, bool isTableBoolean)
        {
            try
            {
                var retModels = await DAO.UpdateModel(id, Extensions.GetDate(date), column1, column2, isTableBoolean);
                return Ok(retModels);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        // DELETE: v1/SampleApiController/{id}
        [HttpDelete("{tableID}/{getTableDate}")]
        public async Task<ActionResult<int>> Delete(int tableID, string getTableDate)
        {
            try
            {
                var retModel = await DAO.DeleteModel(tableID, Extensions.GetDate(getTableDate));
                return Ok(retModel);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
    }
}
