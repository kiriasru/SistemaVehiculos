using SistemaVehiculos;
using SistemaVehiculos.Models;

// Carrros
Carro carro1 = new Carro
{
    Marca = "Toyota", 
    Modelo = "Corolla", 
    Anio = 2020, 
    NumeroPuertas = 4, 
    TipoCombustible = "Gasolina"
};

Carro carro2 = new Carro
{
    Marca = "Ford", Modelo = "F-150", 
    Anio = 2018, NumeroPuertas = 2, 
    TipoCombustible = "Gasolina"
};

// Motos
Moto moto1 = new Moto
{
    Marca = "Honda", 
    Modelo = "CBR500R", 
    Anio = 2019, 
    Cilindrada = 500, 
    TieneMaletero = false
};

Moto moto2 = new Moto
{
    Marca = "Yamaha", 
    Modelo = "XSR700", 
    Anio = 2021, 
    Cilindrada = 689, 
    TieneMaletero = true
};

// List de vehiculos
var vehiculos = new List<Vehiculo> { carro1, carro2, moto1, moto2 };

Console.WriteLine("=== Información de todos los vehículos ===\n");

foreach (var vehic in vehiculos)
{
    vehic.MostrarInformacion();
}