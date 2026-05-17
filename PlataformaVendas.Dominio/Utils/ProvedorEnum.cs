
using System.ComponentModel;

namespace PlataformaVendas.Dominio.Utils
{
    public enum ProvedorEnum
    {
        [Description("Google")]
        Google = 0,

        [Description("Facebook")]
        Facebook = 1,

        [Description("Apple")]
        Apple = 2,

        [Description("Microsoft")]
        Microsoft = 3
    }
}
