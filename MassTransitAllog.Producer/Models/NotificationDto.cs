namespace MassTransitAllog.Producer.Models;
    public class NotificationDto
    {
        public DateTime Date { get; set; }
        public string Message { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
    }
