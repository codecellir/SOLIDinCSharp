namespace ISP.WithSOLID
{
    public class TeslaWithSOLID : IAICarWithSOLID
    {
        public void Drive()
        {
            Console.WriteLine("tesla driving");
        }

        public void Start()
        {
            Console.WriteLine("tesla engine started");
        }

        public void StartAIAssistant()
        {
            Console.WriteLine("tesla AI Assistant started");
        }
    }
}
