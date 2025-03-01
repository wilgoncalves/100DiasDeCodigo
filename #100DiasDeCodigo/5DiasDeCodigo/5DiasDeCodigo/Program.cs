// Implicit Operators

// 1.
int x = 100;
double y = x;
// foi possível converter x de int para double naturalmente,
// afinal os números reais suportam inteiros.

// 2. 
double z = 100.38;
int w = (int)z; // w = 100
// Os números inteiros não são capazes de resolver números reais.
// Neste caso, precisamos explicitar a conversão.

//// 3. Sobreescrevendo o método ToString:
var phone = new Phone
{
CountryCode = "55",
Area = "11",
Number = "999999999"
};
Console.WriteLine(phone);

public class Phone
{
    public string? CountryCode { get; set; }
    public string? Area { get; set; }
    public string? Number { get; set; }

    public override string ToString()
    {
        return $"+{CountryCode} ({Area}) {Number}";
    }
}

// 4. Implicit operator (tipo complexo para string):
var phone = new Phone
{
CountryCode = "55",
Area = "11",
Number = "999999999"
};
var telefone = "123";
telefone = phone;
Console.WriteLine(telefone);

public class Phone
{
    public string? CountryCode { get; set; }
    public string? Area { get; set; }
    public string? Number { get; set; }

    public static implicit operator string(Phone phone)
    {
        return $"+{phone.CountryCode} ({phone.Area}) {phone.Number}";
    }
}

// 5. Implicit operator (string para tipo complexo):
var phone = new Phone();
phone = "55 11 999999999";
Console.WriteLine(phone);

public class Phone
{
    public string? CountryCode { get; set; }
    public string? Area { get; set; }
    public string? Number { get; set; }

    public static implicit operator string(Phone phone)
    {
        return $"+{phone.CountryCode} ({phone.Area}) {phone.Number}";
    }

    public static implicit operator Phone(string phone)
    {
        var data = phone.Split(' ');
        return new Phone 
        { 
            CountryCode = data[0],
            Area = data[1],
            Number = data[2]
        };
    }
}