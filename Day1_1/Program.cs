using System;

class PlanetaryUnion
{   
    public int UnionId { get; set; }
    public string SystemName { get; set; }
    public string AmbassadorName { get; set; }
    public static int Count = 0;

    public PlanetaryUnion(int unionId, string systemName, string ambassadorName)
    {
        UnionId = unionId;
        SystemName = systemName;
        AmbassadorName = ambassadorName;
        Count++;
    }

    public override string ToString()
    {
        return $"UnionId: {UnionId}, SystemName: {SystemName}, AmbassadorName: {AmbassadorName}";
    }

    public static void Count1()
    {
        Console.WriteLine($"Count of objects is {Count}");
    }
}

public class GalacticGovt
{
    public static void Main(string[] args)
    {
        PlanetaryUnion obj1 = new PlanetaryUnion(123123, "g9831", "Srijan");
        PlanetaryUnion obj2 = new PlanetaryUnion(321321, "h3829", "Srijan1");

        Console.WriteLine(obj1.ToString());
        Console.WriteLine(obj2.ToString());

        PlanetaryUnion.Count1();
    }
}

				