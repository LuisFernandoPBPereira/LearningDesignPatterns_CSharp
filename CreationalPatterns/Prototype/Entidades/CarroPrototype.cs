using Prototype.Interfaces;

namespace Prototype.Entidades;

public class CarroPrototype : IPrototype
{

    public string Marca { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    
    public CarroPrototype(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public IPrototype Clonar() => new Carro(Marca, "Corsa");
}
