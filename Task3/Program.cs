namespace Task3;
using System.Globalization;

public static class Program
{
    public static void Main(string[] args)
    {
        var clubs = new Dictionary<string, List<FootballClub>>()
        {
            { "London", [
                    new FootballClub("Arsenal", 1886, "Mikel Arteta"),
                    new FootballClub("Chelsea", 1905, "Graham Potter"),
                    new FootballClub("Tottenham Hotspur", 1882, "Antonio Conte"),
                    new FootballClub("West Ham United", 1895, "David Moyes"),
                    new FootballClub("Fulham", 1879, "Marco Silva")
                ]
            },
    
            {"Manchester", [
                    new FootballClub("Manchester United", 1878, "Erik ten Hag"),
                    new FootballClub("Manchester City", 1880, "Pep Guardiola")
                ]
            },
    
            {"Liverpool", [
                    new FootballClub("Liverpool", 1892, "Jurgen Klopp"),
                    new FootballClub("Everton", 1878, "Sean Dyche")
                ]
            },
    
            {"Milan", [
                    new FootballClub("AC Milan", 1899, "Stefano Pioli"),
                    new FootballClub("Inter Milan", 1908, "Simone Inzaghi")
                ]
            },
    
            {"Madrid",
                [new FootballClub("Real Madrid", 1902, "Carlo Ancelotti")]
            },

            { "Barcelona",
                [new FootballClub("Barcelona", 1899, "Xavi Hernandez")]
            },

            { "Munich",
                [new FootballClub("Bayern Munich", 1900, "Thomas Tuchel")]
            },
    
            {"Turin",
                [new FootballClub("Juventus", 1897, "Massimiliano Allegri")]
            },
            
            {"Rivne",
            [new FootballClub("Veres", 1957, "Oleh Shandruk")]
        }
        };

        
        while (true)
        {
            Console.Write("Input city name: ");

            var city = Console.ReadLine();

            if (city != null && clubs.TryGetValue(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(city), value: out var club1))
            {
                foreach (var club in club1)
                {
                    Console.WriteLine(club.ToString());
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"No clubs found in {city}.");
                Console.WriteLine();
            }
        }
    }
}