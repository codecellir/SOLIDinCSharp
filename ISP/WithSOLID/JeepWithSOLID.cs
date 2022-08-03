namespace ISP.WithSOLID
{
    public class JeepWithSOLID : ICarWithSOLID
    {
        public void Drive()
        {
            Console.WriteLine("jeep driving");
        }

        public void Start()
        {
            Console.WriteLine("jeep engine started");
        }
    }
}
