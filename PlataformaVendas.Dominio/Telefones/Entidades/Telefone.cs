using PlataformaVendas.Dominio.Telefones.Comandos;
using PlataformaVendas.Dominio.Usuarios.Entidades;
using PlataformaVendas.Dominio.Utils;

namespace PlataformaVendas.Dominio.Telefones.Entidades
{
    public class Telefone
    {
        public int Id { get; private set; }
        public string Numero { get; private set; }
        public TipoValidacaoEnum TipoValidacao { get; private set; }
        public StatusConfirmacaoEnum StatusValidacao { get; private set; }
        public DateTime? DataValidacao { get; private set; }

        #region Relacionamento 1:1 com Usuario
        // Foreign key para Usuario
        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }
        #endregion

        private Telefone() { }

        public Telefone(TelefoneInserirComando comando)
        {
            SetNumero(comando.Numero);
            TipoValidacao = comando.TipoValidacao;
            StatusValidacao = comando.StatusValidacao;
            DataValidacao = null;
        }

        public void SetNumero(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                throw new ArgumentException("O número de telefone é obrigatório.");

            if (numero.Length < 8 || numero.Length > 15)
                throw new ArgumentException("O número de telefone deve ter entre 8 e 15 caracteres.");

            Numero = numero;
        }
    }
}
