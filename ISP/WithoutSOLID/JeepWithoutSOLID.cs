namespace ISP.WithoutSOLID
{
    public class JeepWithoutSOLID : ICarWithoutSOLID
    {
        public void Drive()
        {
            Console.WriteLine("jeep driving");
        }

        public void Start()
        {
            Console.WriteLine("jeep engine strated");
        }

        public void StartAIAssistant()
        {
            throw new NotImplementedException();
        }
    }
}
