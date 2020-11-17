using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grids.IService;
using Grids.Models;
using Grids.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Grids.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundsController : ControllerBase
    {

        // ADD
        private IFundService _fundService = null;

        public FundsController(IFundService fundService)
        {
            _fundService = fundService;
        }

        // GET: api/<FundsController>
        [HttpGet]
        public IEnumerable<Fund> GetFunds()
        {
            return _fundService.GetFunds();
        }

        // GET api/<FundsController>/5
        [HttpGet("{id}")]
        public Fund Get(int id)
        {
            return _fundService.GetById(id);
        }

        // POST api/<FundsController>
        [HttpPost]
        public void SaveOrUpdate([FromForm] Fund fund)
        {
            if(fund.FundId == 0) _fundService.Save(fund);
            else _fundService.Update(fund);
        }

        // PUT api/<FundsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<FundsController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _fundService.Delete(id);
        }
    }
}
