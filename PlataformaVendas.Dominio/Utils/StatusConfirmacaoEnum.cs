using System.ComponentModel;

namespace PlataformaVendas.Dominio.Utils
{
    public enum StatusConfirmacaoEnum
    {
        [Description("Não Confirmado")]
        NaoConfirmado = 0,

        [Description("Confirmado")]
        Confirmado = 1,

        [Description("Pendente")]
        Pendente = 2,

        [Description("Expirado")]
        Expirado = 3
    }
}
