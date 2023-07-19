using Backend.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrabajadoresController : ControllerBase
    {
        const string uri = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/";
        [HttpGet("{sucursal}")]
        public async Task<List<Trabajador?>?> Get(int sucursal)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TrabajadorSelect?sucursal={sucursal}");
            var result = responseTask.Result;
            List<Trabajador?>? trabajadores = new();
            if (result.IsSuccessStatusCode)
            {
                trabajadores = await result.Content.ReadFromJsonAsync<List<Trabajador?>?>();
            }
            return trabajadores;
        }
        [HttpPost("Insert")]
        public async Task<Trabajador?> Insert([FromBody] Trabajador trabajador)
        {
            if (!VerificarCedula(trabajador.Identificacion))
            {
                return new Trabajador() { Mensaje = "Cedula Invalida" };
            }
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            if (trabajador.Tipo_Cese.Equals("N"))
            {
                trabajador.Tipo_Cese = " ";
                trabajador.FechaCese = "1753-02-01T00:00:00Z";
            }
            if (trabajador.EsReingreso.Equals("0"))
            {
                trabajador.FechaReingreso = "1753-02-01T00:00:00Z";
            }
            trabajador.Fecha_Ult_Actualizacion = DateTime.Now.ToString("s");
            var responseTask = client.PostAsync($"TrabajadorInsert?" +
                $"COMP_Codigo={trabajador.COMP_Codigo}" +
                $"&Tipo_trabajador={trabajador.Tipo_trabajador}" +
                $"&Apellido_Paterno={trabajador.Apellido_Paterno}" +
                $"&Apellido_Materno={trabajador.Apellido_Materno}" +
                $"&Nombres={trabajador.Nombres}" +
                $"&Identificacion={trabajador.Identificacion}" +
                $"&Entidad_Bancaria={trabajador.Entidad_Bancaria}" +
                $"&CarnetIESS={trabajador.CarnetIESS}" +
                $"&Direccion={trabajador.Direccion}" +
                $"&Telefono_Fijo={trabajador.Telefono_Movil}" +
                $"&Telefono_Movil={trabajador.Telefono_Movil}" +
                $"&Genero={trabajador.Genero}" +
                $"&Nro_Cuenta_Bancaria={trabajador.Nro_Cuenta_Bancaria}" +
                $"&Codigo_Categoria_Ocupacion={trabajador.Codigo_Categoria_Ocupacion}" +
                $"&Ocupacion={trabajador.Ocupacion}" +
                $"&Centro_Costos={trabajador.Centro_Costos}" +
                $"&Nivel_Salarial={trabajador.Nivel_Salarial}" +
                $"&EstadoTrabajador={trabajador.EstadoTrabajador}" +
                $"&Tipo_Contrato={trabajador.Tipo_Contrato}" +
                $"&Tipo_Cese={trabajador.Tipo_Cese}" +
                $"&EstadoCivil={trabajador.EstadoCivil}" +
                $"&TipodeComision={trabajador.TipodeComision}" +
                $"&FechaNacimiento={trabajador.FechaNacimiento}" +
                $"&FechaIngreso={trabajador.FechaIngreso}" +
                $"&FechaCese={trabajador.FechaCese}" +
                $"&PeriododeVacaciones={trabajador.PeriododeVacaciones}" +
                $"&FechaReingreso={trabajador.FechaReingreso}" +
                $"&Fecha_Ult_Actualizacion={trabajador.Fecha_Ult_Actualizacion}" +
                $"&EsReingreso={trabajador.EsReingreso}" +
                $"&Tipo_Cuenta={trabajador.Tipo_Cuenta}" +
                $"&FormaCalculo13ro={trabajador.FormaCalculo13ro}" +
                $"&FormaCalculo14ro={trabajador.FormaCalculo14ro}" +
                $"&BoniComplementaria={trabajador.BoniComplementaria}" +
                $"&BoniEspecial={trabajador.BoniEspecial}" +
                $"&Remuneracion_Minima={trabajador.Remuneracion_Minima}" +
                $"&Fondo_Reserva={trabajador.Fondo_Reserva}" +
                $"&Mensaje={trabajador.Mensaje}", new StringContent(""));
            var result = responseTask.Result;
            Trabajador trab = new();
            if (result.IsSuccessStatusCode)
            {
                trab.COMP_Codigo = trabajador.COMP_Codigo;
                trab.Mensaje = await result.Content.ReadFromJsonAsync<string>();
            }
            return trab;
        }
        [HttpPut("Update")]
        public async Task<Trabajador?> Update([FromBody] Trabajador trabajador)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            trabajador.Fecha_Ult_Actualizacion = DateTime.Now.ToString("s");
            var responseTask = client.PostAsync($"TrabajadorUpdate?" +
                $"COMP_Codigo={trabajador.COMP_Codigo}" +
                $"&Id_Trabajador={trabajador.Id_Trabajador}" +
                $"&Tipo_trabajador={trabajador.Tipo_trabajador}" +
                $"&Apellido_Paterno={trabajador.Apellido_Paterno}" +
                $"&Apellido_Materno={trabajador.Apellido_Materno}" +
                $"&Nombres={trabajador.Nombres}" +
                $"&Identificacion={trabajador.Identificacion}" +
                $"&Entidad_Bancaria={trabajador.Entidad_Bancaria}" +
                $"&CarnetIESS={trabajador.CarnetIESS}" +
                $"&Direccion={trabajador.Direccion}" +
                $"&Telefono_Fijo={trabajador.Telefono_Fijo}" +
                $"&Telefono_Movil={trabajador.Telefono_Movil}" +
                $"&Genero={trabajador.Genero}" +
                $"&Nro_Cuenta_Bancaria={trabajador.Nro_Cuenta_Bancaria}" +
                $"&Codigo_Categoria_Ocupacion={trabajador.Codigo_Categoria_Ocupacion}" +
                $"&Ocupacion={trabajador.Ocupacion}" +
                $"&Centro_Costos={trabajador.Centro_Costos}" +
                $"&Nivel_Salarial={trabajador.Nivel_Salarial}" +
                $"&EstadoTrabajador={trabajador.EstadoTrabajador}" +
                $"&Tipo_Contrato={trabajador.Tipo_Contrato}" +
                $"&Tipo_Cese={trabajador.Tipo_Cese}" +
                $"&EstadoCivil={trabajador.EstadoCivil}" +
                $"&TipodeComision={trabajador.TipodeComision}" +
                $"&FechaNacimiento={trabajador.FechaNacimiento}" +
                $"&FechaIngreso={trabajador.FechaIngreso}" +
                $"&FechaCese={trabajador.FechaCese}" +
                $"&PeriododeVacaciones={trabajador.PeriododeVacaciones}" +
                $"&FechaReingreso={trabajador.FechaReingreso}" +
                $"&Fecha_Ult_Actualizacion={trabajador.Fecha_Ult_Actualizacion}" +
                $"&EsReingreso={trabajador.EsReingreso}" +
                $"&Tipo_Cuenta={trabajador.Tipo_Cuenta}" +
                $"&FormaCalculo13ro={trabajador.FormaCalculo13ro}" +
                $"&FormaCalculo14ro={trabajador.FormaCalculo14ro}" +
                $"&BoniComplementaria={trabajador.BoniComplementaria}" +
                $"&BoniEspecial={trabajador.BoniEspecial}" +
                $"&Remuneracion_Minima={trabajador.Remuneracion_Minima}" +
                $"&Fondo_Reserva={trabajador.Fondo_Reserva}", new StringContent(""));
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                await result.Content.ReadFromJsonAsync<Trabajador?>();
                return trabajador;
            }
            return new() { COMP_Codigo = trabajador.COMP_Codigo };
        }
        [HttpDelete("Delete/{sucursal}/{codigoempleado}")]
        public async Task<Trabajador?> Delete(int sucursal, int codigoempleado)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TrabajadorDelete?sucursal={sucursal}&codigoempleado={codigoempleado}");
            var result = responseTask.Result;
            Trabajador? trab = new();
            if (result.IsSuccessStatusCode)
            {
                trab.Mensaje = await result.Content.ReadFromJsonAsync<string>();
            }
            return trab;
        }
        public static bool VerificarCedula(string cedula)
        {
            if (cedula.Length != 10)
            {
                return false;
            }
            foreach (char c in cedula)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            string provinciaCodigo = cedula[..2];
            if (!int.TryParse(provinciaCodigo, out int provincia) || provincia < 1 || provincia > 24)
            {
                return false;
            }
            int ultimoDigito = int.Parse(cedula.Substring(9, 1));
            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                int digito = int.Parse(cedula.Substring(i, 1));

                if (i % 2 == 0)
                {
                    digito *= 2;

                    if (digito > 9)
                    {
                        digito -= 9;
                    }
                }

                suma += digito;
            }

            int residuo = suma % 10;
            int resultadoEsperado = residuo == 0 ? 0 : 10 - residuo;

            return ultimoDigito == resultadoEsperado;
        }
    }
}
