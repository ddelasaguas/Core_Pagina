using System;
using System.Collections.Generic;
namespace Core_Pagina.Models;


public class TipoProducto
{
    public int idTipoProducto { get; set; }
    public string Nombre { get; set; }
    public Guid idTienda { get; set; }
}
