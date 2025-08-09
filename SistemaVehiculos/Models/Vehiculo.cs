namespace SistemaVehiculos.Models;

public class Vehiculo
{   
    // Atributos para Vehiculo
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }
    
    // Metodos
    public virtual void MostrarInformacion()
    {
        Console.WriteLine("----- Información del vehículo -----");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Año: {Anio}");
    } // Fin de MostrarInformacion
    
} // Fin de class