using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;
namespace ValFec.Models;

public class Fecha
{
    [FutureDate]
    [DataType(DataType.Date, ErrorMessage = "Proporcione una fecha")]
    public DateTime PruebaFecha { get; set; }

    [FutureDate]
    [DataType(DataType.DateTime, ErrorMessage = "Proporcione una fecha con hora")]
    public DateTime PruebaFechaHora { get; set; }
}
