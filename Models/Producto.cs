using System;
using System.Collections.Generic;
namespace Core_Pagina.Models;


public class Producto
{
    public Int64 IdProducto { get; set; }
    public string Modelo { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }´
    public int IdCategoria  { get; set; }
    public int idTipoProducto { get; set; }
    public Guid IdTienda { get; set; }
}
