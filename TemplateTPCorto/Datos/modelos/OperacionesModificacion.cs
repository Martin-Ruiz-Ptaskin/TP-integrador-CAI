using System.Globalization;
using System;

public class OperacionesModificacion
{
    public string IdOperacion { get; set; }
    public string Legajo { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Dni { get; set; }
    public DateTime FechaIngreso { get; set; }

    public OperacionesModificacion(string lineaCsv)
    {
        string[] partes = lineaCsv.Split(';');
        IdOperacion = partes[0];
        Legajo = partes[1];
        Nombre = partes[2];
        Apellido = partes[3];
        Dni = partes[4];
        FechaIngreso = DateTime.ParseExact(partes[5], "d/M/yyyy", CultureInfo.InvariantCulture);

    }

    public string DisplayInfo
    {
        get
        {
            return $"{Nombre} {Apellido} - {Dni} - Legajo: {Legajo}";
        }
    }
}
