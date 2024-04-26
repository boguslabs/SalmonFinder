namespace RiverCsvReader.Models
{
    public class River
    {
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public int Population { get; set; }
public River(string name, DateOnly date, int population)
        {
            Name = name;
            Date = date;
            Population = population;
        }
    }
}