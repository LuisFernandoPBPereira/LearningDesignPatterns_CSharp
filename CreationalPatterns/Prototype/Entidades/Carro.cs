namespace Prototype.Entidades;

public class Carro : CarroPrototype
{
    public Carro(string marca, string modelo) : base(marca, modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
}
