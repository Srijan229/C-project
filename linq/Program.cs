namespace linq;

class Planet
{
    public int PlanetId { get; set; }
    public string PlanetName { get; set; }
    public string Sector { get; set; }

    public Planet(int planetId, string planetName, string sector)
    {
        PlanetId = planetId;
        PlanetName = planetName;
        Sector = sector;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Planet> planetList = new List<Planet>();
        planetList.Add(new Planet(301, "Earth", "Alpha"));
        planetList.Add(new Planet(302, "C-342", "Alpha"));
        planetList.Add(new Planet(303, "Y-cintra", "Beta"));
        planetList.Add(new Planet(304, "xc-0901", "Beta"));
        planetList.Add(new Planet(305, "glapti-4", "Gamma"));

        var filteredPlanets = from planet in planetList
                              where planet.Sector == "Alpha"
                              select planet;
        Console.WriteLine("Planets in Alpha Sector");
        foreach (Planet planet in filteredPlanets)
        {
            Console.WriteLine($"Planet ID: {planet.PlanetId}\nPlanet Name: {planet.PlanetName}");
        }

        var orderedPlanets = from planet in planetList
                             orderby planet.PlanetName
                             select planet;
        Console.WriteLine("Planets Ordered by Name");
        foreach (Planet planet in orderedPlanets)
        {
            Console.WriteLine(planet.PlanetName);
        }

        var groupedPlanets = from planet in planetList
                             group planet by planet.Sector into planetGroup
                             select planetGroup;
        Console.WriteLine("Planets Grouped by Sector");
        foreach (var group in groupedPlanets)
        {
            Console.WriteLine($"Sector: {group.Key}");
            foreach (var planet in group)
            {
                Console.WriteLine(planet.PlanetName);
            }
        }
    }
}