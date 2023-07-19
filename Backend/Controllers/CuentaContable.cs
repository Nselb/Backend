using Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaContable : Controller
    {
        const string uri = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/";
        [HttpGet]
        public async Task<List<CentroCostos?>?> Get()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"CentroCostosSelect");
            var result = responseTask.Result;
            List<CentroCostos?>? centros = new();
            if (result.IsSuccessStatusCode)
            {
                centros = await result.Content.ReadFromJsonAsync<List<CentroCostos?>?>();
            }
            return centros;
        }
        [HttpPost("Insert")]
        public async Task<CentroCostos?> Insert([FromBody] CentroCostos cc)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"CentroCostosInsert?codigocentrocostos={cc.Codigo}&descripcioncentrocostos={cc.NombreCentroCostos}");
            var result = responseTask.Result;
            CentroCostos? centro = new();
            if (result.IsSuccessStatusCode)
            {
                var coso = await result.Content.ReadFromJsonAsync<List<CentroCostos?>?>();
                centro = coso?.FirstOrDefault();
            }
            return centro;
        }
        [HttpDelete("Delete/{codigo}/{descripcion}")]
        public async Task<CentroCostos?> Delete(int codigo, string descripcion)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"CentroCostosDelete?codigocentrocostos={codigo}&descripcioncentrocostos={descripcion}");
            var result = responseTask.Result;
            CentroCostos? centro = new();
            if (result.IsSuccessStatusCode)
            {
                var coso = await result.Content.ReadFromJsonAsync<List<CentroCostos?>?>();
                centro = coso?.FirstOrDefault();
            }
            return centro;
        }
        [HttpPut("Update")]
        public async Task<CentroCostos?> Update([FromBody] CentroCostos cc)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"CentroCostosUpdate?codigocentrocostos={cc.Codigo}&descripcioncentrocostos={cc.NombreCentroCostos}");
            var result = responseTask.Result;
            CentroCostos? centro = new();
            if (result.IsSuccessStatusCode)
            {
                var coso = await result.Content.ReadFromJsonAsync<List<CentroCostos?>?>();
                centro = coso?.FirstOrDefault();
            }
            return centro;
        }
        [HttpGet("Search")]
        public async Task<List<CentroCostos?>?> Search(string descripcion)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"CentroCostosSearch?descripcioncentrocostos={descripcion}");
            var result = responseTask.Result;
            List<CentroCostos?>? centros = new();
            if (result.IsSuccessStatusCode)
            {
                centros = await result.Content.ReadFromJsonAsync<List<CentroCostos?>?>();
            }
            return centros;
        }
    }
}
