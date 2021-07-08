using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpNumberTranslatorApi.ServiceContracts;

namespace CSharpNumberTranslatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberTranslatorController : ControllerBase
    {
        private readonly INumberTranslatorService _numberTranslatorService;

        public NumberTranslatorController(INumberTranslatorService numberTranslatorService)
        {
            _numberTranslatorService = numberTranslatorService;
        }

        [HttpGet("GetNumber/{number}")]
        public string Get(int number)
        {
            return _numberTranslatorService.Translate(number);
        }
    }
}
