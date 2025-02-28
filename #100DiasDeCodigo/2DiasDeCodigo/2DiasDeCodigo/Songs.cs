
namespace _2DiasDeCodigo
{
    public class Songs
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Band { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Songs(int id, string? name, string band, DateTime releaseDate)
        {
            Id = id;
            Name = name;
            Band = band;
            ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return $"Code: {Id} | Name: {Name} | Band: {Band} " +
                $"| Release date: {ReleaseDate}";
        }
    }
}
