using System;
using System.Collections.Generic;
namespace Core_Pagina.Models;


public class Imagen
{
    public Guid idImagen { get; set; }
    public Int64 idProducto { get; set; }
    public bool predeterminada { get; set; }
}
