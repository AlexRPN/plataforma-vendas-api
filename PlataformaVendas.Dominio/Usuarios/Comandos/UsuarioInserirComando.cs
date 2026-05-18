using PlataformaVendas.Dominio.Utils;

namespace PlataformaVendas.Dominio.Usuarios.Comandos
{
    public class UsuarioInserirComando
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public string Cnpj { get; private set; }
        public string Email { get; set; }
        public StatusConfirmacaoEnum EmailConfirmado { get; set; }
        public DateTime DataEmailConfirmado { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public AtivoInativoEnum Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataUltimoLogin { get; private set; }
    }
}
