using BackendAja.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmisorController : ControllerBase
    {
        [HttpGet]
        public async Task<List<Emisor>?> Get()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/");
            var responseTask = client.GetAsync($"Varios/GetEmisor");
            var result = responseTask.Result;
            List<Emisor>? emisores = new();
            if (result.IsSuccessStatusCode)
            {
                emisores = await result.Content.ReadFromJsonAsync<List<Emisor>?>();
            }
            return emisores;
        }
    }
}
