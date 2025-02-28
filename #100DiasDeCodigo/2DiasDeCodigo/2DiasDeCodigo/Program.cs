using _2DiasDeCodigo;

// Consultas LINQ

var songs = new List<Songs>
{
    new Songs(1, "Bohemian Rhapsody", "Queen", new DateTime(1975, 10, 31)),
    new Songs(2, "Newborn Me", "Angra", new DateTime(2014, 12, 17)),
    new Songs(3, "November Rain", "Guns N' Roses", new DateTime(1991, 02, 18)),
    new Songs(4, "The Show Must Go On", "Queen", new DateTime(1991, 10, 14))
};

Console.WriteLine("Songs released in 1991");
var songs1991 = songs.Where(x => x.ReleaseDate.Year == 1991).ToList();

foreach (var items in songs1991)
{
    Console.WriteLine(items.ToString());
}
Console.WriteLine();

Console.WriteLine("Songs released on October");
var songsOnOctober = songs.Where(x => x.ReleaseDate.Month == 10).ToList();

foreach (var items in songsOnOctober)
{
    Console.WriteLine(items.ToString());
}
Console.WriteLine();

Console.WriteLine("Return songs in alphabetical order");
var songsOrder = songs.OrderBy(x => x.Name).ToList();

foreach (var items in songsOrder)
{
    Console.WriteLine(items.ToString());
}
Console.WriteLine();

Console.WriteLine("Last two songs registered in alphabetical order");
var lastTwoSongs = songs.OrderByDescending(x => x.ReleaseDate.Date)
    .Take(2).OrderBy(x => x.Name).ToList();

foreach (var items in lastTwoSongs)
{
    Console.WriteLine(items.ToString());
}
