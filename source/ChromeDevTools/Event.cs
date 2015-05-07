namespace MasterDevs.ChromeDevTools
{
    public interface IEvent
    {
        string Method { get; set; }
    }

    public class Event : IEvent
    {
        public string Method { get; set; }
    }

    public class Event<T> : Event
    {
        public T Params { get; set; }
    }
}