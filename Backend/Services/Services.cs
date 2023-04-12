using BackendAja.Models;

namespace Backend.Services
{
    public interface Services
    {
        public IEnumerable<Usuario> Get();
        public Usuario? GetUsuario(int id);
    }
}
