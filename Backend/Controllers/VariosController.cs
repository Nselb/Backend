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
            List<TipoOperacion?>? tipoOperacion = new();
            if (result.IsSuccessStatusCode)
            {
                tipoOperacion = await result.Content.ReadFromJsonAsync<List<TipoOperacion?>?>();
            }
            return tipoOperacion;
        }
        [HttpGet("MovimientosExcepcion1y2")]
        public async Task<List<MovimientosExcepcion1y2?>?> GetMovimientos1y2()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"MovimientosExcepcion1y2");
            var result = responseTask.Result;
            List<MovimientosExcepcion1y2?>? excepcion1Y2 = new();
            if (result.IsSuccessStatusCode)
            {
                excepcion1Y2 = await result.Content.ReadFromJsonAsync<List<MovimientosExcepcion1y2?>?>();
            }
            return excepcion1Y2;
        }
        [HttpGet("MovimientosExcepcion3")]
        public async Task<List<MovimientosExcepcion3?>?> GetMovimientos3()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"MovimientosExcepcion3");
            var result = responseTask.Result;
            List<MovimientosExcepcion3?>? excepcion3 = new();
            if (result.IsSuccessStatusCode)
            {
                excepcion3 = await result.Content.ReadFromJsonAsync<List<MovimientosExcepcion3?>?>();
            }
            return excepcion3;
        }
        [HttpGet("AfectaIESS")]
        public async Task<List<TrabaAfectaIESS?>?> AfectaIESS()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TrabaAfectaIESS");
            var result = responseTask.Result;
            List<TrabaAfectaIESS?>? iess = new();
            if (result.IsSuccessStatusCode)
            {
                iess = await result.Content.ReadFromJsonAsync<List<TrabaAfectaIESS?>?>();
            }
            return iess;
        }
        [HttpGet("AfectaImpuestoRenta")]
        public async Task<List<TrabAfecImpuestoRenta?>?> AfectaImpuestoRenta()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TrabAfecImpuestoRenta");
            var result = responseTask.Result;
            List<TrabAfecImpuestoRenta?>? impuestoRentas = new();
            if (result.IsSuccessStatusCode)
            {
                impuestoRentas = await result.Content.ReadFromJsonAsync<List<TrabAfecImpuestoRenta?>?>();
            }
            return impuestoRentas;
        }
        [HttpGet("TipoTrabajador")]
        public async Task<List<InfoGeneral?>?> TipoTrabajador()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TipoTrabajador");
            var result = responseTask.Result;
            List<InfoGeneral?>? info = new();
            if (result.IsSuccessStatusCode)
            {
                info = await result.Content.ReadFromJsonAsync<List<InfoGeneral?>?>();
            }
            return info;
        }
        [HttpGet("Genero")]
        public async Task<List<InfoGeneral?>?> Genero()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"Genero");
            var result = responseTask.Result;
            List<InfoGeneral?>? info = new();
            if (result.IsSuccessStatusCode)
            {
                info = await result.Content.ReadFromJsonAsync<List<InfoGeneral?>?>();
            }
            return info;
        }
        [HttpGet("EstadoTrabajador")]
        public async Task<List<InfoGeneral?>?> EstadoTrabajador()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"EstadoTrabajador");
            var result = responseTask.Result;
            List<InfoGeneral?>? info = new();
            if (result.IsSuccessStatusCode)
            {
                info = await result.Content.ReadFromJsonAsync<List<InfoGeneral?>?>();
            }
            return info;
        }
        [HttpGet("TipoContrato")]
        public async Task<List<InfoGeneral?>?> TipoContrato()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TipoContrato");
            var result = responseTask.Result;
            List<InfoGeneral?>? info = new();
            if (result.IsSuccessStatusCode)
            {
                info = await result.Content.ReadFromJsonAsync<List<InfoGeneral?>?>();
            }
            return info;
        }
        [HttpGet("TipoCese")]
        public async Task<List<InfoGeneral?>?> TipoCese()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TipoCese");
            var result = responseTask.Result;
            List<InfoGeneral?>? info = new();
            if (result.IsSuccessStatusCode)
            {
                info = await result.Content.ReadFromJsonAsync<List<InfoGeneral?>?>();
            }
            return info;
        }
        [HttpGet("EstadoCivil")]
        public async Task<List<InfoGeneral?>?> EstadoCivil()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"EstadoCivil");
            var result = responseTask.Result;
            List<InfoGeneral?>? info = new();
            if (result.IsSuccessStatusCode)
            {
                info = await result.Content.ReadFromJsonAsync<List<InfoGeneral?>?>();
            }
            return info;
        }
        [HttpGet("EsReingreso")]
        public async Task<List<InfoGeneral?>?> EsReingreso()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"EsReingreso");
            var result = responseTask.Result;
            List<InfoGeneral?>? info = new();
            if (result.IsSuccessStatusCode)
            {
                info = await result.Content.ReadFromJsonAsync<List<InfoGeneral?>?>();
            }
            return info;
        }
        [HttpGet("TipoCuenta")]
        public async Task<List<InfoGeneral?>?> TipoCuenta()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TipoCuenta");
            var result = responseTask.Result;
            List<InfoGeneral?>? info = new();
            if (result.IsSuccessStatusCode)
            {
                info = await result.Content.ReadFromJsonAsync<List<InfoGeneral?>?>();
            }
            return info;
        }
    }
}
