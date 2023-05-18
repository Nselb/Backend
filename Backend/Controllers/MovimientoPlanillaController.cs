using Backend.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientoPlanillaController : ControllerBase
    {
        const string uri = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/";

        // GET: api/<MovimientoPlanillaController>
        [HttpGet]
        public async Task<List<MovimientoPlanilla?>?> Get()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"MovimientoPlanillaSelect");
            var result = responseTask.Result;
            List<MovimientoPlanilla?>? centros = new();
            if (result.IsSuccessStatusCode)
            {
                centros = await result.Content.ReadFromJsonAsync<List<MovimientoPlanilla?>?>();
            }
            return centros;
        }

        // GET api/<MovimientoPlanillaController>/5
        [HttpGet("Search")]
        public async Task<List<MovimientoPlanilla?>?> Search(string descripcion)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"MovimientoPlanillaSearch?Concepto={descripcion}");
            var result = responseTask.Result;
            List<MovimientoPlanilla?>? centros = new();
            if (result.IsSuccessStatusCode)
            {
                centros = await result.Content.ReadFromJsonAsync<List<MovimientoPlanilla?>?>();
            }
            return centros;
        }

        // POST api/<MovimientoPlanillaController>
        [HttpPost("Insert")]
        public async Task<MovimientoPlanilla?> Insert([FromBody] MovimientoPlanilla cc)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"MovimientoPlanillaInsert?conceptos={cc.Concepto}&prioridad={cc.Prioridad}&tipooperacion={cc.TipoOperacion}&cuenta1={cc.Cuenta1}&cuenta2={cc.Cuenta2}&cuenta3={cc.Cuenta3}&cuenta4={cc.Cuenta4}&MovimientoExcepcion1={cc.MovimientoExcepcion1}&MovimientoExcepcion2={cc.MovimientoExcepcion2}&MovimientoExcepcion3={cc.MovimientoExcepcion3}&Traba_Aplica_iess={cc.Aplica_iess}&Aplica_Proy_Renta={cc.Aplica_imp_renta}&Empresa_Afecta_Iess={cc.Empresa_Afecta_Iess}");
            var result = responseTask.Result;
            MovimientoPlanilla? centro = new();
            if (result.IsSuccessStatusCode)
            {
                var coso = await result.Content.ReadFromJsonAsync<List<MovimientoPlanilla?>?>();
                centro = coso?.FirstOrDefault();
            }
            return centro;
        }

        // PUT api/<MovimientoPlanillaController>/5
        [HttpPut("Update")]
        public async Task<MovimientoPlanilla?> Update([FromBody] MovimientoPlanilla cc)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"MovimientoPlanillaUpdate?codigoplanilla={cc.CodigoConcepto}&conceptos={cc.Concepto}&prioridad={cc.Prioridad}&tipooperacion={cc.TipoOperacion}&cuenta1={cc.Cuenta1}&cuenta2={cc.Cuenta2}&cuenta3={cc.Cuenta3}&cuenta4={cc.Cuenta4}&MovimientoExcepcion1={cc.MovimientoExcepcion1}&MovimientoExcepcion2={cc.MovimientoExcepcion2}&MovimientoExcepcion3={cc.MovimientoExcepcion3}&Traba_Aplica_iess={cc.Aplica_iess}&Aplica_Proy_Renta={cc.Aplica_imp_renta}&Empresa_Afecta_Iess={cc.Empresa_Afecta_Iess}");
            var result = responseTask.Result;
            MovimientoPlanilla? centro = new();
            if (result.IsSuccessStatusCode)
            {
                var coso = await result.Content.ReadFromJsonAsync<List<MovimientoPlanilla?>?>();
                centro = coso?.FirstOrDefault();
            }
            return centro;
        }

        // DELETE api/<MovimientoPlanillaController>/5
        [HttpDelete("Delete/{codigo}/{descripcion}")]
        public async Task<MovimientoPlanilla?> Delete(int codigo, string descripcion)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"MovimeintoPlanillaDelete?codigomovimiento={codigo}&descripcionomovimiento={descripcion}");
            var result = responseTask.Result;
            MovimientoPlanilla? centro = new();
            if (result.IsSuccessStatusCode)
            {
                var coso = await result.Content.ReadFromJsonAsync<List<MovimientoPlanilla?>?>();
                centro = coso?.FirstOrDefault();
            }
            return centro;
        }
    }
}
