namespace Coffee.Api.Models
{
    public class CoffeeRecord
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Bean { get; set; }
        public string Shop { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}
