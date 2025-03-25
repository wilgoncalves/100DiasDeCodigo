using System.Globalization;

// DateTime - representando data e hora

// Retorna o instante atual:

DateTime d1 = DateTime.Now;
Console.WriteLine(d1);

// Construtores:
DateTime d2 = new DateTime(2024, 11, 25);
Console.WriteLine(d2);
DateTime d3 = new DateTime(2024, 11, 25, 20, 45, 3);
Console.WriteLine(d3);
DateTime d4 = new DateTime(2024, 11, 25, 20, 45, 3, 500);
Console.WriteLine(d4);

// Data atual no horário das 0h:
DateTime d5 = DateTime.Today;
Console.WriteLine(d5);

// Horário universal:
DateTime d6 = DateTime.UtcNow;
Console.WriteLine(d6);

// Formatando datas:
DateTime d7 = DateTime.Parse("2000-08-15");
Console.WriteLine(d7);
DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
Console.WriteLine(d8);
DateTime d9 = DateTime.Parse("15/08/2000");
DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
Console.WriteLine(d10);
// Parse Exact:
DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
Console.WriteLine(d11);
DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
Console.WriteLine(d12);

// TimeSpan - representa uma duração

TimeSpan t1 = new TimeSpan(0, 1, 30);
Console.WriteLine(t1);

// Construtores:
TimeSpan t2 = new TimeSpan();
Console.WriteLine(t2);
TimeSpan t3 = new TimeSpan(900000000L);
Console.WriteLine(t3);
TimeSpan t4 = new TimeSpan(2, 11, 21);
Console.WriteLine(t4);
TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
Console.WriteLine(t5);
TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
Console.WriteLine(t6);

// Método FROM:
TimeSpan t7 = TimeSpan.FromDays(1.5);
Console.WriteLine(t7);
TimeSpan t8 = TimeSpan.FromHours(1.5);
Console.WriteLine(t8);
TimeSpan t9 = TimeSpan.FromMinutes(1.5);
Console.WriteLine(t9);
TimeSpan t10 = TimeSpan.FromSeconds(1.5);
Console.WriteLine(t10);
TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
Console.WriteLine(t11);
TimeSpan t12 = TimeSpan.FromTicks(900000000L);
Console.WriteLine(t12);