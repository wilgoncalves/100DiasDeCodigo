using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

// LINQ: LINQ (Language Integrated Query) é uma parte da plataforma .NET da Microsoft. 
// Permite realizar consultas em várias fontes de dados, como bancos de dados relacionais,
// coleções de objetos, documentos XML, entre outros. 

// Expressões Lambda: São funções anônimas que podem conter expressões e declarações.
// São úteis quando se precisa passar uma função como argumento para outro método.

var fruits = new List<string>();
fruits.Add("cereja");
fruits.Add("abacaxi");
fruits.Add("maçã");
fruits.Add("pêssego");
fruits.Add("mirtilo");
fruits.Add("coco");
fruits.Add("banana");

// 1. Primeiro Elemento:
Console.WriteLine(fruits.First());
Console.WriteLine(fruits.FirstOrDefault("Não encontrei."));

// 2. Verificar se um elemento existe:
Console.WriteLine(fruits.Any(x => x == "cereja"));

// 3. Verificar se todos os elementos são de um tipo:
Console.WriteLine(fruits.All(x => x == "cereja"));

// 4. Contar:
Console.WriteLine(fruits.Count);
Console.WriteLine(fruits.Count(x => x == "cereja"));

// 5. ElementAt - índice:
Console.WriteLine(fruits.ElementAt(5));

// 6. Take:
foreach (var fruit in fruits.Take(3)) // Pegando os 3 primeiros elementos.
    Console.WriteLine(fruit);

// 7. Where:
foreach (var fruit in fruits
        .Where(x => x == "cereja" || x == "banana"))
    Console.WriteLine(fruit);

// 8. Single:
Console.WriteLine(fruits.Single(x => x == "coco"));
Console.WriteLine(fruits.SingleOrDefault(x => x == "cereja"));

// 9. Último elemento:
Console.WriteLine(fruits.Last());

// 10. Skip:
foreach (var fruit in fruits.Skip(3))
    Console.WriteLine(fruit);