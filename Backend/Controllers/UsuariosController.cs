using BackendAja.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendAja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet("{id}/{contrasena}")]
        public async Task<Usuario?> Get(int id, string contrasena)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/");

            var responseTask = client.GetAsync($"Usuarios?usuario={id}&password={contrasena}");
            var result = responseTask.Result;
            Usuario? usuario = null;
            if (result.IsSuccessStatusCode)
            {
                List<Usuario?>? coso = await result.Content.ReadFromJsonAsync<List<Usuario?>>();
                usuario = coso?.FirstOrDefault();
            }
            return usuario;
        }
    }
}
