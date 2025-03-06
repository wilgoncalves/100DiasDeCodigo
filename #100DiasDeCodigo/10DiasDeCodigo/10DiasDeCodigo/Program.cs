// Modificadores de parâmetros
// OUT, REF, IN, PARAMS

int value;

DoThat(out value);
Console.WriteLine(value);

// OUT - O output será atribuído para a variável do método.
void DoThat(out int number)
{
    number = 789;
}

//---------


int number = 1;
Increment(ref number);

Console.WriteLine(number);

// REF - passa o valor de referência para o método.
void Increment(ref int number)
{
    number++;
}

//------------

int number = 1;
Increment(number);

Console.WriteLine(number);

// IN - permite passar o parâmetro mas não é possível aterá-lo diretamente.
void Increment(in int number)
{
    //number++;
    var result = number + 1;
    // o valor do parâmetro number não é alterado.
}

//------------

UseParams(1, 2, 3, 4, 5, 6);

// PARAMS - permite passar uma lsita de forma dinâmica.
static void UseParams(params int[] list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

//-----------

UseParams(
    new Car("Ford"),
    new Car("Fiat")
);

static void UseParams(params Car[] list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

public record Car(string branch);