using Classes;

// construtor sem parâmetros
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Willian";
pessoa1.Idade = 26;
pessoa1.Genero = "masculino";
pessoa1.Identificar();

Pessoa pessoa2 = new Pessoa("Amanda", 40, "feminino");
pessoa2.Identificar();

//construtor com apenas um parâmetro
Pessoa pessoa3 = new Pessoa("Bianca");
pessoa3.Idade = 18;
pessoa3.Genero = "feminino";
pessoa3.Identificar();
