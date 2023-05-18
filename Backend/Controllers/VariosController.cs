using Backend.Models;
using Backend.Models.Varios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariosController : ControllerBase
    {
        const string uri = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/";

        [HttpGet("TipoOperacion")]
        public async Task<List<TipoOperacion?>?> GetTipoOperacion()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TipoOperacion");
            var result = responseTask.Result;
            List<TipoOperacion?>? centros = new();
            if (result.IsSuccessStatusCode)
            {
                centros = await result.Content.ReadFromJsonAsync<List<TipoOperacion?>?>();
            }
            return centros;
        }
        [HttpGet("MovimientosExcepcion1y2")]
        public async Task<List<MovimientosExcepcion1y2?>?> GetMovimientos1y2()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"MovimientosExcepcion1y2");
            var result = responseTask.Result;
            List<MovimientosExcepcion1y2?>? centros = new();
            if (result.IsSuccessStatusCode)
            {
                centros = await result.Content.ReadFromJsonAsync<List<MovimientosExcepcion1y2?>?>();
            }
            return centros;
        }
        [HttpGet("MovimientosExcepcion3")]
        public async Task<List<MovimientosExcepcion3?>?> GetMovimientos3()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"MovimientosExcepcion3");
            var result = responseTask.Result;
            List<MovimientosExcepcion3?>? centros = new();
            if (result.IsSuccessStatusCode)
            {
                centros = await result.Content.ReadFromJsonAsync<List<MovimientosExcepcion3?>?>();
            }
            return centros;
        }
        [HttpGet("AfectaIESS")]
        public async Task<List<TrabaAfectaIESS?>?> AfectaIESS()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TrabaAfectaIESS");
            var result = responseTask.Result;
            List<TrabaAfectaIESS?>? centros = new();
            if (result.IsSuccessStatusCode)
            {
                centros = await result.Content.ReadFromJsonAsync<List<TrabaAfectaIESS?>?>();
            }
            return centros;
        }
        [HttpGet("AfectaImpuestoRenta")]
        public async Task<List<TrabAfecImpuestoRenta?>?> AfectaImpuestoRenta()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TrabAfecImpuestoRenta");
            var result = responseTask.Result;
            List<TrabAfecImpuestoRenta?>? centros = new();
            if (result.IsSuccessStatusCode)
            {
                centros = await result.Content.ReadFromJsonAsync<List<TrabAfecImpuestoRenta?>?>();
            }
            return centros;
        }
    }
}
