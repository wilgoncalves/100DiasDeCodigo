using Polimorfismo;

// Polimorfismo em tempo de execução (overriding/sobrescrita)
var figuras = new List<Figura>
{
    new Circulo(),
    new Triangulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}