namespace Task3;

public class FootballClub
{
    public required string Name { get; init; }
    
    public int YearOfFoundation { get; init; }
    
    public required string HeadCoach { get; init; }


    public FootballClub() { }

    public FootballClub(string name, int year, string coach)
    {
        Name = name;
        YearOfFoundation = year;
        HeadCoach = coach;
    }

    public override string ToString()
    {
        return $"Name: {Name}, HeadCoach: {HeadCoach}, Year of foundation: {YearOfFoundation}";
    }
}