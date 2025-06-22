
class Program
{
    static void Main(string[] args)
    {
        Logistics logistics;

        Console.Write("Enter mode of transportation (road/sea): ");
        string mode = Console.ReadLine();

        // If mode is road create an instance for roadlogistics
        if (mode == "road")
        {
            logistics = new RoadLogistics();
        }

        // If mode is sea create an instance for Sealogistics
        else
        {
            logistics = new SeaLogistics();
        }

        logistics.PlanDelivery();
    }
}
