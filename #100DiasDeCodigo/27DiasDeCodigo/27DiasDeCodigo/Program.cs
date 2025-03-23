using System.Collections.Generic;

// Dictionary

// Dictionary: armazenamento em tabela hash, a ordem dos elementos não é garantida.
Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "maria";
cookies["email"] = "maria@gmail.com";
// Dictionary não aceita repetições, portanto a chave será sobreescrita com o segundo valor informado.
cookies["phone"] = "99771122";
cookies["phone"] = "99771133";

Console.WriteLine(cookies["phone"]);
Console.WriteLine(cookies["email"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine("Email: " + cookies["email"]);
}
else
{
    Console.WriteLine("There is not 'email' key");
}

Console.WriteLine("Phone number: " + cookies["phone"]);

Console.WriteLine("Size: " + cookies.Count);

Console.WriteLine("ALL COOKIES:");

foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}