using System.ComponentModel;

namespace PlataformaVendas.Dominio.Utils
{
    public enum TipoValidacaoEnum
    {
        [Description("Sms")]
        Sms = 1,

        [Description("E-mail")]
        Email = 2,

        [Description("WhatsApp")]
        WhatsApp = 3
    }
}
