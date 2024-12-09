namespace out1
{
    using System;

    class GalacticPlanetaryUnion
    {
        public void GetPlanetDetails(string planetName, out string status, out bool hasDefense, out string preferences)
        {
            if (planetName == "Earth")
            {
                status = "Registered";
                hasDefense = true;
                preferences = "Peaceful coexistence";
            }
            else if (planetName == "Mars")
            {
                status = "Registered";
                hasDefense = false;
                preferences = "Scientific research";
            }
            else
            {
                status = "Not registered";
                hasDefense = false;
                preferences = "Unknown";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GalacticPlanetaryUnion union = new GalacticPlanetaryUnion();

            string planetName = "Earth";
            string status;
            bool hasDefense;
            string preferences;

            union.GetPlanetDetails(planetName, out status, out hasDefense, out preferences);

            Console.WriteLine($"Planet: {planetName}");
            Console.WriteLine($"Status: {status}");
            Console.WriteLine($"Defense: {hasDefense}");
            Console.WriteLine($"Preferences: {preferences}");
            Console.ReadKey();
        }
    }
}
