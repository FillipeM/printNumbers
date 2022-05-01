using Microsoft.AspNetCore.Mvc;
using printNumbers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace printNumbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrintNumbersController : ControllerBase
    {
        private readonly INumberService numberService;

        public PrintNumbersController(INumberService _numberService)
        {
            numberService = _numberService;
        }
        [HttpGet]
        public string Index()
        {
            return numberService.Iterate();
        }
    }
}
