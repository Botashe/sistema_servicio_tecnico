using System;
using System.Collections.Generic;

namespace mercy_developer.Models;

public partial class Servicio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? Precio { get; set; }

    public string? Sku { get; set; }

    public int UsuariosId { get; set; }

    public virtual Usuario Usuarios { get; set; } = null!;
}
