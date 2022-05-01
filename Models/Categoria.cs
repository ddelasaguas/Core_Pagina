using System;
using System.Collections.Generic;
namespace Core_Pagina.Models;


public class Categoria
{
    public int IdCategoria { get; set; }
    public string CodCategoria { get; set; }
    public string Nombre { get; set; }
    public Guid idTienda { get; set; }
}
