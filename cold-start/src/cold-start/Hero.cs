
namespace cold_start
{
    public class Hero
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Hero(string id, string Name, int Year)
        {
            this.Id = Id;
            this.Name = Name;
            this.Year = Year;
        }
    }
}