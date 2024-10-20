using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");



        // Both machine1 and machine2 will point to the same object.
        // Usage
        //ChocolateMachine machine1 = ChocolateMachine.GetInstance();



        //ChocolateMachine machine2 = ChocolateMachine.GetInstance();



        //Learn_GetSingleton sing1 = Learn_GetSingleton.GetInstance();


        //Learn_GetSingleton sing2 = Learn_GetSingleton.GetInstance();

        //IVehicle vard = VehicleFactory.getVechicle("car");
        //vard.Describe();



        GameMaster gameMaster = new GameMaster();
        gameMaster.RegisterPlayer(new Player("Kaushal"));
        gameMaster.RegisterPlayer(new Player("Manoj"));
        gameMaster.RegisterPlayer(new Player("Patel"));

        gameMaster.GameOver();

        






    }
}