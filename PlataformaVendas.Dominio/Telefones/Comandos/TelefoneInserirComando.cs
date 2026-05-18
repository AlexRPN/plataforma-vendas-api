using PlataformaVendas.Dominio.Utils;

namespace PlataformaVendas.Dominio.Telefones.Comandos
{
    public class TelefoneInserirComando
    {
        public string Numero { get; private set; }
        public TipoValidacaoEnum TipoValidacao { get; private set; }
        public StatusConfirmacaoEnum StatusValidacao { get; private set; }
        public DateTime? DataValidacao { get; private set; }
    }
}
