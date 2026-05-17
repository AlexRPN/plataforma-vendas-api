using PlataformaVendas.Dominio.Usuarios.Entidades;
using PlataformaVendas.Dominio.UsuariosExterno.Comandos;
using PlataformaVendas.Dominio.Utils;

namespace PlataformaVendas.Dominio.UsuariosExterno.Entidades
{
    public class UsuarioExterno
    {
        public int Id { get; private set; }
        public ProvedorEnum Provedor { get; private set; }
        public long IdProvedor { get; private set; }
        public DateTime? DataUltimoLogin { get; private set; } = null;

        #region Relacionamento N:1 com Usuario
        // Foreign key para Usuario
        public int UsuarioId { get; private set; }
        public Usuario? Usuario { get; private set; }
        #endregion

        private UsuarioExterno() { }

        public UsuarioExterno(UsuarioExternoInserirComando comando)
        {
            SetProvedor(comando.Provedor);
            SetIdProvedor(comando.IdProvedor);
            SetUsuarioId(comando.UsuarioId);
        }

        public void SetUsuarioId(int usuarioId)
        {
            UsuarioId = usuarioId;
        }

        public void SetIdProvedor(long idProvedor)
        {
            IdProvedor = idProvedor;
        }

        public void SetProvedor(ProvedorEnum provedor)
        {
            Provedor = provedor;
        }
    }
}
