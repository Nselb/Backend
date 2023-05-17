using Backend.Models;
using BackendAja.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorizadorController : ControllerBase
    {
        // GET: api/<AutorizadorController>
        [HttpGet("{id}/{contrasena}")]
        public async Task<Autorizador?> Get(int id, string contrasena)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/Varios/");

            var responseTask = client.GetAsync($"GetAutorizador?usuario={id}&password={contrasena}");
            var result = responseTask.Result;
            Autorizador? usuario = null;
            if (result.IsSuccessStatusCode)
            {
                List<Autorizador?>? coso = await result.Content.ReadFromJsonAsync<List<Autorizador?>>();
                usuario = coso?.FirstOrDefault();
            }
            return usuario;
        }
    }
}
