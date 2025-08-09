using SistemaVehiculos.Models;

namespace SistemaVehiculos;

public class Moto : Vehiculo
{
    // Atributos para Moto
    public int Cilindrada { get; set; } // en cc
    public bool TieneMaletero { get; set; }
    // Metodos
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Cilindrada: {Cilindrada} cc");
        Console.WriteLine($"Maletero: {(TieneMaletero ? "Si" : "No")}");
        Console.WriteLine();
    } // Fin de MostrarInformacion (para moto)
    
} // Fin de class