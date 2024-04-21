namespace Task3;

public static class Program
{
    public static void Main(string[] args)
    {
        var clubs = new Dictionary<string, List<FootballClub>>()
        {
            { "London", [
                    new FootballClub() { Name = "Arsenal", YearOfFoundation = 1886, HeadCoach = "Mikel Arteta" },
                    new FootballClub() { Name = "Chelsea", YearOfFoundation = 1905, HeadCoach = "Graham Potter" },
                    new FootballClub() { Name = "Tottenham Hotspur", YearOfFoundation = 1882, HeadCoach = "Antonio Conte" },
                    new FootballClub() { Name = "West Ham United", YearOfFoundation = 1895, HeadCoach = "David Moyes" },
                    new FootballClub() { Name = "Fulham", YearOfFoundation = 1879, HeadCoach = "Marco Silva" }
                ]
            },
            
            {"Manchester", [
                    new FootballClub()
                        { Name = "Manchester United", YearOfFoundation = 1878, HeadCoach = "Erik ten Hag" },
                    new FootballClub()
                        { Name = "Manchester City", YearOfFoundation = 1880, HeadCoach = "Pep Guardiola" }
                ]
            },
            
            {"Liverpool", [
                    new FootballClub() { Name = "Liverpool", YearOfFoundation = 1892, HeadCoach = "Jurgen Klopp" },
                    new FootballClub() { Name = "Everton", YearOfFoundation = 1878, HeadCoach = "Sean Dyche" }
                ]
            },
            
            {"Milan", [
                    new FootballClub() { Name = "AC Milan", YearOfFoundation = 1899, HeadCoach = "Stefano Pioli" },
                    new FootballClub() { Name = "Inter Milan", YearOfFoundation = 1908, HeadCoach = "Simone Inzaghi" }
                ]
            },
            
            {"Madrid",
                [new FootballClub() { Name = "Real Madrid", YearOfFoundation = 1902, HeadCoach = "Carlo Ancelotti" }]
            },

            { "Barcelona",
                [new FootballClub() { Name = "Barcelona", YearOfFoundation = 1899, HeadCoach = "Xavi Hernandez" }]
            },

            { "Munich",
                [new FootballClub() { Name = "Bayern Munich", YearOfFoundation = 1900, HeadCoach = "Thomas Tuchel" }]
            },
            
            {"Turin",
                [new FootballClub() { Name = "Juventus", YearOfFoundation = 1897, HeadCoach = "Massimiliano Allegri" }]
            }
        };

        Console.Write("Input city name: ");
        
        var city = Console.ReadLine();
        
        if (city != null && clubs.TryGetValue(city, value: out var club1))
        {
            foreach (var club in club1)
            {
                Console.WriteLine(club.ToString());
            }
        }
        else
        {
            Console.WriteLine($"No clubs found in {city}.");
        }
    }
}