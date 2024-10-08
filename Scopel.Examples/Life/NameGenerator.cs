namespace Scopel.Examples.Life;
public static class NameGenerator
{
    public static string GenerateRandomName()
    {
        var random = new Random();
        var addName3 = random.Next(5);
        if (addName3 == 3)
            return Names.RandomName(random) + " " + Names2.RandomName(random) + " " + Names3.RandomName(random);
        else return Names.RandomName(random) + " " + Names2.RandomName(random);
    }

    private static string[] Names => ["Noah", "Oliver", "George", "Arthur", "Muhammad", "Leo", "Harry", "Oscar", "Archie",
        "Henry", "Olivia", "Amelia", "Isla", "Ava", "Ivy", "Freya", "Lily", "Florence", "Mia", "Willow", "Alma", "Blind", "Alice",
        "Dudley", "Bonnie", "James", "Boudicca", "Jonathan", "Cailin", "Lloyd", "Dee", "Norman", "Rose", "Clark", "Ginger", "Chester", "Fleur",
        "Elton", "Claribel", "Marvin", "Honora", "Jameson", "Leonora", "Montague", "Lupita", "Olivier", "Milou", "KaneWendy", "Logan"];

    private static string[] Names2 => ["Dunce", "Quincy", "Durham", "Raleigh", "Dyson", "Ralphs", "Eddington", "Ramacey", "Erickson", "Russel",
        "Evans", "Ryder", "Faber", "Salisburry", "Gilbert", "Wainwright", "Harrison", "Winter"];

    private static string[] Names3 => ["jr", "I", "II", "III", "IV", "V"];
}

public static class StringArrayExtension
{
    public static string RandomName(this string[] names, Random random)
    {
        return names[random.Next(names.Length)];
    }
}