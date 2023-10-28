using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;
namespace ValFec.Models;

public class Fecha
{
    [FutureDate]
    public DateTime PruebaFecha { get; set; }

    [FutureDate]
    public DateTime PruebaFechaHora { get; set; }
}
