namespace Task3;

public record FootballClub(string Name, int YearOfFoundation, string HeadCoach)
{
    public override string ToString()
    {
        return $"Name: {Name}, HeadCoach: {HeadCoach}, Year of foundation: {YearOfFoundation}";
    }
}