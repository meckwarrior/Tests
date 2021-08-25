using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatumWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        [HttpGet("taxajuros")]
        public decimal GetTaxaJuros()
        {
            return 0.01m;
        }

        [HttpGet("calculajuros")]
        public decimal GetCalculaJuros(decimal valorinicial, int meses)
        {
            return Math.Round(valorinicial * (decimal)Math.Pow(1 + ((double)GetTaxaJuros()), meses), 2);
        }
    }
}
