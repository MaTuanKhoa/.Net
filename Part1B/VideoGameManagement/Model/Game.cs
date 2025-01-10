namespace VideoGameManagement.Model;

internal class Game
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }

    public Game(string name, string genre, int year, string description)
    {
        Name = name;
        Genre = genre;
        Year = year;
        Description = description;
    }

    public override string ToString()
    {
        return $"\tName: {Name}\n \tGenre: {Genre}\n \tYear: {Year}\n \tDescription: {Description}\n\n";
    }
}

