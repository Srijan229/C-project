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
    static PlanetaryUnion()
    {
        Console.WriteLine("This is a Planatary Union database");
        Console.WriteLine("This is a Static Constructor");
    }

    public override string ToString()
    {
        return $"UnionId: {UnionId}, SystemName: {SystemName}, AmbassadorName: {AmbassadorName}";
    }

    public  void Count1()
    {
        Console.WriteLine($"Count of objects is {Count}");
    }
}
class planetary_level : PlanetaryUnion
{
    public int union_level { get; set;}
    public planetary_level(int unionId, string systemName, string ambassadorName, int union_level_c): base(unionId,systemName,ambassadorName)
    {
        union_level=union_level_c;
    }
    public void access_check()
    {
        if( union_level>4)
        {
            Console.WriteLine($"{UnionId} has High Tier Access");
        }
        else
        {
            Console.WriteLine($"{UnionId} has Low Tier Access");
        }
    }
    public override string ToString()
    {
        return $"UnionId: {UnionId}, SystemName: {SystemName}, AmbassadorName: {AmbassadorName}, Union Level: {union_level}";
    }
    public class Defence : planetary_level
    {   
        public int military_level_c{get; set;}
        public Defence(int unionId, string systemName, string ambassadorName, int union_level_c, int military_level) : base (unionId, systemName, ambassadorName, union_level_c)
        {
            military_level_c=military_level;
            
        }
        public void military_check()
        {
            if(military_level_c>8)
            {
                Console.WriteLine($"{UnionId} Good Platenary defence ");
            }
            else
            {
                Console.WriteLine($"{UnionId} Avg Platenary defence");
            }
        }
        public override string ToString()
    {
        return $"UnionId: {UnionId}, SystemName: {SystemName}, AmbassadorName: {AmbassadorName}, Union Level: {union_level}, Military_level:{military_level_c}" ;
    }
    }
}
class capital_info 
{
    public PlanetaryUnion plant;
    public string capital{get;set;}
    public capital_info(string capital_c,PlanetaryUnion plant)
    {
        capital=capital_c;
        this.plant=plant;

    }
    public void display()
    {   Console.WriteLine("This is has a relationship example");
        Console.WriteLine( $"Information:{this.plant}, Capital:{capital}");
    }

}

public class GalacticGovt
{
    public static void Main(string[] args)
    {
        planetary_level.Defence obj1 = new planetary_level.Defence(123123, "g9831", "Srijan",5,8);
        planetary_level.Defence obj2 = new planetary_level.Defence(321321, "h3829", "Srijan1",4,9);
        Console.WriteLine(obj1.ToString());
        Console.WriteLine(obj2.ToString());
        PlanetaryUnion obj3 =new PlanetaryUnion(123123, "g9831", "Srijan");
        capital_info obj4 = new capital_info("Cintra",obj3);
        obj4.display();
        Console.WriteLine(obj4.ToString());
        obj1.access_check();
        obj2.access_check();
        obj1.military_check();
        obj2.military_check();
        obj2.Count1();
        Console.ReadKey();
       
    }
}

				