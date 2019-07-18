using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab.Application.Interfaces;
using Lab.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITabelaINSSApplicationService _appService;
        public ValuesController(ITabelaINSSApplicationService appService)
        {
            _appService = appService;
        }
        /*
           IMPLEMENTÇÃO DO SERVIÇO ONDE É PASSADO OS PARAMENTOS
         */
        [HttpGet]
        public ActionResult<ReturnValuesViewModel> GetValueDescont()
        {
            DateTime data = new DateTime(2012, 11, 7);
            return _appService.CalculateDiscount(data, 1000.00m);
        }






        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
