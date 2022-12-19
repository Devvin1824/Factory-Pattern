namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of wheels to create a vehicle: ");
            int wheelCount = int.Parse(Console.ReadLine());
            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
