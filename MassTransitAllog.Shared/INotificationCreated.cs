namespace MassTransitAllog.Shared;
    public interface INotificationCreated
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
    }
