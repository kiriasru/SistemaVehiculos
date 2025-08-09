using SistemaVehiculos.Models;

namespace SistemaVehiculos;

public class Carro : Vehiculo
{
    // Atributos para Carro
    public int NumeroPuertas { get; set; }
    public string TipoCombustible { get; set; }
    // Metodos
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Número de puertas: {NumeroPuertas}");
        Console.WriteLine($"Tipo de combustible: {TipoCombustible}");
        Console.WriteLine();
    } // Fin de MostrarInformacion (para carro)
    
} // Fin de class