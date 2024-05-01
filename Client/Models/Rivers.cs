namespace RiverCsvReader.Models
{
    public class River
    {
        public string Name { get; set; }
        public int Date { get; set; }
        public int Population { get; set; }
        public River(string name, int date, int population)
        {
            Name = name;
            Date = date;
            Population = population;
        }
    }
}