using PlataformaVendas.Dominio.Usuarios.Entidades;
using PlataformaVendas.Dominio.UsuariosLocal.Comandos;

namespace PlataformaVendas.Dominio.UsuariosLocal.Entidades
{
    public class UsuarioLocal
    {
        public int Id { get; private set; }
        public byte[] SenhaHash { get; private set; }
        public byte[] SenhaSalt { get; private set; }
        public DateTime? DataUltimoLogin { get; private set; }

        #region Relacionamento 1:1 com Usuario
        // Foreign key para Usuario
        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }
        #endregion

        private UsuarioLocal() { }

        public UsuarioLocal(UsuarioLocalInserirComando comando)
        {
            SetSenhaHash(comando.SenhaHash);
            SetSenhaSalt(comando.SenhaSalt);
            SetUsuarioId(comando.UsuarioId);
            DataUltimoLogin = DateTime.UtcNow;
        }

        public void SetUsuarioId(int usuarioId)
        {
            UsuarioId = usuarioId;
        }

        public void SetSenhaSalt(byte[] senhaSalt)
        {
            SenhaSalt = senhaSalt;
        }

        public void SetSenhaHash(byte[] senhaHash)
        {
            SenhaHash = senhaHash;
        }
    }
}
