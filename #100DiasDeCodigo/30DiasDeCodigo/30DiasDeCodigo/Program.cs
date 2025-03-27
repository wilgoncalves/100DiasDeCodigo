// Propriedades e operações com DateTime

DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
Console.WriteLine(d);
Console.WriteLine($"1. Date: {d.Date}");
Console.WriteLine($"2. Day: {d.Day}");
Console.WriteLine($"3. DayOfWeek: {d.DayOfWeek}");
Console.WriteLine($"4. DayOfYear: {d.DayOfYear}");
Console.WriteLine($"5. Hour: {d.Hour}");
Console.WriteLine($"6. Kind: {d.Kind}");
Console.WriteLine($"7. Millisecond: {d.Millisecond}");
Console.WriteLine($"8. Minute: {d.Minute}");
Console.WriteLine($"9. Month: {d.Month}");
Console.WriteLine($"10. Second: {d.Second}");
Console.WriteLine($"11. Ticks: {d.Ticks}");
Console.WriteLine($"12. TimeOfDay: {d.TimeOfDay}");
Console.WriteLine($"13. Year: {d.Year}");

// Funções de conversão:

DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58);

string s1 = d1.ToLongDateString();
string s2 = d1.ToLongTimeString();
string s3 = d1.ToShortDateString();
string s4 = d1.ToShortTimeString();
string s5 = d1.ToString();

// ToString() com sobrecarga:
string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss");
string s7 = d1.ToString("yyyy-MM-dd HH:mm:ss.fff");

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);
Console.WriteLine(s5);
Console.WriteLine(s6);
Console.WriteLine(s7);

// Operações DateTime:

DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);

DateTime d3 = d2.AddHours(2);
DateTime d4 = d2.AddMinutes(3);

Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);

DateTime d5 = DateTime.Now;
DateTime d6 = d5.AddDays(7);

Console.WriteLine(d5);
Console.WriteLine(d6);

// Diferença entre datas:
DateTime d7 = new DateTime(2000, 10, 15);
DateTime d8 = new DateTime(2000, 10, 18);
TimeSpan t = d8.Subtract(d7);
Console.WriteLine(t);


// Propriedades e operações com TimeSpan

TimeSpan t1 = TimeSpan.MaxValue;
TimeSpan t2 = TimeSpan.MinValue;
TimeSpan t3 = TimeSpan.Zero;

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);

TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
Console.WriteLine(t4);

Console.WriteLine($"Days: {t4.Days}");
Console.WriteLine($"Hours: {t4.Hours}");
Console.WriteLine($"Minutes: {t4.Minutes}");
Console.WriteLine($"Milliseconds: {t4.Milliseconds}");
Console.WriteLine($"Seconds: {t4.Seconds}");
Console.WriteLine($"Ticks: {t4.Ticks}");

Console.WriteLine($"TotalDays: {t4.TotalDays}");
Console.WriteLine($"TotalHours: {t4.TotalHours}");
Console.WriteLine($"TotalMinutes: {t4.TotalMinutes}");
Console.WriteLine($"TotalSeconds: {t4.TotalSeconds}");
Console.WriteLine($"TotalMilliseconds: {t4.TotalMilliseconds}");

// Operações TimeSpan:

TimeSpan t5 = new TimeSpan(1, 30, 10);
TimeSpan t6 = new TimeSpan(0, 10, 5);

TimeSpan soma = t5.Add(t6);
TimeSpan diferenca = t5.Subtract(t6);
TimeSpan multiplicacao = t6.Multiply(2.0);
TimeSpan divisao = t6.Divide(2.0);

Console.WriteLine(soma);
Console.WriteLine(diferenca);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao);