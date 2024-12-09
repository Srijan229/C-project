namespace event1;
using System;

/*class Ships
{
    
    public delegate void ShipStatusChangedEventHandler(string shipName, bool isArriving);

    
    public event ShipStatusChangedEventHandler ShipStatusChanged;

    
    public void Arrive(string shipName)
    {
        ShipStatusChanged?.Invoke(shipName, true); 
    }

    
    public void Depart(string shipName)
    {
        ShipStatusChanged?.Invoke(shipName, false); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ships ships = new Ships();

        
        ships.ShipStatusChanged += (shipName, isArriving) =>
        {
            if (isArriving)
            {
                Console.WriteLine($"Port Control: Ship '{shipName}' has arrived.");
            }
            else
            {
                Console.WriteLine($"Port Control: Ship '{shipName}' has departed.");
            }
        };

        
        ships.Arrive("Starship Enterprise");
        ships.Depart("Imperial Star Destroyer");

        
    }
}*/
using System;

class Starships
{
    public delegate void StarshipStatusChangedEventHandler(string starshipName, bool status);

    public event StarshipStatusChangedEventHandler StarshipArrivedOrDeparted;
    public event StarshipStatusChangedEventHandler StarshipDockedOrUndocked;

    public void Arrive(string starshipName)
    {
        StarshipArrivedOrDeparted?.Invoke(starshipName, true);
    }

    public void Depart(string starshipName)
    {
        StarshipArrivedOrDeparted?.Invoke(starshipName, false);
    }

    public void Dock(string starshipName)
    {
        StarshipDockedOrUndocked?.Invoke(starshipName, true);
    }

    public void Undock(string starshipName)
    {
        StarshipDockedOrUndocked?.Invoke(starshipName, false);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Starships starships = new Starships();

        starships.StarshipArrivedOrDeparted += (starshipName, isArriving) =>
        {
            if (isArriving)
            {
                Console.WriteLine($"Port Control: Starship '{starshipName}' has arrived.");
            }
            else
            {
                Console.WriteLine($"Port Control: Starship '{starshipName}' has departed.");
            }
        };

        starships.StarshipDockedOrUndocked += (starshipName, isDocking) =>
        {
            if (isDocking)
            {
                Console.WriteLine($"Port Control: Starship '{starshipName}' has docked.");
            }
            else
            {
                Console.WriteLine($"Port Control: Starship '{starshipName}' has undocked.");
            }
        };

        starships.Arrive("Starship Enterprise");
        starships.Depart("Imperial Star Destroyer");
        starships.Dock("Starship Enterprise");
        starships.Undock("Imperial Star Destroyer");
        Console.ReadKey();
    }
}

