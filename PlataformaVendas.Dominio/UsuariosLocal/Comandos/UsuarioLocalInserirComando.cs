
namespace PlataformaVendas.Dominio.UsuariosLocal.Comandos
{
    public class UsuarioLocalInserirComando
    {
        public byte[] SenhaHash { get; private set; }
        public byte[] SenhaSalt { get; private set; }
        public DateTime DataUltimoLogin { get; private set; }
        public int UsuarioId { get; private set; }
    }
}
