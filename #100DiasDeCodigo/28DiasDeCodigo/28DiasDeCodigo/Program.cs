using System;

// Extension Methods
// São métodos que estendem a funcionalidade de um tipo,
// sem precisar alterar o código fonte deste tipo, nem herdar desse tipo.

// Retornando data em horas ou dias.
DateTime dt = new DateTime(2025, 3, 24, 8, 10, 45);
Console.WriteLine(dt.ElapsedTime());

// Cortando strings
string s1 = "Good morning dear students!";
Console.WriteLine(s1.Cut(10));
