namespace formdemo;

 class Program
{
    static async Task Main(string[] args)
    {
        Task task = SomeWork();
        Console.WriteLine("checking password from the Db");
        await task;
        Console.WriteLine("retrieves the Pwd");
        Console.ReadKey();
    }
    static async Task SomeWork()
    {
        Console.WriteLine("checking user name from the DB");
        await Task.Delay(3000);
        Console.WriteLine("retreives Username from DB");
    }
}