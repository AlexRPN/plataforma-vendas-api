
using System.ComponentModel;

namespace PlataformaVendas.Dominio.Utils
{
    public enum TipoUsuarioEnum
    {
        [Description("Vendedor")]
        Vendedor = 1,
        [Description("Cliente")]
        Cliente = 2
    }
}
