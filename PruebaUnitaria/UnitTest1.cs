using Backend.Controllers;
using Backend.Services;
using BackendAja.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace PruebaUnitaria
{
    public class UnitTest1
    {

        private readonly EmisorController emisorController;
        private readonly UsuariosController usuariosController;
        private readonly Services _services;

        public UnitTest1()
        {
            
            emisorController = new EmisorController();
            usuariosController = new UsuariosController();
            
        }

        /*[Fact]
        public void Eet_OK()
        {
            var result = emisorController.Get();

            Assert.IsNotType<BadRequestResult>(result);
        }

        [Fact]
        public void User_OK()
        {
            int usuario = 0;
            string password = "5004U";
            var result = usuariosController.Get(usuario, password).Result;

            Assert.Equal(result.Observacion, "INGRESO EXITOSO");
        }*/

        [Fact]
        public void UsuarioEmisor()
        {
            int usuario = 5004;
            string password = "5004U";
            var usuaroiResult = usuariosController.Get(usuario, password).Result;
            var emisorResult = emisorController.Get().Result;
            Assert.Equal(usuaroiResult.Observacion, "INGRESO EXITOSO");
            Assert.Equal(emisorResult.Find(e => e.Codigo == usuaroiResult.Emisor).Codigo, usuaroiResult.Emisor);
        }

    }
}