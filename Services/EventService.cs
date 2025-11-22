using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private readonly List<Event> _events = new()
        {
            new Event { Id = 1, Name = "Tech Summit", Date = DateTime.Today.AddDays(7), Location = "Berlin" },
            new Event { Id = 2, Name = "Marketing Meetup", Date = DateTime.Today.AddDays(14), Location = "Budapest" },
            new Event { Id = 3, Name = "Product Launch", Date = DateTime.Today.AddDays(21), Location = "Vienna" }
        };

        public List<Event> GetEvents() => _events;

        public Event? GetEventById(int id) => _events.FirstOrDefault(e => e.Id == id);
    }
}
