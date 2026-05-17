
using PlataformaVendas.Dominio.Utils;

namespace PlataformaVendas.Dominio.UsuariosExterno.Comandos
{
    public class UsuarioExternoInserirComando
    {
        public int UsuarioId { get; set; }
        public ProvedorEnum Provedor { get; private set; }
        public long IdProvedor { get; private set; }
        public DateTime? DataUltimoLogin { get; private set; }
    }
}
