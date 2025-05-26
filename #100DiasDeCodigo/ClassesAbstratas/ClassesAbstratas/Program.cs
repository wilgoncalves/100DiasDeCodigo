using ClassesAbstratas;

Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("Informe a cor da figura.:");
q.Cor = Console.ReadLine();

Console.WriteLine("Informe o lado do quadrado:");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"A área do quadrado é: {q.Area} m2");
Console.WriteLine($"O perímetro do quadrado é: {q.Perimetro} m");
Console.WriteLine($"A cor do quadrado é: {q.Cor}");
