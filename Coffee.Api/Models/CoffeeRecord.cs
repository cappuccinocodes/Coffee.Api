namespace Coffee.Api.Models
{
    public class CoffeeRecord
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string? Bean { get; set; }
        public string Location { get; set; }
        public DateTime DateCreated { get; set; }
        public int Score { get; set; }
        public int NoOfShots { get; set; }
    }
}

/* CREATE TABLE "Records" (
	                      Id int IDENTITY(1,1) NOT NULL,
	                      Type TEXT NOT NULL UNIQUE,
						  Bean TEXT NULL,
						  Location TEXT NOT NULL,
						  DateCreated TEXT NOT NULL,
						  NoOfShots INT NOT NULL,
						  Score INT NOT NULL,
	                      PRIMARY KEY (Id)
                         ); */