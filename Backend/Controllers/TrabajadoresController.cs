﻿using Backend.Models;
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
            if (VerificarCedula(trabajador.Identificacion))
            {
                return new Trabajador() { Mensaje = "Cedula Invalida" };
            }
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TrabajadorInsert?COMP_Codigo={trabajador.COMP_Codigo}&Tipo_trabajador={trabajador.Tipo_trabajador}&Apellido_Paterno={trabajador.Apellido_Paterno}&Apellido_Materno={trabajador.Apellido_Materno}&Nombres=a&Identificacion={trabajador.Identificacion}&Entidad_Bancaria={trabajador.Entidad_Bancaria}&CarnetIESS={trabajador.CarnetIESS}&Direccion={trabajador.Direccion}&Telefono_Fijo={trabajador.Telefono_Fijo}&Telefono_Movil={trabajador.Telefono_Movil}&Genero={trabajador.Genero}&Nro_Cuenta_Bancaria={trabajador.Nro_Cuenta_Bancaria}&Codigo_Categoria_Ocupacion={trabajador.Codigo_Categoria_Ocupacion}&Ocupacion={trabajador.Ocupacion}&Centro_Costos={trabajador.Centro_Costos}&Nivel_Salarial={trabajador.Nivel_Salarial}&EstadoTrabajador={trabajador.EstadoTrabajador}&Tipo_Contrato={trabajador.Tipo_Contrato}&Tipo_Cese={trabajador.Tipo_Cese}&EstadoCivil={trabajador.EstadoCivil}&TipodeComision={trabajador.TipodeComision}&FechaNacimiento={trabajador.FechaNacimiento}&FechaIngreso={trabajador.FechaIngreso}&FechaCese={trabajador.FechaCese}&PeriododeVacaciones={trabajador.PeriododeVacaciones}&FechaReingreso={trabajador.FechaReingreso}&Fecha_Ult_Actualizacion={trabajador.Fecha_Ult_Actualizacion}&EsReingreso={trabajador.EsReingreso}&BancoCTA_CTE={trabajador.BancoCTA_CTE}&Tipo_Cuenta={trabajador.Tipo_Cuenta}&RSV_Indem_Acumul={trabajador.RSV_Indem_Acumul}&A%C3%B1o_Ult_Rsva_Indemni={trabajador.Año_Ult_Rsva_Indemni}&Mes_Ult_Rsva_Indemni={trabajador.Mes_Ult_Rsva_Indemni}&FormaCalculo13ro={trabajador.FormaCalculo13ro}&FormaCalculo14ro={trabajador.FormaCalculo14ro}&BoniComplementaria={trabajador.BoniComplementaria}&BoniEspecial={trabajador.BoniEspecial}&Remuneracion_Minima={trabajador.Remuneracion_Minima}&CuotaCuentaCorriente={trabajador.CuotaCuentaCorriente}&Fondo_Reserva={trabajador.Fondo_Reserva}&Mensaje={trabajador.Mensaje}");
            var result = responseTask.Result;
            Trabajador? trab = new();
            if (result.IsSuccessStatusCode)
            {
                trab = await result.Content.ReadFromJsonAsync<Trabajador?>();
            }
            return trab;
        }
        [HttpPut("Update")]
        public async Task<Trabajador?> Update([FromBody] Trabajador trabajador)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var responseTask = client.GetAsync($"TrabajadorUpdate?COMP_Codigo={trabajador.COMP_Codigo}&Tipo_trabajador={trabajador.Tipo_trabajador}&Apellido_Paterno={trabajador.Apellido_Paterno}&Apellido_Materno={trabajador.Apellido_Materno}&Nombres=a&Identificacion={trabajador.Identificacion}&Entidad_Bancaria={trabajador.Entidad_Bancaria}&CarnetIESS={trabajador.CarnetIESS}&Direccion={trabajador.Direccion}&Telefono_Fijo={trabajador.Telefono_Fijo}&Telefono_Movil={trabajador.Telefono_Movil}&Genero={trabajador.Genero}&Nro_Cuenta_Bancaria={trabajador.Nro_Cuenta_Bancaria}&Codigo_Categoria_Ocupacion={trabajador.Codigo_Categoria_Ocupacion}&Ocupacion={trabajador.Ocupacion}&Centro_Costos={trabajador.Centro_Costos}&Nivel_Salarial={trabajador.Nivel_Salarial}&EstadoTrabajador={trabajador.EstadoTrabajador}&Tipo_Contrato={trabajador.Tipo_Contrato}&Tipo_Cese={trabajador.Tipo_Cese}&EstadoCivil={trabajador.EstadoCivil}&TipodeComision={trabajador.TipodeComision}&FechaNacimiento={trabajador.FechaNacimiento}&FechaIngreso={trabajador.FechaIngreso}&FechaCese={trabajador.FechaCese}&PeriododeVacaciones={trabajador.PeriododeVacaciones}&FechaReingreso={trabajador.FechaReingreso}&Fecha_Ult_Actualizacion={trabajador.Fecha_Ult_Actualizacion}&EsReingreso={trabajador.EsReingreso}&BancoCTA_CTE={trabajador.BancoCTA_CTE}&Tipo_Cuenta={trabajador.Tipo_Cuenta}&RSV_Indem_Acumul={trabajador.RSV_Indem_Acumul}&A%C3%B1o_Ult_Rsva_Indemni={trabajador.Año_Ult_Rsva_Indemni}&Mes_Ult_Rsva_Indemni={trabajador.Mes_Ult_Rsva_Indemni}&FormaCalculo13ro={trabajador.FormaCalculo13ro}&FormaCalculo14ro={trabajador.FormaCalculo14ro}&BoniComplementaria={trabajador.BoniComplementaria}&BoniEspecial={trabajador.BoniEspecial}&Remuneracion_Minima={trabajador.Remuneracion_Minima}&CuotaCuentaCorriente={trabajador.CuotaCuentaCorriente}&Fondo_Reserva={trabajador.Fondo_Reserva}&Mensaje={trabajador.Mensaje}");
            var result = responseTask.Result;
            Trabajador? trab = new();
            if (result.IsSuccessStatusCode)
            {
                trab = await result.Content.ReadFromJsonAsync<Trabajador?>();
            }
            return trab;
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
                trab = await result.Content.ReadFromJsonAsync<Trabajador?>();
            }
            return trab;
        }
        static bool VerificarCedula(string cedula)
        {
            if (cedula.Length != 10)
            {
                return false;
            }

            // Verificar que todos los caracteres sean dígitos numéricos
            foreach (char c in cedula)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            // Obtener los primeros dos dígitos que representan la provincia
            string provinciaCodigo = cedula.Substring(0, 2);

            // Verificar que el código de provincia sea válido
            int provincia;
            if (!int.TryParse(provinciaCodigo, out provincia) || provincia < 1 || provincia > 24)
            {
                return false;
            }

            // Verificar el último dígito de verificación
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
