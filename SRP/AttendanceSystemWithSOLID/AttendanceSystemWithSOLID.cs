namespace SRP.AttendanceSystemWithSOLID
{
    public class AttendanceSystemWithSOLID
    {
        private readonly MailSender _sender;
        private readonly Logger _logger;
        public AttendanceSystemWithSOLID()
        {
            _sender = new MailSender();
            _logger = new Logger();
        }

        public void AddAttendance()
        {
            Console.WriteLine("attendance added");
            _sender.SendEmail();
            _logger.LogInformation();
        }
        public void DeleteAttendance()
        {
            Console.WriteLine("attendance deleted");
            _sender.SendEmail();
            _logger.LogInformation();
        }
    }
}
